import { useEffect, useState, useRef } from 'react';

interface Props {
  durationSeconds?: number;
  onComplete?: () => void;
}

export default function RestTimer({ durationSeconds = 90, onComplete }: Props) {
  const [secondsLeft, setSecondsLeft] = useState(durationSeconds);
  const [isActive, setIsActive] = useState(true);
  const onCompleteRef = useRef(onComplete)

  useEffect(() => {
    onCompleteRef.current = onComplete;
  }, [onComplete]);

  useEffect(() => {
    if (!isActive || secondsLeft <= 0) {
      if (secondsLeft <= 0) onCompleteRef.current?.();
      return;
    }

    const interval = setInterval(() => {
      setSecondsLeft(prev => prev - 1);
    }, 1000);

    return () => clearInterval(interval);
  }, [secondsLeft, isActive]);

  const minutes = Math.floor(secondsLeft / 60);
  const seconds = secondsLeft % 60;
  const display = `${minutes}:${seconds.toString().padStart(2, '0')}`;

  if (!isActive || secondsLeft <= 0) return null;

  return (
    <div style={{ marginTop: '12px', padding: '12px', background: '#f0f0f0', borderRadius: '8px' }}>
      <p>Rest: <strong>{display}</strong></p>
      <button onClick={() => setIsActive(false)}>Skip</button>
    </div>
  );
}