import { Routes, Route, Navigate } from 'react-router-dom';
import { useAuth } from './context/AuthContext';
import LoginPage from './pages/LoginPage';
import RegisterPage from './pages/RegisterPage';
import DashboardPage from './pages/DashboardPage';
import ProgramsPage from './pages/ProgramsPage';
import ProgramDetailPage from './pages/ProgramDetailPage';
import WorkoutPage from './pages/WorkoutPage';

// Protects any route that requires login
function ProtectedRoute({ children }: { children: React.ReactNode }) {
  const { user, isLoading } = useAuth();

  if (isLoading) return null; // Wait for localStorage check to finish

  if (!user) return <Navigate to="/login" replace />;

  return <>{children}</>;
}

export default function App() {
  return (
    <Routes>
      <Route path="/login" element={<LoginPage />} />
      <Route path="/register" element={<RegisterPage />} />
      <Route
        path="/dashboard"
        element={
          <ProtectedRoute>
            <DashboardPage />
          </ProtectedRoute>
        }
      />
    <Route
      path="/programs"
      element={
        <ProtectedRoute>
          <ProgramsPage />
        </ProtectedRoute>
      }
    />
    <Route
      path="/programs/:id"
      element={
       <ProtectedRoute>
         <ProgramDetailPage />
      </ProtectedRoute>
      }
    />
      {/* Redirect root to dashboard — ProtectedRoute will handle the rest */}
      <Route path="/" element={<Navigate to="/dashboard" replace />} />
      <Route path="/workout" element={<ProtectedRoute><WorkoutPage /></ProtectedRoute>} />
    </Routes>
  );
}