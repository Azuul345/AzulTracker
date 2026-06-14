import api from "./api";

// --- Types ---

export interface AdminUser {
  id: number;
  username: string;
  email: string;
  role: string;
  isActive: boolean;
  createdAt: string;
}

export interface AdminStats {
  totalUsers: number;
  totalLogs: number;
  popularExercises: { exerciseName: string; count: number }[];
}

export interface PendingExercise {
  id: number;
  name: string;
  category: string;
  submittedByUsername: string | null;
  createdAt: string;
  muscles: { muscleId: number; muscleName: string; isPrimary: boolean }[];
}

export interface AdminVideoUrl {
  id: number;
  url: string;
  submittedByUsername: string | null;
  createdAt: string;
}

export interface AdminExercise {
  id: number;
  name: string;
  category: string;
  description: string | null;
  videoUrl: string | null;
  isApproved: boolean;
  muscles: {
    muscleId: number;
    muscleName: string;
    muscleGroup: string;
    isPrimary: boolean;
  }[];
}

// --- User Management ---

export async function getUsers(): Promise<AdminUser[]> {
  const response = await api.get<AdminUser[]>("/admin/users");
  return response.data;
}

export async function setUserStatus(
  id: number,
  isActive: boolean,
): Promise<void> {
  await api.put(`/admin/users/${id}/status`, { isActive });
}

export async function setUserRole(id: number, role: string): Promise<void> {
  await api.put(`/admin/users/${id}/role`, { role });
}

// --- Stats ---

export async function getStats(): Promise<AdminStats> {
  const response = await api.get<AdminStats>("/admin/stats");
  return response.data;
}

// --- Exercise Moderation ---

export async function getPendingExercises(): Promise<PendingExercise[]> {
  const response = await api.get<PendingExercise[]>("/admin/exercises/pending");
  return response.data;
}

export async function approveExercise(id: number): Promise<void> {
  await api.put(`/admin/exercises/${id}/approve`);
}

export const rejectExercise = (id: number) =>
  api.put(`/admin/exercises/${id}/reject`);

// --- Exercise Library Management ---

export async function getAllExercises(): Promise<AdminExercise[]> {
  const response = await api.get<AdminExercise[]>("/admin/exercises/all");
  return response.data;
}

export async function updateExercise(
  id: number,
  data: { name: string; category: string; videoUrl: string | null },
): Promise<void> {
  await api.put(`/admin/exercises/${id}`, data);
}

export interface Muscle {
  id: number;
  name: string;
  muscleGroup: string;
  imageUrl: string | null;
}

export interface PendingMuscle {
  id: number;
  name: string;
  muscleGroup: string;
  submittedByUsername: string | null;
  createdAt: string;
}

export interface MuscleAssignment {
  muscleId: number;
  isPrimary: boolean;
}

export async function getAllMuscles(): Promise<Muscle[]> {
  const response = await api.get<Muscle[]>("/admin/muscles");
  return response.data;
}

export async function assignMuscles(
  exerciseId: number,
  muscles: MuscleAssignment[],
): Promise<void> {
  await api.put(`/admin/exercises/${exerciseId}/muscles`, { muscles });
}

// --- Video Moderation ---

export async function getPendingVideos(): Promise<AdminVideoUrl[]> {
  const response = await api.get<AdminVideoUrl[]>("/admin/videos/pending");
  return response.data;
}

export async function blockVideo(id: number): Promise<void> {
  await api.put(`/admin/videos/${id}/block`);
}

export async function getPendingExerciseCount(): Promise<number> {
  const res = await api.get<number>("/admin/exercises/pending/count");
  return res.data;
}

export interface AddMuscleDto {
  name: string;
  muscleGroup: string;
  imageUrl: string | null;
}

export async function addMuscle(data: AddMuscleDto): Promise<Muscle> {
  const res = await api.post<Muscle>("/admin/muscles", data);
  return res.data;
}

export async function deleteExercise(id: number): Promise<void> {
  await api.delete(`/admin/exercises/${id}`);
}

export async function getPendingMuscles(): Promise<PendingMuscle[]> {
  const res = await api.get<PendingMuscle[]>("/admin/muscles/pending");
  return res.data;
}

export async function getPendingMuscleCount(): Promise<number> {
  const res = await api.get<number>("/admin/muscles/pending/count");
  return res.data;
}

export async function approveMuscle(id: number): Promise<void> {
  await api.put(`/admin/muscles/${id}/approve`);
}

export async function uploadMuscleImage(id: number, file: File): Promise<void> {
  const formData = new FormData();
  formData.append("file", file);
  await api.post(`/admin/muscles/${id}/image`, formData, {
    headers: { "Content-Type": "multipart/form-data" },
  });
}

export async function deletePendingMuscle(id: number): Promise<void> {
  await api.delete(`/admin/muscles/${id}`);
}
