import { createContext, useContext, useState, useEffect, useCallback, useRef } from 'react';
import type { ReactNode } from 'react';
import type { AuthUser } from '../types/auth';
import { registerLogoutCallback } from '../services/api';

interface AuthContextType {
  user: AuthUser | null;
  isLoading: boolean;
  login: (token: string, user: AuthUser) => void;
  logout: () => void;
  isAdmin: () => boolean;
  updateSettings: (view: 'FullDay' | 'Guided', restTimer: boolean) => void;
}

const AuthContext = createContext<AuthContextType | null>(null);

export function AuthProvider({ children }: { children: ReactNode }) {
  const [user, setUser] = useState<AuthUser | null>(null);
  const [isLoading, setIsLoading] = useState(true);
  const logoutTimerRef = useRef<ReturnType<typeof setTimeout> | null>(null);


  const logout = useCallback(() => {
    if (logoutTimerRef.current) clearTimeout(logoutTimerRef.current); // clear timer on manual logout
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    setUser(null);
  }, []);

  // starts (or restarts) the 5-hour auto-logout timer
  const startLogoutTimer = useCallback(() => {
    if (logoutTimerRef.current) clearTimeout(logoutTimerRef.current);
    logoutTimerRef.current = setTimeout(() => {
      logout();
      window.location.href = '/login';
    }, 5 * 60 * 60 * 1000);
  }, [logout]);

  // On app load, check if a token + user already exists in localStorage
  useEffect(() => {
    const token = localStorage.getItem('token');
    const storedUser = localStorage.getItem('user');

    if (token && storedUser) {
        // eslint-disable-next-line react-hooks/set-state-in-effect
      setUser(JSON.parse(storedUser));
       startLogoutTimer();
    }
   
    setIsLoading(false);
    registerLogoutCallback(logout);
  }, [logout, startLogoutTimer]);

  const login = (token: string, user: AuthUser) => {
    localStorage.setItem('token', token);
    localStorage.setItem('user', JSON.stringify(user));
    setUser(user);
    startLogoutTimer();
  };


  const isAdmin = () => user?.role === 'Admin';

  const updateSettings = (view: 'FullDay' | 'Guided', restTimer: boolean) => {
  setUser(prev => prev ? {
    ...prev,
    preferredWorkoutView: view,
    restTimerEnabled: restTimer
  } : null);
};

  return (
    <AuthContext.Provider value={{ user, isLoading, login, logout, isAdmin, updateSettings }}>
      {children}
    </AuthContext.Provider>
  );
}

// eslint-disable-next-line react-refresh/only-export-components
export function useAuth() {
  const context = useContext(AuthContext);
  if (!context) throw new Error('useAuth must be used inside AuthProvider');
  return context;
}