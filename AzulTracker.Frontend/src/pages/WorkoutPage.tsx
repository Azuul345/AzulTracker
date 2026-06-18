import { useEffect, useState } from "react";
import { workoutService } from "../services/workoutService";
import {
  getPrograms,
  getDays,
  getExercisesForDay,
} from "../services/programService";
import type { WorkoutLogDto } from "../types/workout";
import type {
  TrainingProgram,
  ProgramExercise,
  ExerciseMuscle,
} from "../types/program";
import LogSetForm from "../components/LogSetForm";
import VideoEmbed from "../components/VideoEmbed";

const today = new Date().toISOString().split("T")[0];

export default function WorkoutPage() {
  const [activeProgram, setActiveProgram] = useState<TrainingProgram | null>(
    null,
  );
  const [days, setDays] = useState<{ id: number; name: string }[]>([]);
  const [selectedDayId, setSelectedDayId] = useState<number | null>(null);
  const [exercises, setExercises] = useState<ProgramExercise[]>([]);
  const [todaysLogs, setTodaysLogs] = useState<WorkoutLogDto[]>([]);
  const [historyLogs, setHistoryLogs] = useState<WorkoutLogDto[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [isGuided, setIsGuided] = useState(false);
  const [guidedIndex, setGuidedIndex] = useState(0);
  const [openVideoIds, setOpenVideoIds] = useState<Set<number>>(new Set()); // ✅ inside component

  const [showMusclesForExercise, setShowMusclesForExercise] = useState<
    Record<number, boolean>
  >({});

  const toggleMuscles = (id: number) => {
    setShowMusclesForExercise((prev) => ({ ...prev, [id]: !prev[id] }));
  };

  function splitMuscles(muscles: NonNullable<ProgramExercise["muscles"]>) {
    return {
      primary: muscles.filter((m) => m.isPrimary),
      secondary: muscles.filter((m) => !m.isPrimary),
    };
  }
  const toggleVideo = (id: number) => {
    setOpenVideoIds((prev) => {
      const next = new Set(prev);
      if (next.has(id)) {
        next.delete(id);
      } else {
        next.add(id);
      }
      return next;
    });
  };

  useEffect(() => {
    const loadData = async () => {
      try {
        const programs = (await getPrograms()).data;
        const active = programs.find((p) => p.isActive) ?? null;
        setActiveProgram(active);

        if (active) {
          const programDays = (await getDays(active.id)).data;
          setDays(programDays);
          if (programDays.length > 0) setSelectedDayId(programDays[0].id);
        }

        const logs = await workoutService.getByDate(today);
        setTodaysLogs(logs);

        const history = await workoutService.getHistory();
        setHistoryLogs(history);
      } catch {
        setError("Failed to load workout data.");
      } finally {
        setIsLoading(false);
      }
    };

    loadData();
  }, []);

  useEffect(() => {
    if (!activeProgram || !selectedDayId) return;

    const loadExercises = async () => {
      const result = await getExercisesForDay(activeProgram.id, selectedDayId);
      setExercises(result.data);
    };

    loadExercises();
  }, [selectedDayId, activeProgram]);

  if (isLoading) return <p>Loading...</p>;
  if (error) return <p>{error}</p>;
  if (!activeProgram) return <p>No active program. Go set one up first.</p>;

  const normalizeDate = (dateString: string) => {
    return dateString.split("T")[0];
  };

  const getLastWorkoutLogs = (exerciseName: string) => {
    const previousLogs = historyLogs.filter(
      (log) =>
        log.exerciseName === exerciseName && normalizeDate(log.date) !== today,
    );

    if (previousLogs.length === 0) {
      return null;
    }

    const lastWorkoutDate = normalizeDate(previousLogs[0].date);

    const lastWorkoutLogs = previousLogs
      .filter((log) => normalizeDate(log.date) === lastWorkoutDate)
      .sort((a, b) => a.setNumber - b.setNumber);

    return {
      date: lastWorkoutDate,
      logs: lastWorkoutLogs,
    };
  };

  const formatWorkoutDate = (dateString: string) => {
    return new Date(dateString).toLocaleDateString();
  };

  const visibleExercises = isGuided
    ? [exercises[guidedIndex]].filter(Boolean)
    : exercises;

  return (
    <div>
      <h1>Today's Workout</h1>
      <p>{activeProgram.name}</p>

      <button
        onClick={() => {
          setIsGuided((prev) => !prev);
          setGuidedIndex(0);
        }}
      >
        {isGuided ? "Switch to Full Day View" : "Switch to Guided Mode"}
      </button>

      <div style={{ display: "flex", gap: "8px", margin: "16px 0" }}>
        {days.map((day) => (
          <button
            key={day.id}
            onClick={() => setSelectedDayId(day.id)}
            style={{
              fontWeight: selectedDayId === day.id ? "bold" : "normal",
              textDecoration: selectedDayId === day.id ? "underline" : "none",
            }}
          >
            {day.name}
          </button>
        ))}
      </div>

      <div>
        {visibleExercises.map((exercise) => {
          const exerciseName =
            exercise.customExerciseName ?? exercise.exerciseName ?? "Unknown";
          const logsForThisExercise = todaysLogs.filter(
            (log) => log.exerciseName === exerciseName,
          );

          const lastWorkout = getLastWorkoutLogs(exerciseName);

          return (
            <div
              key={exercise.id}
              style={{
                border: "1px solid #ccc",
                padding: "16px",
                marginBottom: "12px",
              }}
            >
              <h3>{exerciseName}</h3>
              <p>
                {exercise.sets} sets × {exercise.reps} reps
              </p>
              {exercise.notes && (
                <p>
                  <em>{exercise.notes}</em>
                </p>
              )}

              {exercise.videoUrl && (
                <div style={{ marginTop: "12px", marginBottom: "12px" }}>
                  <button onClick={() => toggleVideo(exercise.id)}>
                    {openVideoIds.has(exercise.id)
                      ? "Hide Video"
                      : "Watch Video"}
                  </button>
                  {openVideoIds.has(exercise.id) && (
                    <div style={{ marginTop: "8px" }}>
                      <VideoEmbed url={exercise.videoUrl} />
                    </div>
                  )}
                </div>
              )}

              {exercise.muscles && exercise.muscles.length > 0 && (
                <div
                  id={`workout-exercise-${exercise.id}-muscles-section`}
                  style={{ marginTop: "12px", marginBottom: "12px" }}
                >
                  <button onClick={() => toggleMuscles(exercise.id)}>
                    {showMusclesForExercise[exercise.id]
                      ? "Hide Muscles ▴"
                      : "Show Muscles ▾"}
                  </button>

                  {showMusclesForExercise[exercise.id] &&
                    (() => {
                      const { primary, secondary } = splitMuscles(
                        exercise.muscles!,
                      );
                      return (
                        <div
                          id={`workout-exercise-${exercise.id}-muscles-panel`}
                        >
                          {primary.length > 0 && (
                            <div
                              id={`workout-exercise-${exercise.id}-primary-muscles`}
                              style={{ marginTop: "8px" }}
                            >
                              <strong>Primary muscles</strong>
                              <div
                                style={{
                                  display: "flex",
                                  gap: "8px",
                                  flexWrap: "wrap",
                                  marginTop: "4px",
                                }}
                              >
                                {primary.map((m: ExerciseMuscle) => (
                                  <div
                                    key={m.muscleId}
                                    id={`workout-exercise-${exercise.id}-muscle-${m.muscleId}`}
                                    data-muscle-id={m.muscleId}
                                    data-is-primary="true"
                                    style={{ textAlign: "center" }}
                                  >
                                    {m.imageUrl && (
                                      <img
                                        id={`workout-exercise-${exercise.id}-muscle-${m.muscleId}-img`}
                                        src={m.imageUrl}
                                        alt={m.muscleName}
                                        style={{
                                          width: 80,
                                          height: 80,
                                          objectFit: "cover",
                                        }}
                                      />
                                    )}
                                    <div style={{ fontSize: "0.75rem" }}>
                                      {m.muscleName}
                                    </div>
                                  </div>
                                ))}
                              </div>
                            </div>
                          )}

                          {secondary.length > 0 && (
                            <div
                              id={`workout-exercise-${exercise.id}-secondary-muscles`}
                              style={{ marginTop: "8px" }}
                            >
                              <strong>Secondary muscles</strong>
                              <div
                                style={{
                                  display: "flex",
                                  gap: "8px",
                                  flexWrap: "wrap",
                                  marginTop: "4px",
                                }}
                              >
                                {secondary.map((m: ExerciseMuscle) => (
                                  <div
                                    key={m.muscleId}
                                    id={`workout-exercise-${exercise.id}-muscle-${m.muscleId}`}
                                    data-muscle-id={m.muscleId}
                                    data-is-primary="false"
                                    style={{ textAlign: "center" }}
                                  >
                                    {m.imageUrl && (
                                      <img
                                        id={`workout-exercise-${exercise.id}-muscle-${m.muscleId}-img`}
                                        src={m.imageUrl}
                                        alt={m.muscleName}
                                        style={{
                                          width: 80,
                                          height: 80,
                                          objectFit: "cover",
                                        }}
                                      />
                                    )}
                                    <div style={{ fontSize: "0.75rem" }}>
                                      {m.muscleName}
                                    </div>
                                  </div>
                                ))}
                              </div>
                            </div>
                          )}
                        </div>
                      );
                    })()}
                </div>
              )}

              <div style={{ marginTop: "12px" }}>
                <strong>Last workout:</strong>

                {lastWorkout ? (
                  <>
                    <p>{formatWorkoutDate(lastWorkout.date)}</p>
                    {lastWorkout.logs.map((log) => (
                      <p key={log.id}>
                        Set {log.setNumber}: {log.weight}kg ×{" "}
                        {log.repsCompleted} reps
                        {log.rpe != null && ` — RPE ${log.rpe}`}
                      </p>
                    ))}
                  </>
                ) : (
                  <p>No previous workout logged yet.</p>
                )}
              </div>

              {logsForThisExercise.length > 0 && (
                <div>
                  <strong>Logged today:</strong>
                  {logsForThisExercise.map((log) => (
                    <p key={log.id}>
                      Set {log.setNumber}: {log.weight}kg × {log.repsCompleted}{" "}
                      reps
                      {log.rpe != null && ` — RPE ${log.rpe}`}
                    </p>
                  ))}
                </div>
              )}

              <LogSetForm
                exercise={exercise}
                nextSetNumber={logsForThisExercise.length + 1}
                onLogged={(newLog) => {
                  setTodaysLogs((prev) => [...prev, newLog]);
                  setHistoryLogs((prev) => [newLog, ...prev]);
                }}
              />
            </div>
          );
        })}
      </div>

      {isGuided && exercises.length > 0 && (
        <div style={{ display: "flex", gap: "8px", marginTop: "16px" }}>
          <button
            onClick={() => setGuidedIndex((prev) => Math.max(0, prev - 1))}
            disabled={guidedIndex === 0}
          >
            ← Previous
          </button>
          <span>
            {guidedIndex + 1} / {exercises.length}
          </span>
          <button
            onClick={() =>
              setGuidedIndex((prev) => Math.min(exercises.length - 1, prev + 1))
            }
            disabled={guidedIndex === exercises.length - 1}
          >
            Next →
          </button>
        </div>
      )}
    </div>
  );
}
