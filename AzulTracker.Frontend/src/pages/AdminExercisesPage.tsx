import { useEffect, useState } from 'react';
import { getPendingExercises, approveExercise } from '../services/adminService';
import type { PendingExercise } from '../services/adminService';

export default function AdminExercisesPage() {
  const [exercises, setExercises] = useState<PendingExercise[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');

  useEffect(() => {
    getPendingExercises()
      .then(setExercises)
      .catch(() => setError('Failed to load pending exercises.'))
      .finally(() => setLoading(false));
  }, []);

  const handleApprove = async (exercise: PendingExercise) => {
    try {
      await approveExercise(exercise.id);
      setExercises(prev => prev.filter(e => e.id !== exercise.id));
    } catch {
      alert('Failed to approve exercise.');
    }
  };

  if (loading) return <p>Loading pending exercises...</p>;
  if (error) return <p style={{ color: 'red' }}>{error}</p>;

  return (
    <div style={{ padding: '2rem' }}>
      <h1>Pending Exercises</h1>
      <p style={{ color: '#666', marginBottom: '1.5rem' }}>
        User-submitted exercises waiting for approval.
      </p>

      {exercises.length === 0 ? (
        <p style={{ color: '#666' }}>No pending exercises — you're all caught up.</p>
      ) : (
        <table style={{ width: '100%', borderCollapse: 'collapse' }}>
          <thead>
            <tr style={{ textAlign: 'left', borderBottom: '2px solid #ddd' }}>
              <th style={{ padding: '0.5rem 1rem' }}>Name</th>
              <th style={{ padding: '0.5rem 1rem' }}>Category</th>
              <th style={{ padding: '0.5rem 1rem' }}>Submitted By</th>
              <th style={{ padding: '0.5rem 1rem' }}>Date</th>
              <th style={{ padding: '0.5rem 1rem' }}>Action</th>
            </tr>
          </thead>
          <tbody>
            {exercises.map(ex => (
              <tr key={ex.id} style={{ borderBottom: '1px solid #eee' }}>
                <td style={{ padding: '0.5rem 1rem' }}>{ex.name}</td>
                <td style={{ padding: '0.5rem 1rem' }}>{ex.category}</td>
                <td style={{ padding: '0.5rem 1rem' }}>
                  {ex.submittedByUsername ?? 'Unknown'}
                </td>
                <td style={{ padding: '0.5rem 1rem' }}>
                  {new Date(ex.createdAt).toLocaleDateString()}
                </td>
                <td style={{ padding: '0.5rem 1rem' }}>
                  <button onClick={() => handleApprove(ex)}>Approve</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}