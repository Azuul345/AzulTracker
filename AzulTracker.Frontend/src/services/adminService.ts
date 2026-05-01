import api from './api';

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
}

export interface AdminVideoUrl {
  id: number;
  url: string;
  submittedByUsername: string | null;
  createdAt: string;
}

// --- User Management ---

export async function getUsers(): Promise<AdminUser[]> {
  const response = await api.get<AdminUser[]>('/admin/users');
  return response.data;
}

export async function setUserStatus(id: number, isActive: boolean): Promise<void> {
  await api.put(`/admin/users/${id}/status`, { isActive });
}

export async function setUserRole(id: number, role: string): Promise<void> {
  await api.put(`/admin/users/${id}/role`, { role });
}

// --- Stats ---

export async function getStats(): Promise<AdminStats> {
  const response = await api.get<AdminStats>('/admin/stats');
  return response.data;
}

// --- Exercise Moderation ---

export async function getPendingExercises(): Promise<PendingExercise[]> {
  const response = await api.get<PendingExercise[]>('/admin/exercises/pending');
  return response.data;
}

export async function approveExercise(id: number): Promise<void> {
  await api.put(`/admin/exercises/${id}/approve`);
}

// --- Video Moderation ---

export async function getPendingVideos(): Promise<AdminVideoUrl[]> {
  const response = await api.get<AdminVideoUrl[]>('/admin/videos/pending');
  return response.data;
}

export async function blockVideo(id: number): Promise<void> {
  await api.put(`/admin/videos/${id}/block`);
}