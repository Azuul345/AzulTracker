import api from './api';

export interface UpdateSettingsRequest {
  preferredWorkoutView: 'FullDay' | 'Guided';
  restTimerEnabled: boolean;
}

export async function updateSettings(data: UpdateSettingsRequest): Promise<void> {
  await api.patch('/auth/settings', data);
}