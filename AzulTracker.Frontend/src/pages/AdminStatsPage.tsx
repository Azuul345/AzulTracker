import { useEffect, useState } from 'react';
import { getStats } from '../services/adminService';
import type { AdminStats } from '../services/adminService';

export default function AdminStatsPage() {
  const [stats, setStats] = useState<AdminStats | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');

  useEffect(() => {
    getStats()
      .then(setStats)
      .catch(() => setError('Failed to load stats.'))
      .finally(() => setLoading(false));
  }, []);

  if (loading) return <p>Loading stats...</p>;
  if (error) return <p style={{ color: 'red' }}>{error}</p>;
  if (!stats) return null;

  return (
    <div style={{ padding: '2rem' }}>
      <h1>Platform Stats</h1>

      <div style={{ display: 'flex', gap: '2rem', marginTop: '1.5rem', flexWrap: 'wrap' }}>
        <div style={{ padding: '1.5rem', border: '1px solid #ddd', borderRadius: 8, minWidth: 160 }}>
          <div style={{ fontSize: '2rem', fontWeight: 'bold' }}>{stats.totalUsers}</div>
          <div style={{ color: '#666', marginTop: '0.25rem' }}>Total Users</div>
        </div>
        <div style={{ padding: '1.5rem', border: '1px solid #ddd', borderRadius: 8, minWidth: 160 }}>
          <div style={{ fontSize: '2rem', fontWeight: 'bold' }}>{stats.totalLogs}</div>
          <div style={{ color: '#666', marginTop: '0.25rem' }}>Total Logs</div>
        </div>
      </div>

      <div style={{ marginTop: '2.5rem' }}>
        <h2>Top Exercises</h2>
        {stats.popularExercises.length === 0 ? (
          <p style={{ color: '#666', marginTop: '0.5rem' }}>No workout data yet.</p>
        ) : (
          <table style={{ width: '100%', borderCollapse: 'collapse', marginTop: '1rem' }}>
            <thead>
              <tr style={{ textAlign: 'left', borderBottom: '2px solid #ddd' }}>
                <th style={{ padding: '0.5rem 1rem' }}>#</th>
                <th style={{ padding: '0.5rem 1rem' }}>Exercise</th>
                <th style={{ padding: '0.5rem 1rem' }}>Times Logged</th>
              </tr>
            </thead>
            <tbody>
              {stats.popularExercises.map((ex, index) => (
                <tr key={ex.exerciseName} style={{ borderBottom: '1px solid #eee' }}>
                  <td style={{ padding: '0.5rem 1rem', color: '#666' }}>{index + 1}</td>
                  <td style={{ padding: '0.5rem 1rem' }}>{ex.exerciseName}</td>
                  <td style={{ padding: '0.5rem 1rem' }}>{ex.count}</td>
                </tr>
              ))}
            </tbody>
          </table>
        )}
      </div>
    </div>
  );
}