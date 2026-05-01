import { useState } from 'react';
import { workoutService } from '../services/workoutService';
import type { ProgramExercise } from '../types/program';
import type { WorkoutLogDto } from '../types/workout';
import RestTimer from './RestTimer';

interface Props {
  exercise: ProgramExercise;
  nextSetNumber: number;
  onLogged: (log: WorkoutLogDto) => void;
}

export default function LogSetForm({ exercise, nextSetNumber, onLogged }: Props) {
  const [weight, setWeight] = useState('');
  const [reps, setReps] = useState(String(exercise.reps));
  const [rpe, setRpe] = useState('');
  const [notes, setNotes] = useState('');
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [showTimer, setShowTimer] = useState(false);  // ← moved here

  const today = new Date().toISOString().split('T')[0];

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setError(null);

    if (!weight) {
      setError('Weight is required.');
      return;
    }

    setIsSubmitting(true);
    try {
      const newLog = await workoutService.logSet({
        programExerciseId: exercise.id,
        date: today,
        setNumber: nextSetNumber,
        weight: parseFloat(weight),
        repsCompleted: parseInt(reps),
        rpe: rpe ? parseInt(rpe) : undefined,
        notes: notes || undefined,
      });

      onLogged(newLog);
      setShowTimer(true);

      setWeight('');
      setRpe('');
      setNotes('');
    } catch {
      setError('Failed to log set. Try again.');
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <form onSubmit={handleSubmit} style={{ marginTop: '12px' }}>
      <p>Log Set {nextSetNumber}</p>

      <div style={{ display: 'flex', gap: '8px', flexWrap: 'wrap' }}>
        <label>
          Weight (kg)
          <input
            type="number"
            step="0.5"
            value={weight}
            onChange={e => setWeight(e.target.value)}
            placeholder="e.g. 80"
            required
          />
        </label>

        <label>
          Reps
          <input
            type="number"
            value={reps}
            onChange={e => setReps(e.target.value)}
          />
        </label>

        <label>
          RPE (optional)
          <input
            type="number"
            min="1"
            max="10"
            value={rpe}
            onChange={e => setRpe(e.target.value)}
            placeholder="1–10"
          />
        </label>
      </div>

      <label style={{ display: 'block', marginTop: '8px' }}>
        Notes (optional)
        <input
          type="text"
          value={notes}
          onChange={e => setNotes(e.target.value)}
          placeholder="e.g. felt easy"
        />
      </label>

      {error && <p style={{ color: 'red' }}>{error}</p>}

      <button type="submit" disabled={isSubmitting} style={{ marginTop: '8px' }}>
        {isSubmitting ? 'Logging...' : `Log Set ${nextSetNumber}`}
      </button>

      {showTimer && (
        <RestTimer
          durationSeconds={90}
          onComplete={() => setShowTimer(false)}
        />
      )}
    </form>
  );
}