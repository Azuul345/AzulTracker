import { Routes, Route, Navigate } from 'react-router-dom';
import { useAuth } from './context/AuthContext';
import LoginPage from './pages/LoginPage';
import RegisterPage from './pages/RegisterPage';
import DashboardPage from './pages/DashboardPage';
import ProgramsPage from './pages/ProgramsPage';
import ProgramDetailPage from './pages/ProgramDetailPage';
import WorkoutPage from './pages/WorkoutPage';
import Navbar from './components/Navbar';

// Add this import at the top with your other imports
import AdminRoute from './components/AdminRoute';
import { lazy, Suspense } from 'react';

// Add these lazy imports alongside your existing ones
const AdminUsersPage     = lazy(() => import('./pages/AdminUsersPage'));
const AdminStatsPage     = lazy(() => import('./pages/AdminStatsPage'));
const AdminExercisesPage = lazy(() => import('./pages/AdminExercisesPage'));
const AdminVideosPage    = lazy(() => import('./pages/AdminVideosPage'));
const UserSettingsPage   = lazy(() => import('./pages/UserSettingsPage'));

// Protects any route that requires login
function ProtectedRoute({ children }: { children: React.ReactNode }) {
  const { user, isLoading } = useAuth();

  if (isLoading) return null; // Wait for localStorage check to finish

  if (!user) return <Navigate to="/login" replace />;

  return <>{children}</>;
}

export default function App() {
  return (
    <>
    <Navbar />
    <Suspense fallback={null}>
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
      {/* Settings — any logged-in user */}
      <Route path="/settings" element={
        <ProtectedRoute>
          <UserSettingsPage />
        </ProtectedRoute>
      } />

      {/* Admin only */}
      <Route path="/admin/users" element={
        <AdminRoute>
          <AdminUsersPage />
        </AdminRoute>
      } />
      <Route path="/admin/stats" element={
        <AdminRoute>
          <AdminStatsPage />
        </AdminRoute>
      } />
      <Route path="/admin/exercises" element={
        <AdminRoute>
          <AdminExercisesPage />
        </AdminRoute>
      } />
      <Route path="/admin/videos" element={
        <AdminRoute>
          <AdminVideosPage />
        </AdminRoute>
      } />
        {/* Redirect root to dashboard — ProtectedRoute will handle the rest */}
        <Route path="/" element={<Navigate to="/dashboard" replace />} />
        <Route path="/workout" element={<ProtectedRoute><WorkoutPage /></ProtectedRoute>} />
      </Routes>
    </Suspense>
    </>
  );
}