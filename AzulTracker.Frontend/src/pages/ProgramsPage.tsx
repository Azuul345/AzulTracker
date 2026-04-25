import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { getPrograms, createProgram, deleteProgram, activateProgram } from "../services/programService";
import type { TrainingProgram } from "../types/program";

export default function ProgramsPage() {
  const [programs, setPrograms] = useState<TrainingProgram[]>([]);
  const [error, setError] = useState<string | null>(null);
  const [showForm, setShowForm] = useState(false);
  const [name, setName] = useState("");
  const [description, setDescription] = useState("");
  const [daysPerWeek, setDaysPerWeek] = useState(3);
  const navigate = useNavigate();

  useEffect(() => {
    loadPrograms();
  }, []);

  async function loadPrograms() {
    try {
      const res = await getPrograms();
      setPrograms(res.data);
    } catch {
      setError("Failed to load programs.");
    }
  }

  async function handleCreate(e: React.FormEvent) {
    e.preventDefault();
    try {
      await createProgram({ name, description: description || undefined, daysPerWeek });
      setName("");
      setDescription("");
      setDaysPerWeek(3);
      setShowForm(false);
      await loadPrograms();
    } catch {
      setError("Failed to create program. You may already have 3 programs.");
    }
  }

  async function handleDelete(id: number) {
    try {
      await deleteProgram(id);
      await loadPrograms();
    } catch {
      setError("Failed to delete program.");
    }
  }

  async function handleActivate(id: number) {
    try {
      await activateProgram(id);
      await loadPrograms();
    } catch {
      setError("Failed to activate program.");
    }
  }

  return (
    <div>
      <h1>My Programs</h1>

      {error && <p style={{ color: "red" }}>{error}</p>}

      <button onClick={() => setShowForm(!showForm)}>
        {showForm ? "Cancel" : "New Program"}
      </button>

      {showForm && (
        <form onSubmit={handleCreate}>
          <div>
            <label>Name</label>
            <input value={name} onChange={e => setName(e.target.value)} required />
          </div>
          <div>
            <label>Description (optional)</label>
            <input value={description} onChange={e => setDescription(e.target.value)} />
          </div>
          <div>
            <label>Days per week</label>
            <input
              type="number"
              min={1}
              max={7}
              value={daysPerWeek}
              onChange={e => setDaysPerWeek(Number(e.target.value))}
              required
            />
          </div>
          <button type="submit">Create</button>
        </form>
      )}

      {programs.length === 0 && !showForm && <p>No programs yet. Create one to get started.</p>}

      <ul>
        {programs.map(program => (
          <li key={program.id}>
            <strong>{program.name}</strong>
            {program.isActive && <span> ✅ Active</span>}
            <p>{program.description}</p>
            <button onClick={() => navigate(`/programs/${program.id}`)}>Open</button>
            {!program.isActive && (
              <button onClick={() => handleActivate(program.id)}>Set Active</button>
            )}
            <button onClick={() => handleDelete(program.id)}>Delete</button>
          </li>
        ))}
      </ul>
    </div>
  );
}