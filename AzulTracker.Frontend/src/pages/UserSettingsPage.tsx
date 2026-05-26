import { useState } from 'react';
import { useAuth } from '../context/AuthContext';
import { updateSettings } from '../services/userService';
import api from '../services/api';

export default function UserSettingsPage() {
  const { user, updateSettings: updateContextSettings } = useAuth();

  const [workoutView, setWorkoutView] = useState<'FullDay' | 'Guided'>(
    user?.preferredWorkoutView ?? 'FullDay'
  );
  const [restTimer, setRestTimer] = useState<boolean>(
    user?.restTimerEnabled ?? false
  );
  const [saving, setSaving] = useState(false);
  const [saved, setSaved] = useState(false);
  const [error, setError] = useState('');

  // --- Change password state ---
  const [currentPassword, setCurrentPassword] = useState('');
  const [newPassword, setNewPassword] = useState('');
  const [confirmNewPassword, setConfirmNewPassword] = useState('');
  const [passwordSaving, setPasswordSaving] = useState(false);
  const [passwordSaved, setPasswordSaved] = useState(false);
  const [passwordError, setPasswordError] = useState('');

  const handleSave = async () => {
    setSaving(true);
    setError('');
    setSaved(false);
    try {
      await updateSettings({ preferredWorkoutView: workoutView, restTimerEnabled: restTimer });
      updateContextSettings(workoutView, restTimer);
      setSaved(true);
    } catch {
      setError('Failed to save settings. Please try again.');
    } finally {
      setSaving(false);
    }
  };

  const handleChangePassword = async () => {
    setPasswordError('');
    setPasswordSaved(false);

    // Client-side validation before hitting the API
    if (!currentPassword || !newPassword || !confirmNewPassword) {
      setPasswordError('All password fields are required.');
      return;
    }
    if (newPassword !== confirmNewPassword) {
      setPasswordError('New passwords do not match.');
      return;
    }
    if (newPassword.length < 6) {
      setPasswordError('New password must be at least 6 characters.');
      return;
    }

    setPasswordSaving(true);
    try {
      await api.post('/auth/change-password', {
        currentPassword,
        newPassword,
        confirmNewPassword,
      });
      setPasswordSaved(true);
      // Clear the fields on success
      setCurrentPassword('');
      setNewPassword('');
      setConfirmNewPassword('');
    } catch (err: unknown) {
      const message =
        (err as { response?: { data?: { message?: string } } })?.response?.data?.message;
      setPasswordError(message ?? 'Failed to change password. Please try again.');
    } finally {
      setPasswordSaving(false);
    }
  };

  return (
    <div style={{ maxWidth: 480, margin: '2rem auto', padding: '0 1rem' }}>
      <h1>Settings</h1>

      {/* --- Workout View --- */}
      <div style={{ marginTop: '2rem' }}>
        <h2>Workout View</h2>
        <p style={{ color: '#666', marginBottom: '0.75rem' }}>
          Choose how your workout is displayed during a session.
        </p>
        <label style={{ display: 'flex', alignItems: 'center', gap: '0.75rem', cursor: 'pointer' }}>
          <input
            type="radio"
            value="FullDay"
            checked={workoutView === 'FullDay'}
            onChange={() => setWorkoutView('FullDay')}
          />
          Full Day — see all exercises at once
        </label>
        <label style={{ display: 'flex', alignItems: 'center', gap: '0.75rem', cursor: 'pointer', marginTop: '0.5rem' }}>
          <input
            type="radio"
            value="Guided"
            checked={workoutView === 'Guided'}
            onChange={() => setWorkoutView('Guided')}
          />
          Guided — one exercise at a time
        </label>
      </div>

      <div style={{ marginTop: '2rem' }}>
        <h2>Rest Timer</h2>
        <p style={{ color: '#666', marginBottom: '0.75rem' }}>
          Auto-starts after logging a set.
        </p>
        <label style={{ display: 'flex', alignItems: 'center', gap: '0.75rem', cursor: 'pointer' }}>
          <input
            type="checkbox"
            checked={restTimer}
            onChange={e => setRestTimer(e.target.checked)}
          />
          Enable rest timer
        </label>
      </div>

      {saved && <p style={{ color: 'green', marginTop: '1rem' }}>Settings saved!</p>}
      {error && <p style={{ color: 'red', marginTop: '1rem' }}>{error}</p>}

      <button
        onClick={handleSave}
        disabled={saving}
        style={{ marginTop: '2rem', padding: '0.6rem 1.5rem', cursor: 'pointer' }}
      >
        {saving ? 'Saving...' : 'Save Settings'}
      </button>

      {/* --- Divider --- */}
      <hr style={{ margin: '2.5rem 0', borderColor: '#ddd' }} />

      {/* --- Change Password --- */}
      <div>
        <h2>Change Password</h2>
        <p style={{ color: '#666', marginBottom: '1rem' }}>
          Confirm your current password before setting a new one.
        </p>

        <div style={{ display: 'flex', flexDirection: 'column', gap: '0.75rem' }}>
          <label style={labelStyle}>
            Current password
            <input
              type="password"
              value={currentPassword}
              onChange={e => setCurrentPassword(e.target.value)}
              style={inputStyle}
            />
          </label>
          <label style={labelStyle}>
            New password
            <input
              type="password"
              value={newPassword}
              onChange={e => setNewPassword(e.target.value)}
              style={inputStyle}
            />
          </label>
          <label style={labelStyle}>
            Confirm new password
            <input
              type="password"
              value={confirmNewPassword}
              onChange={e => setConfirmNewPassword(e.target.value)}
              style={inputStyle}
            />
          </label>
        </div>

        {passwordSaved && <p style={{ color: 'green', marginTop: '1rem' }}>Password changed successfully!</p>}
        {passwordError && <p style={{ color: 'red', marginTop: '1rem' }}>{passwordError}</p>}

        <button
          onClick={handleChangePassword}
          disabled={passwordSaving}
          style={{ marginTop: '1.5rem', padding: '0.6rem 1.5rem', cursor: 'pointer' }}
        >
          {passwordSaving ? 'Saving...' : 'Change Password'}
        </button>
      </div>
    </div>
  );
}

const labelStyle: React.CSSProperties = {
  display: 'flex',
  flexDirection: 'column',
  gap: '0.25rem',
  fontSize: '0.9rem',
  color: '#333',
};

const inputStyle: React.CSSProperties = {
  padding: '0.5rem 0.75rem',
  border: '1px solid #ddd',
  borderRadius: 4,
  fontSize: '0.9rem',
};