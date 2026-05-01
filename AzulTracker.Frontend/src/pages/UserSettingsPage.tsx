import { useState } from 'react';
import { useAuth } from '../context/AuthContext';
import { updateSettings } from '../services/userService';

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

  return (
    <div style={{ maxWidth: 480, margin: '2rem auto', padding: '0 1rem' }}>
      <h1>Settings</h1>

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
    </div>
  );
}