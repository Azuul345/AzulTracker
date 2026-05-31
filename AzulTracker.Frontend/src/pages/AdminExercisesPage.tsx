import { useEffect, useState } from 'react';
import {
  getPendingExercises,
  approveExercise,
  getAllExercises,
  updateExercise,
  getAllMuscles,
  assignMuscles,
} from '../services/adminService';
import type { PendingExercise, AdminExercise, Muscle } from '../services/adminService';

type Tab = 'pending' | 'library';

const CATEGORIES = ['Chest', 'Back', 'Shoulders', 'Arms', 'Core', 'Legs', 'Glutes', 'Calves'];

export default function AdminExercisesPage() {
  const [activeTab, setActiveTab] = useState<Tab>('pending');

  // --- Pending tab state ---
  const [pending, setPending] = useState<PendingExercise[]>([]);
  const [pendingLoading, setPendingLoading] = useState(true);
  const [pendingError, setPendingError] = useState('');

  // --- Library tab state ---
  const [library, setLibrary] = useState<AdminExercise[]>([]);
  const [libraryLoading, setLibraryLoading] = useState(true);
  const [libraryError, setLibraryError] = useState('');
  const [search, setSearch] = useState('');

  // --- All muscles for dropdown ---
  const [allMuscles, setAllMuscles] = useState<Muscle[]>([]);

  // --- Edit panel state ---
  const [editingExercise, setEditingExercise] = useState<AdminExercise | null>(null);
  const [editName, setEditName] = useState('');
  const [editCategory, setEditCategory] = useState('');
  const [editVideoUrl, setEditVideoUrl] = useState('');
  const [editMuscles, setEditMuscles] = useState<{ muscleId: number; muscleName: string; isPrimary: boolean }[]>([]);
  const [selectedMuscleId, setSelectedMuscleId] = useState<number>(0);
  const [selectedMuscleIsPrimary, setSelectedMuscleIsPrimary] = useState(true);
  const [editSaving, setEditSaving] = useState(false);
  const [editSaved, setEditSaved] = useState(false);
  const [editError, setEditError] = useState('');

  useEffect(() => {
    getPendingExercises()
      .then(setPending)
      .catch(() => setPendingError('Failed to load pending exercises.'))
      .finally(() => setPendingLoading(false));

    getAllExercises()
      .then(setLibrary)
      .catch(() => setLibraryError('Failed to load exercise library.'))
      .finally(() => setLibraryLoading(false));

    getAllMuscles()
      .then(muscles => {
        setAllMuscles(muscles);
        if (muscles.length > 0) setSelectedMuscleId(muscles[0].id);
      })
      .catch(() => {});
  }, []);

  const handleApprove = async (exercise: PendingExercise) => {
    try {
      await approveExercise(exercise.id);
      setPending(prev => prev.filter(e => e.id !== exercise.id));
    } catch {
      alert('Failed to approve exercise.');
    }
  };

  const handleEditOpen = (exercise: AdminExercise) => {
    setEditingExercise(exercise);
    setEditName(exercise.name);
    setEditCategory(exercise.category);
    setEditVideoUrl(exercise.videoUrl ?? '');
    setEditMuscles(exercise.muscles.map(m => ({
      muscleId: m.muscleId,
      muscleName: m.muscleName,
      isPrimary: m.isPrimary,
    })));
    setEditSaved(false);
    setEditError('');
  };

  const handleEditClose = () => {
    setEditingExercise(null);
    setEditSaved(false);
    setEditError('');
  };

  const handleAddMuscle = () => {
    if (!selectedMuscleId) return;
    if (editMuscles.some(m => m.muscleId === selectedMuscleId)) return; // already in list
    const muscle = allMuscles.find(m => m.id === selectedMuscleId);
    if (!muscle) return;
    setEditMuscles(prev => [...prev, {
      muscleId: muscle.id,
      muscleName: muscle.name,
      isPrimary: selectedMuscleIsPrimary,
    }]);
  };

  const handleRemoveMuscle = (muscleId: number) => {
    setEditMuscles(prev => prev.filter(m => m.muscleId !== muscleId));
  };

  const handleTogglePrimary = (muscleId: number) => {
    setEditMuscles(prev => prev.map(m =>
      m.muscleId === muscleId ? { ...m, isPrimary: !m.isPrimary } : m
    ));
  };

  const handleEditSave = async () => {
    if (!editingExercise) return;
    if (!editName.trim()) { setEditError('Name cannot be empty.'); return; }
    if (!editCategory) { setEditError('Please select a category.'); return; }

    setEditSaving(true);
    setEditError('');
    setEditSaved(false);
    try {
      // Save name, category, video URL
      await updateExercise(editingExercise.id, {
        name: editName.trim(),
        category: editCategory,
        videoUrl: editVideoUrl.trim() || null,
      });

      // Save muscle assignments (full replace)
      await assignMuscles(editingExercise.id, editMuscles.map(m => ({
        muscleId: m.muscleId,
        isPrimary: m.isPrimary,
      })));

      // Update local library state immediately
      setLibrary(prev => prev.map(e =>
        e.id === editingExercise.id
          ? {
              ...e,
              name: editName.trim(),
              category: editCategory,
              videoUrl: editVideoUrl.trim() || null,
              muscles: editMuscles.map(m => ({
                muscleId: m.muscleId,
                muscleName: m.muscleName,
                muscleGroup: '',
                isPrimary: m.isPrimary,
              })),
            }
          : e
      ));
      setEditSaved(true);
    } catch {
      setEditError('Failed to save changes. Please try again.');
    } finally {
      setEditSaving(false);
    }
  };

  const filteredLibrary = library.filter(e =>
    e.name.toLowerCase().includes(search.toLowerCase()) ||
    e.category.toLowerCase().includes(search.toLowerCase())
  );

  // --- Edit view replaces the whole page content when active ---
  if (editingExercise) {
    return (
      <div>
        <button onClick={handleEditClose}>← Back to Library</button>
        <h1>Edit: {editingExercise.name}</h1>

        <div>
          <label>
            Name
            <input
              type="text"
              value={editName}
              onChange={e => setEditName(e.target.value)}
            />
          </label>
        </div>

        <div>
          <label>
            Category
            <select value={editCategory} onChange={e => setEditCategory(e.target.value)}>
              {CATEGORIES.map(c => (
                <option key={c} value={c}>{c}</option>
              ))}
            </select>
          </label>
        </div>

        <div>
          <label>
            Video URL
            <input
              type="text"
              value={editVideoUrl}
              onChange={e => setEditVideoUrl(e.target.value)}
              placeholder="https://youtube.com/watch?v=..."
            />
          </label>
        </div>

        <div>
          <h2>Muscle Assignments</h2>

          {/* Current assignments */}
          {editMuscles.length === 0
            ? <p>No muscles assigned yet.</p>
            : editMuscles.map(m => (
              <div key={m.muscleId}>
                <span>{m.muscleName}</span>
                <button onClick={() => handleTogglePrimary(m.muscleId)}>
                  {m.isPrimary ? 'Primary' : 'Secondary'}
                </button>
                <button onClick={() => handleRemoveMuscle(m.muscleId)}>Remove</button>
              </div>
            ))
          }

          {/* Add muscle */}
          <div>
            <select
              value={selectedMuscleId}
              onChange={e => setSelectedMuscleId(Number(e.target.value))}
            >
              {allMuscles.map(m => (
                <option key={m.id} value={m.id}>{m.name} ({m.muscleGroup})</option>
              ))}
            </select>
            <select
              value={selectedMuscleIsPrimary ? 'primary' : 'secondary'}
              onChange={e => setSelectedMuscleIsPrimary(e.target.value === 'primary')}
            >
              <option value="primary">Primary</option>
              <option value="secondary">Secondary</option>
            </select>
            <button onClick={handleAddMuscle}>Add Muscle</button>
          </div>
        </div>

        {editSaved && <p>Changes saved!</p>}
        {editError && <p>{editError}</p>}

        <button onClick={handleEditSave} disabled={editSaving}>
          {editSaving ? 'Saving...' : 'Save Changes'}
        </button>
        <button onClick={handleEditClose}>Cancel</button>
      </div>
    );
  }

  // --- Default view: tabs + table ---
  return (
    <div>
      <h1>Exercises</h1>

      <div>
        <button onClick={() => setActiveTab('pending')}>
          Pending Approvals {pending.length > 0 && `(${pending.length})`}
        </button>
        <button onClick={() => setActiveTab('library')}>Exercise Library</button>
      </div>

      {activeTab === 'pending' && (
        <div>
          {pendingLoading && <p>Loading...</p>}
          {pendingError && <p>{pendingError}</p>}
          {!pendingLoading && !pendingError && pending.length === 0 && (
            <p>No pending exercises — you're all caught up.</p>
          )}
          {!pendingLoading && !pendingError && pending.length > 0 && (
            <table>
              <thead>
                <tr>
                  <th>Name</th>
                  <th>Category</th>
                  <th>Submitted By</th>
                  <th>Date</th>
                  <th>Action</th>
                </tr>
              </thead>
              <tbody>
                {pending.map(ex => (
                  <tr key={ex.id}>
                    <td>{ex.name}</td>
                    <td>{ex.category}</td>
                    <td>{ex.submittedByUsername ?? 'Unknown'}</td>
                    <td>{new Date(ex.createdAt).toLocaleDateString()}</td>
                    <td><button onClick={() => handleApprove(ex)}>Approve</button></td>
                  </tr>
                ))}
              </tbody>
            </table>
          )}
        </div>
      )}

      {activeTab === 'library' && (
        <div>
          <input
            type="text"
            placeholder="Search by name or category..."
            value={search}
            onChange={e => setSearch(e.target.value)}
          />
          <p>{filteredLibrary.length} exercise{filteredLibrary.length !== 1 ? 's' : ''} found</p>

          {libraryLoading && <p>Loading...</p>}
          {libraryError && <p>{libraryError}</p>}
          {!libraryLoading && !libraryError && (
            <table>
              <thead>
                <tr>
                  <th>Name</th>
                  <th>Category</th>
                  <th>Status</th>
                  <th>Muscles</th>
                  <th>Video</th>
                  <th>Action</th>
                </tr>
              </thead>
              <tbody>
                {filteredLibrary.map(ex => (
                  <tr key={ex.id}>
                    <td>{ex.name}</td>
                    <td>{ex.category}</td>
                    <td>{ex.isApproved ? 'Approved' : 'Pending'}</td>
                    <td>
                      {ex.muscles.length === 0
                        ? 'None assigned'
                        : ex.muscles.map(m =>
                            `${m.muscleName}${m.isPrimary ? ' (primary)' : ''}`
                          ).join(', ')
                      }
                    </td>
                    <td>{ex.videoUrl ? '✓ Set' : 'Not set'}</td>
                    <td><button onClick={() => handleEditOpen(ex)}>Edit</button></td>
                  </tr>
                ))}
              </tbody>
            </table>
          )}
        </div>
      )}
    </div>
  );
}