import { useState, useEffect } from "react";
import { Link, useNavigate } from "react-router-dom";
import { useAuth } from "../context/AuthContext";
import { getPendingExerciseCount } from "../services/adminService";

export default function Navbar() {
  const { user, logout, isAdmin } = useAuth();
  const navigate = useNavigate();
  const [pendingCount, setPendingCount] = useState(0);

  useEffect(() => {
    if (!isAdmin()) return;
    getPendingExerciseCount().then((count) => setPendingCount(count));
  }, []);

  const handleLogout = () => {
    logout();
    navigate("/login");
  };

  if (!user) return null;

  return (
    <nav
      style={{
        display: "flex",
        alignItems: "center",
        justifyContent: "space-between",
        padding: "0.75rem 2rem",
        borderBottom: "1px solid #ddd",
        backgroundColor: "#fff",
        flexWrap: "wrap",
        gap: "0.5rem",
      }}
    >
      <div style={{ display: "flex", gap: "1.5rem", alignItems: "center" }}>
        <Link
          to="/dashboard"
          style={{ fontWeight: "bold", textDecoration: "none", color: "#000" }}
        >
          AzulTracker
        </Link>
        <Link to="/dashboard" style={linkStyle}>
          Dashboard
        </Link>
        <Link to="/programs" style={linkStyle}>
          Programs
        </Link>
        <Link to="/workout" style={linkStyle}>
          Workout
        </Link>
        {isAdmin() && (
          <>
            <Link to="/admin/users" style={linkStyle}>
              Users
            </Link>
            <Link to="/admin/stats" style={linkStyle}>
              Stats
            </Link>
            <Link to="/admin/exercises" style={linkStyle}>
              Exercises
              {pendingCount > 0 && (
                <span
                  id="admin-pending-badge"
                  data-pending-count={pendingCount}
                  style={{
                    background: "#c0392b",
                    color: "#fff",
                    borderRadius: "9999px",
                    padding: "0 6px",
                    fontSize: "0.75rem",
                    marginLeft: "5px",
                    lineHeight: "1.4",
                    display: "inline-block",
                  }}
                >
                  {pendingCount}
                </span>
              )}
            </Link>
            <Link to="/admin/videos" style={linkStyle}>
              Videos
            </Link>
          </>
        )}
      </div>

      <div style={{ display: "flex", gap: "1rem", alignItems: "center" }}>
        <span style={{ color: "#666", fontSize: "0.875rem" }}>
          {user.username}
        </span>
        <Link to="/settings" style={{ ...buttonStyle, textDecoration: "none" }}>
          Settings
        </Link>
        <button onClick={handleLogout} style={buttonStyle}>
          Logout
        </button>
      </div>
    </nav>
  );
}

const linkStyle: React.CSSProperties = {
  textDecoration: "none",
  color: "#333",
  fontSize: "0.9rem",
};

const buttonStyle: React.CSSProperties = {
  background: "none",
  border: "1px solid #ddd",
  borderRadius: 4,
  padding: "0.25rem 0.75rem",
  cursor: "pointer",
  fontSize: "0.9rem",
  color: "#333",
};
