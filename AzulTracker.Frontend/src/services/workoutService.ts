import api from './api';
import type { WorkoutLogRequest, WorkoutLogDto } from '../types/workout';

export const workoutService = {

  logSet: async (data: WorkoutLogRequest): Promise<WorkoutLogDto> => {
    const response = await api.post<WorkoutLogDto>('/logs', data);
    return response.data;
  },

  getByDate: async (date: string): Promise<WorkoutLogDto[]> => {
    const response = await api.get<WorkoutLogDto[]>('/logs', {
      params: { date },
    });
    return response.data;
  },

  getHistory: async (): Promise<WorkoutLogDto[]> => {
    const response = await api.get<WorkoutLogDto[]>('/logs/history');
    return response.data;
  },

  exportCsv: async (): Promise<Blob> => {
    const response = await api.get('/logs/export/csv', {
      responseType: 'blob',
    });
    return response.data;
  },

};