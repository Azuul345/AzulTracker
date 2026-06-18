import { useCallback, useEffect, useState } from 'react';
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

  const loadPrograms = useCallback(async () => {
    try {
      setError('');
      const res = await getPrograms();
      setPrograms(res.data);
    } catch {
      setError('Failed to load programs.');
    } finally {
      setLoading(false);
    }
  }, []);

  useEffect(() => {
    loadPrograms();
  }, [loadPrograms]);

  async function handleCreate(e: React.FormEvent) {
    e.preventDefault();

    try {
      setError('');
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
      setError('');
      await deleteProgram(id);
      await loadPrograms();
    } catch {
      setError('Failed to delete program.');
    }
  }

  async function handleActivate(id: number) {
    try {
      setError('');
      await activateProgram(id);
      await loadPrograms();
    } catch {
      setError('Failed to activate program.');
    }
  }

  if (loading) return <p>Loading...</p>;

  return (
    <div
      className="page-shell programs-page"
      style={{ padding: '2rem' }}
    >
      <div className="page-header">
        <h1>My Programs</h1>
        <p style={{ color: '#666', marginTop: '0.5rem' }}>
          Create a training program, then edit it to add days and exercises.
        </p>
      </div>

      {error && (
        <p className="form-error" style={{ color: 'red', marginTop: '1rem' }}>
          {error}
        </p>
      )}

      <button
        className="action-button"
        onClick={() => setShowForm(!showForm)}
        style={{ marginTop: '1rem' }}
      >
        {showForm ? 'Cancel' : '+ New Program'}
      </button>

      {showForm && (
        <form
          className="form-card create-program-form"
          onSubmit={handleCreate}
          style={{
            marginTop: '1rem',
            display: 'flex',
            flexDirection: 'column',
            gap: '0.75rem',
            maxWidth: 400
          }}
        >
          <div className="form-field">
            <label htmlFor="program-name">Program name</label>
            <input
              id="program-name"
              placeholder="Push / Pull / Legs"
              value={name}
              onChange={e => setName(e.target.value)}
              required
            />
          </div>

          <div className="form-field">
            <label htmlFor="program-description">Description</label>
            <input
              id="program-description"
              placeholder="Optional notes about this program"
              value={description}
              onChange={e => setDescription(e.target.value)}
            />
          </div>

          <div className="form-field">
            <label htmlFor="days-per-week">Days per week</label>
            <input
              id="days-per-week"
              type="number"
              min={1}
              max={7}
              value={daysPerWeek}
              onChange={e => setDaysPerWeek(Number(e.target.value))}
              required
            />
            <small style={{ color: '#666' }}>
              How many workout days this program is built for each week.
            </small>
          </div>

          <button type="submit">Create Program</button>
        </form>
      )}

      {programs.length === 0 ? (
        <p style={{ color: '#666', marginTop: '2rem' }}>
          No programs yet. Create your first one.
        </p>
      ) : (
        <div
          className="program-list"
          style={{
            marginTop: '2rem',
            display: 'flex',
            flexDirection: 'column',
            gap: '1rem'
          }}
        >
          {programs.map(program => (
            <div
              key={program.id}
              className="program-card"
              style={{
                border: '1px solid #ddd',
                borderRadius: 8,
                padding: '1rem'
              }}
            >
              <div
                className="program-card__content"
                style={{
                  display: 'flex',
                  justifyContent: 'space-between',
                  alignItems: 'center',
                  gap: '1rem'
                }}
              >
                <div className="program-card__info">
                  <h2 style={{ margin: 0 }}>
                    <Link
                      to={`/programs/${program.id}`}
                      className="program-card__title-link"
                      style={{ textDecoration: 'none', color: 'inherit' }}
                    >
                      {program.name}
                    </Link>
                    {program.isActive && (
                      <span
                        className="program-status program-status--active"
                        style={{
                          marginLeft: '0.5rem',
                          fontSize: '0.75rem',
                          color: 'green'
                        }}
                      >
                        ● Active
                      </span>
                    )}
                  </h2>

                  {program.description && (
                    <p style={{ color: '#666', margin: '0.25rem 0 0' }}>
                      {program.description}
                    </p>
                  )}

                  <p style={{ color: '#999', fontSize: '0.875rem', margin: '0.25rem 0 0' }}>
                    {program.daysPerWeek} days per week
                  </p>
                </div>

                <div
                  className="program-card__actions"
                  style={{ display: 'flex', gap: '0.5rem' }}
                >
                  {!program.isActive && (
                    <button onClick={() => handleActivate(program.id)}>
                      Set Active
                    </button>
                  )}

                  <Link to={`/programs/${program.id}`}>
                    <button>Edit Program</button>
                  </Link>

                  <button
                    onClick={() => handleDelete(program.id)}
                    style={{ color: 'red' }}
                  >
                    Delete
                  </button>
                </div>
              </div>
            </div>
          ))}
        </div>
      )}
    </div>
  );
}