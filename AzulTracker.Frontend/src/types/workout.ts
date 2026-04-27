export interface WorkoutLogRequest {
  programExerciseId?: number;   // nullable — can log without a program
  customExerciseName?: string;  // used when no programExerciseId
  date: string;                 // ISO format: "2026-04-27"
  setNumber: number;
  weight: number;
  repsCompleted: number;
  rpe?: number;                 // optional, 1–10 scale
  notes?: string;
}

export interface WorkoutLogDto {
  id: number;
  exerciseName: string;         // resolved by backend — never null
  date: string;
  setNumber: number;
  weight: number;
  repsCompleted: number;
  rpe?: number;
  notes?: string;
  createdAt: string;
}

export interface ProgramExerciseRef {
  id: number;
  exerciseName: string;   // resolved display name
  sets: number;
  reps: number;
  orderIndex: number;
  notes?: string;
}

export interface ProgramDayRef {
  id: number;
  name: string;
  dayOrder: number;
  exercises: ProgramExerciseRef[];
}