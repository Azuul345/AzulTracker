import { useEffect, useState, useCallback } from "react";
import { useParams } from "react-router-dom";
import {
  getPrograms,
  getDays,
  getExercisesForDay,
  createDay,
  deleteDay,
  createExercise,
  deleteExercise,
  updateExercise,
  searchExercises,
  submitExercise,
  submitMuscle,
  getApprovedMuscles,
} from "../services/programService";
import type {
  TrainingProgram,
  ProgramDay,
  ProgramExercise,
  ExerciseSearchResult,
  ExerciseMuscle,
  MuscleOption,
  MuscleAssignment,
} from "../types/program";

export default function ProgramDetailPage() {
  const { id } = useParams<{ id: string }>();
  const programId = Number(id);

  const [program, setProgram] = useState<TrainingProgram | null>(null);
  const [days, setDays] = useState<ProgramDay[]>([]);
  const [exercisesByDay, setExercisesByDay] = useState<
    Record<number, ProgramExercise[]>
  >({});
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const [showDayForm, setShowDayForm] = useState(false);
  const [dayName, setDayName] = useState("");

  const [activeDayId, setActiveDayId] = useState<number | null>(null);
  const [sets, setSets] = useState(3);
  const [reps, setReps] = useState(8);
  const [notes, setNotes] = useState("");
  const [searchQuery, setSearchQuery] = useState("");
  const [searchResults, setSearchResults] = useState<ExerciseSearchResult[]>(
    [],
  );
  const [selectedExercise, setSelectedExercise] =
    useState<ExerciseSearchResult | null>(null);
  const [customName, setCustomName] = useState("");
  const [videoUrl, setVideoUrl] = useState("");

  const [editingExerciseId, setEditingExerciseId] = useState<number | null>(
    null,
  );
  const [editSets, setEditSets] = useState(3);
  const [editReps, setEditReps] = useState(8);
  const [editNotes, setEditNotes] = useState("");
  const [editVideoUrl, setEditVideoUrl] = useState("");

  // NEW: track which exercises have muscles panel open
  const [showMusclesForExercise, setShowMusclesForExercise] = useState<
    Record<number, boolean>
  >({});
  // Submission form state
  const [showSubmitForm, setShowSubmitForm] = useState(false);
  const [submitName, setSubmitName] = useState("");
  const [submitCategory, setSubmitCategory] = useState("");
  const [submitDescription, setSubmitDescription] = useState("");
  const [submitVideoUrl, setSubmitVideoUrl] = useState("");
  const [availableMuscles, setAvailableMuscles] = useState<MuscleOption[]>([]);
  const [muscleAssignments, setMuscleAssignments] = useState<
    MuscleAssignment[]
  >([]);
  const [showNewMuscleForm, setShowNewMuscleForm] = useState(false);
  const [newMuscleName, setNewMuscleName] = useState("");
  const [newMuscleGroup, setNewMuscleGroup] = useState("");
  const [submitError, setSubmitError] = useState<string | null>(null);
  const [submitting, setSubmitting] = useState(false);
  const [showPrimaryPicker, setShowPrimaryPicker] = useState(false);
  const [showSecondaryPicker, setShowSecondaryPicker] = useState(false);
  const loadProgram = useCallback(async () => {
    try {
      setError(null);
      setLoading(true);
      const res = await getPrograms();
      const found = res.data.find((p) => p.id === programId);
      if (!found) {
        setError("Program not found.");
        return;
      }
      setProgram(found);
      const daysData = await getDays(programId);
      setDays(daysData.data);
      const exMap: Record<number, ProgramExercise[]> = {};
      for (const day of daysData.data) {
        const exRes = await getExercisesForDay(programId, day.id);
        exMap[day.id] = exRes.data;
      }
      setExercisesByDay(exMap);
    } catch {
      setError("Failed to load program.");
    } finally {
      setLoading(false);
    }
  }, [programId]);

  useEffect(() => {
    loadProgram();
  }, [loadProgram]);

  useEffect(() => {
    getApprovedMuscles().then((res) => setAvailableMuscles(res.data));
  }, []);

  const MUSCLE_GROUPS = [
    "Chest",
    "Back",
    "Shoulders",
    "Arms",
    "Core",
    "Legs",
    "Glutes",
    "Calves",
  ];

  function resetSubmitForm() {
    setShowSubmitForm(false);
    setSubmitName("");
    setSubmitCategory("");
    setSubmitDescription("");
    setSubmitVideoUrl("");
    setMuscleAssignments([]);
    setShowNewMuscleForm(false);
    setNewMuscleName("");
    setNewMuscleGroup("");
    setSubmitError(null);
    setShowPrimaryPicker(false);
    setShowSecondaryPicker(false);
  }

  async function handleSubmitNewExercise(dayId: number) {
    if (!submitName.trim()) {
      setSubmitError("Name is required.");
      return;
    }
    if (!submitCategory) {
      setSubmitError("Category is required.");
      return;
    }
    if (muscleAssignments.length === 0) {
      setSubmitError("At least one muscle is required.");
      return;
    }

    setSubmitting(true);
    setSubmitError(null);
    try {
      // 1. Submit any new muscles first and collect their IDs
      let allAssignments = [...muscleAssignments];
      if (showNewMuscleForm && newMuscleName.trim() && newMuscleGroup) {
        const muscleRes = await submitMuscle({
          name: newMuscleName.trim(),
          muscleGroup: newMuscleGroup,
        });
        allAssignments = [
          ...allAssignments,
          { muscleId: muscleRes.data.id, isPrimary: true },
        ];
      }

      // 2. Submit the exercise to the library
      const exRes = await submitExercise({
        name: submitName.trim(),
        category: submitCategory,
        description: submitDescription || undefined,
        muscleAssignments: allAssignments,
      });

      // 3. Add it to the program day (video URL goes here, NOT on the exercise)
      const orderIndex = (exercisesByDay[dayId]?.length ?? 0) + 1;
      await createExercise(programId, dayId, {
        exerciseLibraryId: exRes.data.id,
        sets,
        reps,
        orderIndex,
        notes: notes || undefined,
        videoUrl: submitVideoUrl || undefined,
      });

      resetSubmitForm();
      setActiveDayId(null);
      resetExerciseForm();
      await loadProgram();
    } catch {
      setSubmitError("Submission failed. You may have hit the 3/hour limit.");
    } finally {
      setSubmitting(false);
    }
  }

  async function handleSearch(query: string) {
    setSearchQuery(query);
    setSelectedExercise(null);
    if (query.length < 2) {
      setSearchResults([]);
      return;
    }
    try {
      const res = await searchExercises(query);
      setSearchResults(res.data);
    } catch {
      setSearchResults([]);
    }
  }

  async function handleAddDay(e: React.FormEvent) {
    e.preventDefault();
    try {
      setError(null);
      await createDay(programId, { name: dayName, dayOrder: days.length + 1 });
      setDayName("");
      setShowDayForm(false);
      await loadProgram();
    } catch {
      setError("Failed to add day.");
    }
  }

  async function handleDeleteDay(dayId: number) {
    try {
      setError(null);
      await deleteDay(programId, dayId);
      await loadProgram();
    } catch {
      setError("Failed to delete day.");
    }
  }

  async function handleAddExercise(e: React.FormEvent, dayId: number) {
    e.preventDefault();
    const orderIndex = (exercisesByDay[dayId]?.length ?? 0) + 1;
    try {
      setError(null);
      await createExercise(programId, dayId, {
        exerciseLibraryId: selectedExercise?.id,
        customExerciseName: !selectedExercise ? customName : undefined,
        sets,
        reps,
        orderIndex,
        notes: notes || undefined,
        videoUrl: videoUrl || undefined,
      });
      setActiveDayId(null);
      resetExerciseForm();
      await loadProgram();
    } catch {
      setError("Failed to add exercise.");
    }
  }

  async function handleDeleteExercise(dayId: number, exerciseId: number) {
    try {
      setError(null);
      await deleteExercise(programId, dayId, exerciseId);
      await loadProgram();
    } catch {
      setError("Failed to delete exercise.");
    }
  }

  async function handleEditExercise(
    e: React.FormEvent,
    dayId: number,
    ex: ProgramExercise,
  ) {
    e.preventDefault();
    try {
      setError(null);
      await updateExercise(programId, dayId, ex.id, {
        exerciseLibraryId: ex.exerciseLibraryId ?? undefined,
        customExerciseName: ex.customExerciseName ?? undefined,
        sets: editSets,
        reps: editReps,
        orderIndex: ex.orderIndex,
        notes: editNotes || undefined,
        videoUrl: editVideoUrl || undefined,
      });
      setEditingExerciseId(null);
      await loadProgram();
    } catch {
      setError("Failed to update exercise.");
    }
  }

  function resetExerciseForm() {
    setSets(3);
    setReps(8);
    setNotes("");
    setVideoUrl("");
    setSearchQuery("");
    setSearchResults([]);
    setSelectedExercise(null);
    setCustomName("");
  }

  function toggleMuscles(exerciseId: number) {
    setShowMusclesForExercise((prev) => ({
      ...prev,
      [exerciseId]: !prev[exerciseId],
    }));
  }

  // Helper: split muscles into primary and secondary
  function splitMuscles(muscles: ExerciseMuscle[]) {
    const primary = muscles.filter((m) => m.isPrimary);
    const secondary = muscles.filter((m) => !m.isPrimary);
    return { primary, secondary };
  }

  if (loading) return <p>Loading...</p>;
  if (error) return <p style={{ color: "red" }}>{error}</p>;
  if (!program) return null;

  return (
    <div id="program-detail-page">
      <h1 id="program-detail-title">{program.name}</h1>
      {program.description && (
        <p id="program-detail-description">{program.description}</p>
      )}

      <button onClick={() => setShowDayForm(!showDayForm)}>
        {showDayForm ? "Cancel" : "Add Day"}
      </button>

      {showDayForm && (
        <form onSubmit={handleAddDay} id="add-day-form">
          <input
            placeholder="Day name (e.g. Push Day)"
            value={dayName}
            onChange={(e) => setDayName(e.target.value)}
            required
          />
          <button type="submit">Add</button>
        </form>
      )}

      <ul id="days-list" style={{ listStyle: "none", padding: 0 }}>
        {days.map((day) => (
          <li
            key={day.id}
            id={`day-${day.id}`}
            style={{
              marginTop: "1rem",
              border: "1px solid #444",
              padding: "1rem",
            }}
          >
            <h2 id={`day-${day.id}-title`}>{day.name}</h2>
            <button onClick={() => handleDeleteDay(day.id)}>Delete Day</button>

            <ul
              id={`day-${day.id}-exercises`}
              style={{ listStyle: "none", padding: 0 }}
            >
              {(exercisesByDay[day.id] ?? []).map((ex) => (
                <li
                  key={ex.id}
                  id={`exercise-${ex.id}`}
                  data-exercise-id={ex.id}
                  data-day-id={day.id}
                  style={{ marginBottom: "0.75rem" }}
                >
                  <div
                    id={`exercise-${ex.id}-header`}
                    style={{
                      display: "flex",
                      alignItems: "center",
                      gap: "0.5rem",
                    }}
                  >
                    <strong id={`exercise-${ex.id}-name`}>
                      {ex.customExerciseName ??
                        ex.exerciseName ??
                        `Exercise #${ex.exerciseLibraryId}`}
                    </strong>
                    {" — "}
                    <span id={`exercise-${ex.id}-volume`}>
                      {ex.sets}×{ex.reps}
                    </span>
                    {ex.notes && (
                      <span
                        id={`exercise-${ex.id}-notes`}
                        style={{ color: "#aaa" }}
                      >
                        ({ex.notes})
                      </span>
                    )}
                    {ex.videoUrl && (
                      <a
                        id={`exercise-${ex.id}-video-link`}
                        href={ex.videoUrl}
                        target="_blank"
                        rel="noopener noreferrer"
                        style={{
                          marginLeft: "0.5rem",
                          fontSize: "0.8rem",
                          color: "#4da6ff",
                        }}
                      >
                        Watch
                      </a>
                    )}
                    <button
                      id={`exercise-${ex.id}-edit-btn`}
                      onClick={() => {
                        setEditingExerciseId(ex.id);
                        setEditSets(ex.sets);
                        setEditReps(ex.reps);
                        setEditNotes(ex.notes ?? "");
                        setEditVideoUrl(ex.videoUrl ?? "");
                      }}
                    >
                      Edit
                    </button>
                    <button
                      id={`exercise-${ex.id}-delete-btn`}
                      onClick={() => handleDeleteExercise(day.id, ex.id)}
                    >
                      Remove
                    </button>

                    {/* NEW: Show Muscles toggle button — only if muscles data exists */}
                    {ex.muscles && ex.muscles.length > 0 && (
                      <button
                        id={`exercise-${ex.id}-muscles-toggle-btn`}
                        onClick={() => toggleMuscles(ex.id)}
                      >
                        {showMusclesForExercise[ex.id]
                          ? "Hide Muscles"
                          : "Show Muscles"}
                      </button>
                    )}
                  </div>

                  {/* NEW: Muscles panel */}
                  {showMusclesForExercise[ex.id] &&
                    ex.muscles &&
                    ex.muscles.length > 0 && (
                      <div
                        id={`exercise-${ex.id}-muscles-panel`}
                        data-exercise-id={ex.id}
                        style={{ marginTop: "0.5rem" }}
                      >
                        {(() => {
                          const { primary, secondary } = splitMuscles(
                            ex.muscles!,
                          );
                          return (
                            <>
                              {primary.length > 0 && (
                                <div
                                  id={`exercise-${ex.id}-primary-muscles`}
                                  style={{ marginBottom: "0.5rem" }}
                                >
                                  <strong>Primary muscles</strong>
                                  <div
                                    id={`exercise-${ex.id}-primary-muscles-images`}
                                    style={{
                                      display: "flex",
                                      gap: "0.5rem",
                                      flexWrap: "wrap",
                                      marginTop: "0.25rem",
                                    }}
                                  >
                                    {primary.map((muscle) => (
                                      <div
                                        key={muscle.muscleId}
                                        id={`exercise-${ex.id}-muscle-${muscle.muscleId}`}
                                        data-muscle-id={muscle.muscleId}
                                        data-is-primary="true"
                                        style={{ textAlign: "center" }}
                                      >
                                        {muscle.imageUrl ? (
                                          <img
                                            id={`exercise-${ex.id}-muscle-${muscle.muscleId}-img`}
                                            src={muscle.imageUrl}
                                            alt={muscle.muscleName}
                                            style={{
                                              width: 80,
                                              height: 80,
                                              objectFit: "cover",
                                            }}
                                          />
                                        ) : null}
                                        <div
                                          id={`exercise-${ex.id}-muscle-${muscle.muscleId}-label`}
                                          style={{ fontSize: "0.75rem" }}
                                        >
                                          {muscle.muscleName}
                                        </div>
                                      </div>
                                    ))}
                                  </div>
                                </div>
                              )}

                              {secondary.length > 0 && (
                                <div id={`exercise-${ex.id}-secondary-muscles`}>
                                  <strong>Secondary muscles</strong>
                                  <div
                                    id={`exercise-${ex.id}-secondary-muscles-images`}
                                    style={{
                                      display: "flex",
                                      gap: "0.5rem",
                                      flexWrap: "wrap",
                                      marginTop: "0.25rem",
                                    }}
                                  >
                                    {secondary.map((muscle) => (
                                      <div
                                        key={muscle.muscleId}
                                        id={`exercise-${ex.id}-muscle-${muscle.muscleId}`}
                                        data-muscle-id={muscle.muscleId}
                                        data-is-primary="false"
                                        style={{ textAlign: "center" }}
                                      >
                                        {muscle.imageUrl ? (
                                          <img
                                            id={`exercise-${ex.id}-muscle-${muscle.muscleId}-img`}
                                            src={muscle.imageUrl}
                                            alt={muscle.muscleName}
                                            style={{
                                              width: 80,
                                              height: 80,
                                              objectFit: "cover",
                                            }}
                                          />
                                        ) : null}
                                        <div
                                          id={`exercise-${ex.id}-muscle-${muscle.muscleId}-label`}
                                          style={{ fontSize: "0.75rem" }}
                                        >
                                          {muscle.muscleName}
                                        </div>
                                      </div>
                                    ))}
                                  </div>
                                </div>
                              )}
                            </>
                          );
                        })()}
                      </div>
                    )}

                  {/* Existing edit form */}
                  {editingExerciseId === ex.id && (
                    <form
                      id={`exercise-${ex.id}-edit-form`}
                      onSubmit={(e) => handleEditExercise(e, day.id, ex)}
                      style={{
                        marginTop: "0.5rem",
                        display: "flex",
                        gap: "0.5rem",
                        alignItems: "flex-end",
                      }}
                    >
                      <label>
                        Sets
                        <input
                          type="number"
                          min={1}
                          value={editSets}
                          onChange={(e) => setEditSets(Number(e.target.value))}
                          style={{ width: 60, display: "block" }}
                          required
                        />
                      </label>
                      <label>
                        Reps
                        <input
                          type="number"
                          min={1}
                          value={editReps}
                          onChange={(e) => setEditReps(Number(e.target.value))}
                          style={{ width: 60, display: "block" }}
                          required
                        />
                      </label>
                      <label>
                        Notes
                        <input
                          placeholder="Optional"
                          value={editNotes}
                          onChange={(e) => setEditNotes(e.target.value)}
                          style={{ display: "block" }}
                        />
                      </label>
                      <label>
                        Video URL
                        <input
                          placeholder="https://youtube.com/watch?v=... (optional)"
                          value={editVideoUrl}
                          onChange={(e) => setEditVideoUrl(e.target.value)}
                          style={{ display: "block" }}
                        />
                      </label>
                      <button type="submit">Save</button>
                      <button
                        type="button"
                        onClick={() => setEditingExerciseId(null)}
                      >
                        Cancel
                      </button>
                    </form>
                  )}
                </li>
              ))}
            </ul>

            {activeDayId === day.id ? (
              <form
                id={`day-${day.id}-add-exercise-form`}
                onSubmit={(e) => handleAddExercise(e, day.id)}
                style={{
                  marginTop: "1rem",
                  display: "flex",
                  flexDirection: "column",
                  gap: "0.75rem",
                  maxWidth: "500px",
                }}
              >
                <p style={{ margin: 0, color: "#aaa" }}>
                  Search the exercise library or enter a custom exercise name.
                </p>
                <label htmlFor={`exercise-search-${day.id}`}>
                  Exercise
                  <input
                    id={`exercise-search-${day.id}`}
                    placeholder="Search exercise library..."
                    value={searchQuery}
                    onChange={(e) => handleSearch(e.target.value)}
                    style={{
                      display: "block",
                      width: "100%",
                      marginTop: "0.25rem",
                    }}
                  />
                </label>

                {searchResults.length > 0 && (
                  <ul
                    id={`day-${day.id}-search-results`}
                    style={{ marginTop: "0.5rem" }}
                  >
                    {searchResults.map((r) => (
                      <li
                        key={r.id}
                        style={{ cursor: "pointer" }}
                        onClick={() => {
                          setSelectedExercise(r);
                          setSearchQuery(r.name);
                          setSearchResults([]);
                        }}
                      >
                        {r.name} — {r.category}
                      </li>
                    ))}
                  </ul>
                )}

                {selectedExercise && <p>Selected: {selectedExercise.name}</p>}

                {/* <--- REPLACE the custom name block with this */}
                {!selectedExercise && (
                  <div id={`day-${day.id}-no-results-section`}>
                    {!showSubmitForm ? (
                      <button
                        type="button"
                        onClick={() => setShowSubmitForm(true)}
                        style={{ marginTop: "0.25rem" }}
                      >
                        + Submit a new exercise
                      </button>
                    ) : (
                      <div
                        id={`day-${day.id}-submit-form`}
                        style={{
                          border: "1px solid #555",
                          padding: "1rem",
                          marginTop: "0.5rem",
                          display: "flex",
                          flexDirection: "column",
                          gap: "0.75rem",
                        }}
                      >
                        <strong>Submit a new exercise</strong>
                        {submitError && (
                          <p style={{ color: "red", margin: 0 }}>
                            {submitError}
                          </p>
                        )}

                        <label>
                          Name (required)
                          <input
                            placeholder="e.g. Cable Lateral Raise"
                            value={submitName}
                            onChange={(e) => setSubmitName(e.target.value)}
                            style={{
                              display: "block",
                              width: "100%",
                              marginTop: "0.25rem",
                            }}
                            required
                          />
                        </label>

                        <label>
                          Category (required)
                          <select
                            value={submitCategory}
                            onChange={(e) => setSubmitCategory(e.target.value)}
                            style={{
                              display: "block",
                              width: "100%",
                              marginTop: "0.25rem",
                            }}
                            required
                          >
                            <option value="">— Select category —</option>
                            {MUSCLE_GROUPS.map((g) => (
                              <option key={g} value={g}>
                                {g}
                              </option>
                            ))}
                          </select>
                        </label>

                        <label>
                          Description (optional)
                          <textarea
                            placeholder="Describe the exercise..."
                            value={submitDescription}
                            onChange={(e) =>
                              setSubmitDescription(e.target.value)
                            }
                            rows={2}
                            maxLength={1000}
                            style={{
                              display: "block",
                              width: "100%",
                              marginTop: "0.25rem",
                            }}
                          />
                        </label>

                        <label>
                          Reference video URL (optional)
                          <input
                            placeholder="https://youtube.com/..."
                            value={submitVideoUrl}
                            onChange={(e) => setSubmitVideoUrl(e.target.value)}
                            style={{
                              display: "block",
                              width: "100%",
                              marginTop: "0.25rem",
                            }}
                          />
                        </label>

                        {/* REPLACE the entire muscles div with this */}
                        <div>
                          <strong>
                            Muscles (required — pick at least one)
                          </strong>

                          {/* Primary Muscles Section */}
                          <div style={{ marginTop: "0.75rem" }}>
                            <div
                              style={{
                                display: "flex",
                                alignItems: "center",
                                gap: "0.5rem",
                              }}
                            >
                              <span>🔴 Primary muscles</span>
                              <button
                                type="button"
                                onClick={() =>
                                  setShowPrimaryPicker(!showPrimaryPicker)
                                }
                              >
                                {showPrimaryPicker
                                  ? "Close"
                                  : "+ Add primary muscle"}
                              </button>
                            </div>

                            {/* Primary picker */}
                            {showPrimaryPicker && (
                              <div
                                style={{
                                  border: "1px solid #555",
                                  padding: "0.5rem",
                                  marginTop: "0.5rem",
                                }}
                              >
                                {MUSCLE_GROUPS.map((group) => {
                                  const groupMuscles = availableMuscles.filter(
                                    (m) =>
                                      m.muscleGroup === group &&
                                      !muscleAssignments.find(
                                        (a) => a.muscleId === m.id,
                                      ),
                                  );
                                  if (groupMuscles.length === 0) return null;
                                  return (
                                    <div
                                      key={group}
                                      style={{ marginBottom: "0.5rem" }}
                                    >
                                      <em style={{ fontSize: "0.85rem" }}>
                                        {group}
                                      </em>
                                      <div
                                        style={{
                                          display: "flex",
                                          flexWrap: "wrap",
                                          gap: "0.4rem",
                                          marginTop: "0.25rem",
                                        }}
                                      >
                                        {groupMuscles.map((m) => (
                                          <button
                                            key={m.id}
                                            type="button"
                                            onClick={() => {
                                              setMuscleAssignments((prev) => [
                                                ...prev,
                                                {
                                                  muscleId: m.id,
                                                  isPrimary: true,
                                                },
                                              ]);
                                            }}
                                            style={{
                                              fontSize: "0.8rem",
                                              padding: "0.2rem 0.5rem",
                                            }}
                                          >
                                            + {m.name}
                                          </button>
                                        ))}
                                      </div>
                                    </div>
                                  );
                                })}
                              </div>
                            )}

                            {/* Selected primary muscles */}
                            {muscleAssignments.filter((a) => a.isPrimary)
                              .length > 0 && (
                              <div
                                style={{
                                  display: "flex",
                                  flexWrap: "wrap",
                                  gap: "0.4rem",
                                  marginTop: "0.4rem",
                                }}
                              >
                                {muscleAssignments
                                  .filter((a) => a.isPrimary)
                                  .map((a) => {
                                    const muscle = availableMuscles.find(
                                      (m) => m.id === a.muscleId,
                                    );
                                    return (
                                      <span
                                        key={a.muscleId}
                                        style={{
                                          background: "#3a1a1a",
                                          border: "1px solid #c0392b",
                                          borderRadius: "4px",
                                          padding: "0.2rem 0.5rem",
                                          fontSize: "0.85rem",
                                          display: "flex",
                                          alignItems: "center",
                                          gap: "0.3rem",
                                        }}
                                      >
                                        {muscle?.name}
                                        <button
                                          type="button"
                                          onClick={() =>
                                            setMuscleAssignments((prev) =>
                                              prev.filter(
                                                (x) =>
                                                  x.muscleId !== a.muscleId,
                                              ),
                                            )
                                          }
                                          style={{
                                            background: "none",
                                            border: "none",
                                            cursor: "pointer",
                                            color: "#aaa",
                                            padding: 0,
                                          }}
                                        >
                                          ✕
                                        </button>
                                      </span>
                                    );
                                  })}
                              </div>
                            )}
                          </div>

                          {/* Secondary Muscles Section */}
                          <div style={{ marginTop: "0.75rem" }}>
                            <div
                              style={{
                                display: "flex",
                                alignItems: "center",
                                gap: "0.5rem",
                              }}
                            >
                              <span>⚪ Secondary muscles</span>
                              <button
                                type="button"
                                onClick={() =>
                                  setShowSecondaryPicker(!showSecondaryPicker)
                                }
                              >
                                {showSecondaryPicker
                                  ? "Close"
                                  : "+ Add secondary muscle"}
                              </button>
                            </div>

                            {/* Secondary picker */}
                            {showSecondaryPicker && (
                              <div
                                style={{
                                  border: "1px solid #555",
                                  padding: "0.5rem",
                                  marginTop: "0.5rem",
                                }}
                              >
                                {MUSCLE_GROUPS.map((group) => {
                                  const groupMuscles = availableMuscles.filter(
                                    (m) =>
                                      m.muscleGroup === group &&
                                      !muscleAssignments.find(
                                        (a) => a.muscleId === m.id,
                                      ),
                                  );
                                  if (groupMuscles.length === 0) return null;
                                  return (
                                    <div
                                      key={group}
                                      style={{ marginBottom: "0.5rem" }}
                                    >
                                      <em style={{ fontSize: "0.85rem" }}>
                                        {group}
                                      </em>
                                      <div
                                        style={{
                                          display: "flex",
                                          flexWrap: "wrap",
                                          gap: "0.4rem",
                                          marginTop: "0.25rem",
                                        }}
                                      >
                                        {groupMuscles.map((m) => (
                                          <button
                                            key={m.id}
                                            type="button"
                                            onClick={() => {
                                              setMuscleAssignments((prev) => [
                                                ...prev,
                                                {
                                                  muscleId: m.id,
                                                  isPrimary: false,
                                                },
                                              ]);
                                            }}
                                            style={{
                                              fontSize: "0.8rem",
                                              padding: "0.2rem 0.5rem",
                                            }}
                                          >
                                            + {m.name}
                                          </button>
                                        ))}
                                      </div>
                                    </div>
                                  );
                                })}
                              </div>
                            )}

                            {/* Selected secondary muscles */}
                            {muscleAssignments.filter((a) => !a.isPrimary)
                              .length > 0 && (
                              <div
                                style={{
                                  display: "flex",
                                  flexWrap: "wrap",
                                  gap: "0.4rem",
                                  marginTop: "0.4rem",
                                }}
                              >
                                {muscleAssignments
                                  .filter((a) => !a.isPrimary)
                                  .map((a) => {
                                    const muscle = availableMuscles.find(
                                      (m) => m.id === a.muscleId,
                                    );
                                    return (
                                      <span
                                        key={a.muscleId}
                                        style={{
                                          background: "#1a1a2e",
                                          border: "1px solid #555",
                                          borderRadius: "4px",
                                          padding: "0.2rem 0.5rem",
                                          fontSize: "0.85rem",
                                          display: "flex",
                                          alignItems: "center",
                                          gap: "0.3rem",
                                        }}
                                      >
                                        {muscle?.name}
                                        <button
                                          type="button"
                                          onClick={() =>
                                            setMuscleAssignments((prev) =>
                                              prev.filter(
                                                (x) =>
                                                  x.muscleId !== a.muscleId,
                                              ),
                                            )
                                          }
                                          style={{
                                            background: "none",
                                            border: "none",
                                            cursor: "pointer",
                                            color: "#aaa",
                                            padding: 0,
                                          }}
                                        >
                                          ✕
                                        </button>
                                      </span>
                                    );
                                  })}
                              </div>
                            )}
                          </div>
                        </div>

                        {/* New muscle sub-form */}
                        {!showNewMuscleForm ? (
                          <button
                            type="button"
                            onClick={() => setShowNewMuscleForm(true)}
                            style={{
                              alignSelf: "flex-start",
                              fontSize: "0.85rem",
                            }}
                          >
                            My muscle isn't listed — request a new muscle
                          </button>
                        ) : (
                          <div
                            style={{
                              border: "1px dashed #555",
                              padding: "0.75rem",
                              display: "flex",
                              flexDirection: "column",
                              gap: "0.5rem",
                            }}
                          >
                            <strong style={{ fontSize: "0.9rem" }}>
                              Request a new muscle
                            </strong>
                            <label>
                              Muscle name
                              <input
                                placeholder="e.g. Long Head Bicep"
                                value={newMuscleName}
                                onChange={(e) =>
                                  setNewMuscleName(e.target.value)
                                }
                                style={{
                                  display: "block",
                                  width: "100%",
                                  marginTop: "0.25rem",
                                }}
                              />
                            </label>
                            <label>
                              Muscle group
                              <select
                                value={newMuscleGroup}
                                onChange={(e) =>
                                  setNewMuscleGroup(e.target.value)
                                }
                                style={{
                                  display: "block",
                                  width: "100%",
                                  marginTop: "0.25rem",
                                }}
                              >
                                <option value="">— Select group —</option>
                                {MUSCLE_GROUPS.map((g) => (
                                  <option key={g} value={g}>
                                    {g}
                                  </option>
                                ))}
                              </select>
                            </label>
                            <button
                              type="button"
                              onClick={() => {
                                setShowNewMuscleForm(false);
                                setNewMuscleName("");
                                setNewMuscleGroup("");
                              }}
                              style={{
                                alignSelf: "flex-start",
                                fontSize: "0.8rem",
                              }}
                            >
                              Cancel muscle request
                            </button>
                          </div>
                        )}

                        <div style={{ display: "flex", gap: "0.5rem" }}>
                          <button
                            type="button"
                            onClick={() => handleSubmitNewExercise(day.id)}
                            disabled={submitting}
                          >
                            {submitting ? "Submitting..." : "Submit Exercise"}
                          </button>
                          <button type="button" onClick={resetSubmitForm}>
                            Cancel
                          </button>
                        </div>
                      </div>
                    )}
                  </div>
                )}

                <label htmlFor={`sets-${day.id}`}>
                  Sets
                  <input
                    id={`sets-${day.id}`}
                    type="number"
                    min={1}
                    value={sets}
                    onChange={(e) => setSets(Number(e.target.value))}
                    required
                    style={{ display: "block", marginTop: "0.25rem" }}
                  />
                </label>

                <label htmlFor={`reps-${day.id}`}>
                  Reps
                  <input
                    id={`reps-${day.id}`}
                    type="number"
                    min={1}
                    value={reps}
                    onChange={(e) => setReps(Number(e.target.value))}
                    required
                    style={{ display: "block", marginTop: "0.25rem" }}
                  />
                </label>

                <label htmlFor={`notes-${day.id}`}>
                  Notes
                  <input
                    id={`notes-${day.id}`}
                    placeholder="Optional notes"
                    value={notes}
                    onChange={(e) => setNotes(e.target.value)}
                    style={{
                      display: "block",
                      width: "100%",
                      marginTop: "0.25rem",
                    }}
                  />
                </label>

                <label htmlFor={`video-url-${day.id}`}>
                  Reference video URL
                  <input
                    id={`video-url-${day.id}`}
                    placeholder="https://youtube.com/watch?v=... (optional)"
                    value={videoUrl}
                    onChange={(e) => setVideoUrl(e.target.value)}
                    style={{
                      display: "block",
                      width: "100%",
                      marginTop: "0.25rem",
                    }}
                  />
                </label>

                <div style={{ display: "flex", gap: "0.5rem" }}>
                  <button type="submit">Add Exercise</button>
                  <button
                    type="button"
                    onClick={() => {
                      setActiveDayId(null);
                      resetExerciseForm();
                    }}
                  >
                    Cancel
                  </button>
                </div>
              </form>
            ) : (
              <button onClick={() => setActiveDayId(day.id)}>
                + Add Exercise
              </button>
            )}
          </li>
        ))}
      </ul>
    </div>
  );
}
