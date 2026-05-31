import axios from 'axios';

const api = axios.create({
  baseURL:  import.meta.env.VITE_API_URL || "http://localhost:5041/api",
});

// This gets set by AuthContext on mount so the interceptor can call logout
let logoutCallback: (() => void) | null = null;

export function registerLogoutCallback(fn: () => void) {
  logoutCallback = fn;
}

// Before every request, grab the token and attach it if it exists
api.interceptors.request.use((config) => {
  const token = localStorage.getItem('token');
  if (token) {
    config.headers.Authorization = `Bearer ${token}`;
  }
  return config;
});

// Response interceptor — handle expired token
api.interceptors.response.use(
  (response) => response,
  (error) => {
    if (error.response?.status === 401 && logoutCallback) {
      logoutCallback();
      window.location.href = '/login';
    }
    return Promise.reject(error);
  }
);

export default api;