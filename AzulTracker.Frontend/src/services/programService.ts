import api from "./api";
import type { TrainingProgram, ProgramDay, ProgramExercise, ExerciseSearchResult } from "../types/program";

// --- Training Programs ---

export const getPrograms = () =>
  api.get<TrainingProgram[]>("/training-programs");

export const createProgram = (data: { name: string; description?: string; daysPerWeek: number }) =>
  api.post<TrainingProgram>("/training-programs", data);

export const updateProgram = (id: number, data: { name: string; description?: string; daysPerWeek: number }) =>
  api.put<TrainingProgram>(`/training-programs/${id}`, data);

export const deleteProgram = (id: number) =>
  api.delete(`/training-programs/${id}`);

export const activateProgram = (id: number) =>
  api.put(`/training-programs/${id}/activate`);

export const getDays = (programId: number) =>
  api.get<ProgramDay[]>(`/training-programs/${programId}/days`);

export const getExercisesForDay = (programId: number, dayId: number) =>
  api.get<ProgramExercise[]>(`/training-programs/${programId}/days/${dayId}/exercises`);

// --- Program Days ---

export const createDay = (programId: number, data: { name: string; dayOrder: number }) =>
  api.post<ProgramDay>(`/training-programs/${programId}/days`, data);

export const updateDay = (programId: number, dayId: number, data: { name: string; dayOrder: number }) =>
  api.put<ProgramDay>(`/training-programs/${programId}/days/${dayId}`, data);

export const deleteDay = (programId: number, dayId: number) =>
  api.delete(`/training-programs/${programId}/days/${dayId}`);

// --- Program Exercises ---

export const createExercise = (
  programId: number,
  dayId: number,
  data: {
    exerciseLibraryId?: number;
    customExerciseName?: string;
    sets: number;
    reps: number;
    orderIndex: number;
    notes?: string;
  }
) => api.post<ProgramExercise>(`/training-programs/${programId}/days/${dayId}/exercises`, data);

export const updateExercise = (
  programId: number,
  dayId: number,
  exerciseId: number,
  data: {
    exerciseLibraryId?: number;
    customExerciseName?: string;
    sets: number;
    reps: number;
    orderIndex: number;
    notes?: string;
  }
) => api.put<ProgramExercise>(`/training-programs/${programId}/days/${dayId}/exercises/${exerciseId}`, data);

export const deleteExercise = (programId: number, dayId: number, exerciseId: number) =>
  api.delete(`/training-programs/${programId}/days/${dayId}/exercises/${exerciseId}`);

// --- Exercise Library Search ---

export const searchExercises = (query: string) =>
  api.get<ExerciseSearchResult[]>(`/exercises?query=${encodeURIComponent(query)}`);