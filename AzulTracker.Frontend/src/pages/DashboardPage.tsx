import { Link } from 'react-router-dom';

export default function DashboardPage() {
  return (
    <div>
      <h1>Dashboard</h1>
      <Link to="/workout">Go to Today's Workout</Link>
    </div>
  );
}