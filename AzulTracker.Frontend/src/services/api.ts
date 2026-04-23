import axios from 'axios';

const api = axios.create({
  baseURL: 'http://localhost:5041/api',
});

// Before every request, grab the token and attach it if it exists
api.interceptors.request.use((config) => {
  const token = localStorage.getItem('token');
  if (token) {
    config.headers.Authorization = `Bearer ${token}`;
  }
  return config;
});

export default api;