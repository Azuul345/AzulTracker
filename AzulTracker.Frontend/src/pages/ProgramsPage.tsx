import { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import {
  getPrograms,
  createProgram,
  deleteProgram,
  activateProgram
} from '../services/programService';
import type { TrainingProgram } from '../types/program';

export default function ProgramsPage() {
  const [programs, setPrograms] = useState<TrainingProgram[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');

  const [showForm, setShowForm] = useState(false);
  const [name, setName] = useState('');
  const [description, setDescription] = useState('');
  const [daysPerWeek, setDaysPerWeek] = useState(3);

  useEffect(() => {
    loadPrograms();
  }, []);

  async function loadPrograms() {
    try {
      const res = await getPrograms();
      setPrograms(res.data);
    } catch {
      setError('Failed to load programs.');
    } finally {
      setLoading(false);
    }
  }

  async function handleCreate(e: React.FormEvent) {
    e.preventDefault();
    try {
      await createProgram({ name, description, daysPerWeek });
      setName('');
      setDescription('');
      setDaysPerWeek(3);
      setShowForm(false);
      await loadPrograms();
    } catch {
      setError('Failed to create program.');
    }
  }

  async function handleDelete(id: number) {
    try {
      await deleteProgram(id);
      await loadPrograms();
    } catch {
      setError('Failed to delete program.');
    }
  }

  async function handleActivate(id: number) {
    try {
      await activateProgram(id);
      await loadPrograms();
    } catch {
      setError('Failed to activate program.');
    }
  }

  if (loading) return <p>Loading...</p>;
  if (error) return <p style={{ color: 'red' }}>{error}</p>;

  return (
    <div style={{ padding: '2rem' }}>
      <h1>My Programs</h1>

      <button
        onClick={() => setShowForm(!showForm)}
        style={{ marginTop: '1rem' }}
      >
        {showForm ? 'Cancel' : '+ New Program'}
      </button>

      {showForm && (
        <form onSubmit={handleCreate} style={{ marginTop: '1rem', display: 'flex', flexDirection: 'column', gap: '0.5rem', maxWidth: 400 }}>
          <input
            placeholder="Program name"
            value={name}
            onChange={e => setName(e.target.value)}
            required
          />
          <input
            placeholder="Description (optional)"
            value={description}
            onChange={e => setDescription(e.target.value)}
          />
          <input
            type="number"
            min={1}
            max={7}
            placeholder="Days per week"
            value={daysPerWeek}
            onChange={e => setDaysPerWeek(Number(e.target.value))}
            required
          />
          <button type="submit">Create</button>
        </form>
      )}

      {programs.length === 0 ? (
        <p style={{ color: '#666', marginTop: '2rem' }}>No programs yet. Create your first one!</p>
      ) : (
        <div style={{ marginTop: '2rem', display: 'flex', flexDirection: 'column', gap: '1rem' }}>
          {programs.map(program => (
            <div key={program.id} style={{ border: '1px solid #ddd', borderRadius: 8, padding: '1rem' }}>
              <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                <div>
                  <h2 style={{ margin: 0 }}>
                    <Link to={`/programs/${program.id}`} style={{ textDecoration: 'none', color: 'inherit' }}>
                      {program.name}
                    </Link>
                    {program.isActive && (
                      <span style={{ marginLeft: '0.5rem', fontSize: '0.75rem', color: 'green' }}>● Active</span>
                    )}
                  </h2>
                  {program.description && <p style={{ color: '#666', margin: '0.25rem 0 0' }}>{program.description}</p>}
                  <p style={{ color: '#999', fontSize: '0.875rem', margin: '0.25rem 0 0' }}>{program.daysPerWeek} days/week</p>
                </div>
                <div style={{ display: 'flex', gap: '0.5rem' }}>
                  {!program.isActive && (
                    <button onClick={() => handleActivate(program.id)}>Set Active</button>
                  )}
                  <Link to={`/programs/${program.id}`}>
                    <button>Edit</button>
                  </Link>
                  <button onClick={() => handleDelete(program.id)} style={{ color: 'red' }}>Delete</button>
                </div>
              </div>
            </div>
          ))}
        </div>
      )}
    </div>
  );
}