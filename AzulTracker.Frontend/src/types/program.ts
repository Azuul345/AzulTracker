export interface TrainingProgram {
  id: number;
  name: string;
  description: string | null;
  daysPerWeek: number;
  isActive: boolean;
  createdAt: string;
}

export interface ProgramDay {
  id: number;
  name: string;
  dayOrder: number;
  trainingProgramId: number;
}

export interface ExerciseMuscle {
  muscleId: number;
  muscleName: string;
  isPrimary: boolean;
  imageUrl?: string;
}

export interface ProgramExercise {
  id: number;
  programDayId: number;
  exerciseLibraryId: number | null;
  exerciseName: string | null;
  customExerciseName: string | null;
  sets: number;
  reps: number;
  orderIndex: number;
  notes: string | null;
  videoUrl: string | null;
  muscles?: ExerciseMuscle[];
}

export interface ExerciseSearchResult {
  id: number;
  name: string;
  category: string;
}
export interface MuscleOption {
  id: number;
  name: string;
  muscleGroup: string;
  imageUrl: string | null;
  isApproved: boolean;
}

export interface MuscleAssignment {
  muscleId: number;
  isPrimary: boolean;
}
