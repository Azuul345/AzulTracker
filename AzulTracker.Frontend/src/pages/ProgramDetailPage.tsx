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
  searchExercises
} from "../services/programService";
import type {
  TrainingProgram,
  ProgramDay,
  ProgramExercise,
  ExerciseSearchResult
} from "../types/program";

export default function ProgramDetailPage() {
  const { id } = useParams<{ id: string }>();
  const programId = Number(id);

  const [program, setProgram] = useState<TrainingProgram | null>(null);
  const [days, setDays] = useState<ProgramDay[]>([]);
  const [exercisesByDay, setExercisesByDay] = useState<Record<number, ProgramExercise[]>>({});
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const [showDayForm, setShowDayForm] = useState(false);
  const [dayName, setDayName] = useState("");

  const [activeDayId, setActiveDayId] = useState<number | null>(null);
  const [sets, setSets] = useState(3);
  const [reps, setReps] = useState(8);
  const [notes, setNotes] = useState("");
  const [searchQuery, setSearchQuery] = useState("");
  const [searchResults, setSearchResults] = useState<ExerciseSearchResult[]>([]);
  const [selectedExercise, setSelectedExercise] = useState<ExerciseSearchResult | null>(null);
  const [customName, setCustomName] = useState("");

  const loadProgram = useCallback(async () => {
    try {
      setError(null);
      setLoading(true);

      const res = await getPrograms();
      const found = res.data.find(p => p.id === programId);

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
        notes: notes || undefined
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

  function resetExerciseForm() {
    setSets(3);
    setReps(8);
    setNotes("");
    setSearchQuery("");
    setSearchResults([]);
    setSelectedExercise(null);
    setCustomName("");
  }

  if (loading) return <p>Loading...</p>;
  if (error) return <p style={{ color: "red" }}>{error}</p>;
  if (!program) return null;

  return (
    <div>
      <h1>{program.name}</h1>
      {program.description && <p>{program.description}</p>}

      <button onClick={() => setShowDayForm(!showDayForm)}>
        {showDayForm ? "Cancel" : "Add Day"}
      </button>

      {showDayForm && (
        <form onSubmit={handleAddDay}>
          <input
            placeholder="Day name (e.g. Push Day)"
            value={dayName}
            onChange={e => setDayName(e.target.value)}
            required
          />
          <button type="submit">Add</button>
        </form>
      )}

      {days.map(day => (
        <div
          key={day.id}
          style={{ marginTop: "1rem", border: "1px solid #444", padding: "1rem" }}
        >
          <h2>{day.name}</h2>
          <button onClick={() => handleDeleteDay(day.id)}>Delete Day</button>

          <ul>
            {(exercisesByDay[day.id] ?? []).map(ex => (
              <li key={ex.id}>
                {ex.customExerciseName ?? ex.exerciseName ?? `Exercise #${ex.exerciseLibraryId}`} — {ex.sets}×{ex.reps}
                {ex.notes && <span> ({ex.notes})</span>}
                <button onClick={() => handleDeleteExercise(day.id, ex.id)}>Remove</button>
              </li>
            ))}
          </ul>

          {activeDayId === day.id ? (
            <form
              onSubmit={e => handleAddExercise(e, day.id)}
              style={{
                marginTop: "1rem",
                display: "flex",
                flexDirection: "column",
                gap: "0.75rem",
                maxWidth: "500px"
              }}
            >
              <p style={{ margin: 0, color: "#aaa" }}>
                Search the exercise library or enter a custom exercise name.
              </p>

              <div>
                <label htmlFor={`exercise-search-${day.id}`}>Exercise</label>
                <input
                  id={`exercise-search-${day.id}`}
                  placeholder="Search exercise library..."
                  value={searchQuery}
                  onChange={e => handleSearch(e.target.value)}
                  style={{ display: "block", width: "100%", marginTop: "0.25rem" }}
                />

                {searchResults.length > 0 && (
                  <ul style={{ marginTop: "0.5rem" }}>
                    {searchResults.map(r => (
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
              </div>

              {!selectedExercise && (
                <div>
                  <label htmlFor={`custom-exercise-${day.id}`}>Custom exercise name</label>
                  <input
                    id={`custom-exercise-${day.id}`}
                    placeholder="Type your own exercise name"
                    value={customName}
                    onChange={e => setCustomName(e.target.value)}
                    style={{ display: "block", width: "100%", marginTop: "0.25rem" }}
                  />
                </div>
              )}

              <div>
                <label htmlFor={`sets-${day.id}`}>Sets</label>
                <input
                  id={`sets-${day.id}`}
                  type="number"
                  min={1}
                  value={sets}
                  onChange={e => setSets(Number(e.target.value))}
                  required
                  style={{ display: "block", marginTop: "0.25rem" }}
                />
              </div>

              <div>
                <label htmlFor={`reps-${day.id}`}>Reps</label>
                <input
                  id={`reps-${day.id}`}
                  type="number"
                  min={1}
                  value={reps}
                  onChange={e => setReps(Number(e.target.value))}
                  required
                  style={{ display: "block", marginTop: "0.25rem" }}
                />
              </div>

              <div>
                <label htmlFor={`notes-${day.id}`}>Notes</label>
                <input
                  id={`notes-${day.id}`}
                  placeholder="Optional notes"
                  value={notes}
                  onChange={e => setNotes(e.target.value)}
                  style={{ display: "block", width: "100%", marginTop: "0.25rem" }}
                />
              </div>

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
            <button onClick={() => setActiveDayId(day.id)}>+ Add Exercise</button>
          )}
        </div>
      ))}
    </div>
  );
}