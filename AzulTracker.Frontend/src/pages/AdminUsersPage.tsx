import { useEffect, useState } from 'react';
import { getUsers, setUserStatus, setUserRole } from '../services/adminService';
import type { AdminUser } from '../services/adminService';

export default function AdminUsersPage() {
  const [users, setUsers] = useState<AdminUser[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');

  useEffect(() => {
    getUsers()
      .then(setUsers)
      .catch(() => setError('Failed to load users.'))
      .finally(() => setLoading(false));
  }, []);

  const handleToggleStatus = async (user: AdminUser) => {
    try {
      await setUserStatus(user.id, !user.isActive);
      setUsers(prev =>
        prev.map(u => u.id === user.id ? { ...u, isActive: !u.isActive } : u)
      );
    } catch {
      alert('Failed to update user status.');
    }
  };

  const handleToggleRole = async (user: AdminUser) => {
    const newRole = user.role === 'Admin' ? 'User' : 'Admin';
    try {
      await setUserRole(user.id, newRole);
      setUsers(prev =>
        prev.map(u => u.id === user.id ? { ...u, role: newRole } : u)
      );
    } catch {
      alert('Failed to update user role.');
    }
  };

  if (loading) return <p>Loading users...</p>;
  if (error) return <p style={{ color: 'red' }}>{error}</p>;

  return (
    <div style={{ padding: '2rem' }}>
      <h1>Users</h1>
      <p style={{ color: '#666', marginBottom: '1.5rem' }}>{users.length} registered users</p>

      <table style={{ width: '100%', borderCollapse: 'collapse' }}>
        <thead>
          <tr style={{ textAlign: 'left', borderBottom: '2px solid #ddd' }}>
            <th style={{ padding: '0.5rem 1rem' }}>Username</th>
            <th style={{ padding: '0.5rem 1rem' }}>Email</th>
            <th style={{ padding: '0.5rem 1rem' }}>Role</th>
            <th style={{ padding: '0.5rem 1rem' }}>Status</th>
            <th style={{ padding: '0.5rem 1rem' }}>Joined</th>
            <th style={{ padding: '0.5rem 1rem' }}>Actions</th>
          </tr>
        </thead>
        <tbody>
          {users.map(user => (
            <tr key={user.id} style={{ borderBottom: '1px solid #eee' }}>
              <td style={{ padding: '0.5rem 1rem' }}>{user.username}</td>
              <td style={{ padding: '0.5rem 1rem' }}>{user.email}</td>
              <td style={{ padding: '0.5rem 1rem' }}>{user.role}</td>
              <td style={{ padding: '0.5rem 1rem' }}>
                <span style={{ color: user.isActive ? 'green' : 'red' }}>
                  {user.isActive ? 'Active' : 'Disabled'}
                </span>
              </td>
              <td style={{ padding: '0.5rem 1rem' }}>
                {new Date(user.createdAt).toLocaleDateString()}
              </td>
              <td style={{ padding: '0.5rem 1rem', display: 'flex', gap: '0.5rem' }}>
                <button onClick={() => handleToggleStatus(user)}>
                  {user.isActive ? 'Disable' : 'Enable'}
                </button>
                <button onClick={() => handleToggleRole(user)}>
                  {user.role === 'Admin' ? 'Demote' : 'Promote'}
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}