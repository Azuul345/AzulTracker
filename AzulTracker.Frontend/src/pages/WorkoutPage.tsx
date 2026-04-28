import { useEffect, useState } from 'react';
import { workoutService } from '../services/workoutService';
import { getPrograms, getDays, getExercisesForDay } from '../services/programService';
import type { WorkoutLogDto } from '../types/workout';
import type { TrainingProgram, ProgramExercise } from '../types/program';
import LogSetForm from '../components/LogSetForm';

 const today = new Date().toISOString().split('T')[0];

export default function WorkoutPage() {
  const [activeProgram, setActiveProgram] = useState<TrainingProgram | null>(null);
  const [days, setDays] = useState<{ id: number; name: string }[]>([]);
  const [selectedDayId, setSelectedDayId] = useState<number | null>(null);
  const [exercises, setExercises] = useState<ProgramExercise[]>([]);
  const [todaysLogs, setTodaysLogs] = useState<WorkoutLogDto[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [isGuided, setIsGuided] = useState(false);
  const [guidedIndex, setGuidedIndex] = useState(0);

 

  useEffect(() => {
    const loadData = async () => {
      try {
        const programs = (await getPrograms()).data;
        const active = programs.find(p => p.isActive) ?? null;
        setActiveProgram(active);

        if (active) {
          const programDays = (await getDays(active.id)).data;
          setDays(programDays);
          if (programDays.length > 0) setSelectedDayId(programDays[0].id);
        }

        const logs = await workoutService.getByDate(today);
        setTodaysLogs(logs);
      } catch {
        setError('Failed to load workout data.');
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

  const visibleExercises = isGuided
    ? [exercises[guidedIndex]].filter(Boolean)
    : exercises;

  return (
    <div>
      <h1>Today's Workout</h1>
      <p>{activeProgram.name}</p>

      <button onClick={() => { setIsGuided(prev => !prev); setGuidedIndex(0); }}>
        {isGuided ? 'Switch to Full Day View' : 'Switch to Guided Mode'}
      </button>

      <div style={{ display: 'flex', gap: '8px', margin: '16px 0' }}>
        {days.map(day => (
          <button
            key={day.id}
            onClick={() => setSelectedDayId(day.id)}
            style={{
              fontWeight: selectedDayId === day.id ? 'bold' : 'normal',
              textDecoration: selectedDayId === day.id ? 'underline' : 'none',
            }}
          >
            {day.name}
          </button>
        ))}
      </div>

      <div>
        {visibleExercises.map(exercise => {
          const exerciseName = exercise.customExerciseName ?? exercise.exerciseName ?? 'Unknown';
          const logsForThisExercise = todaysLogs.filter(
            log => log.exerciseName === exerciseName
          );

          return (
            <div key={exercise.id} style={{ border: '1px solid #ccc', padding: '16px', marginBottom: '12px' }}>
              <h3>{exerciseName}</h3>
              <p>{exercise.sets} sets × {exercise.reps} reps</p>
              {exercise.notes && <p><em>{exercise.notes}</em></p>}

              {logsForThisExercise.length > 0 && (
                <div>
                  <strong>Logged today:</strong>
                  {logsForThisExercise.map(log => (
                    <p key={log.id}>
                      Set {log.setNumber}: {log.weight}kg × {log.repsCompleted} reps
                      {log.rpe != null && ` — RPE ${log.rpe}`}
                    </p>
                  ))}
                </div>
              )}

              <LogSetForm
                exercise={exercise}
                nextSetNumber={logsForThisExercise.length + 1}
                onLogged={(newLog) => setTodaysLogs(prev => [...prev, newLog])}
              />
            </div>
          );
        })}
      </div>

      {isGuided && exercises.length > 0 && (
        <div style={{ display: 'flex', gap: '8px', marginTop: '16px' }}>
          <button
            onClick={() => setGuidedIndex(prev => Math.max(0, prev - 1))}
            disabled={guidedIndex === 0}
          >
            ← Previous
          </button>
          <span>{guidedIndex + 1} / {exercises.length}</span>
          <button
            onClick={() => setGuidedIndex(prev => Math.min(exercises.length - 1, prev + 1))}
            disabled={guidedIndex === exercises.length - 1}
          >
            Next →
          </button>
        </div>
      )}
    </div>
  );
}