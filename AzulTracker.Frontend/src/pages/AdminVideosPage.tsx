import { useEffect, useState } from 'react';
import { getPendingVideos, blockVideo } from '../services/adminService';
import type { AdminVideoUrl } from '../services/adminService';

export default function AdminVideosPage() {
  const [videos, setVideos] = useState<AdminVideoUrl[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');

  useEffect(() => {
    getPendingVideos()
      .then(setVideos)
      .catch(() => setError('Failed to load pending videos.'))
      .finally(() => setLoading(false));
  }, []);

  const handleBlock = async (video: AdminVideoUrl) => {
    try {
      await blockVideo(video.id);
      setVideos(prev => prev.filter(v => v.id !== video.id));
    } catch {
      alert('Failed to block video.');
    }
  };

  if (loading) return <p>Loading pending videos...</p>;
  if (error) return <p style={{ color: 'red' }}>{error}</p>;

  return (
    <div style={{ padding: '2rem' }}>
      <h1>Pending Videos</h1>
      <p style={{ color: '#666', marginBottom: '1.5rem' }}>
        User-submitted video URLs waiting for review.
      </p>

      {videos.length === 0 ? (
        <p style={{ color: '#666' }}>No pending videos — you're all caught up.</p>
      ) : (
        <table style={{ width: '100%', borderCollapse: 'collapse' }}>
          <thead>
            <tr style={{ textAlign: 'left', borderBottom: '2px solid #ddd' }}>
              <th style={{ padding: '0.5rem 1rem' }}>URL</th>
              <th style={{ padding: '0.5rem 1rem' }}>Submitted By</th>
              <th style={{ padding: '0.5rem 1rem' }}>Date</th>
              <th style={{ padding: '0.5rem 1rem' }}>Action</th>
            </tr>
          </thead>
          <tbody>
            {videos.map(video => (
              <tr key={video.id} style={{ borderBottom: '1px solid #eee' }}>
                <td style={{ padding: '0.5rem 1rem' }}>
                  <a href={video.url} target="_blank" rel="noopener noreferrer">
                    {video.url.length > 60 ? video.url.slice(0, 60) + '...' : video.url}
                  </a>
                </td>
                <td style={{ padding: '0.5rem 1rem' }}>
                  {video.submittedByUsername ?? 'Unknown'}
                </td>
                <td style={{ padding: '0.5rem 1rem' }}>
                  {new Date(video.createdAt).toLocaleDateString()}
                </td>
                <td style={{ padding: '0.5rem 1rem' }}>
                  <button
                    onClick={() => handleBlock(video)}
                    style={{ color: 'red' }}
                  >
                    Block
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}