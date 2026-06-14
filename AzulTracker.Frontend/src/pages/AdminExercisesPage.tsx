import { useEffect, useState } from "react";
import {
  getPendingExercises,
  approveExercise,
  rejectExercise,
  getAllExercises,
  updateExercise,
  getAllMuscles,
  assignMuscles,
  addMuscle,
  deleteExercise,
  getPendingMuscles,
  approveMuscle,
  uploadMuscleImage,
  deletePendingMuscle,
} from "../services/adminService";
import type {
  PendingExercise,
  AdminExercise,
  Muscle,
  PendingMuscle,
} from "../services/adminService";

type Tab = "library" | "pending" | "pendingMuscles" | "muscles";

const CATEGORIES = [
  "Chest",
  "Back",
  "Shoulders",
  "Arms",
  "Core",
  "Legs",
  "Glutes",
  "Calves",
];

type PendingMuscleState = {
  assignments: { muscleId: number; muscleName: string; isPrimary: boolean }[];
  selectedMuscleId: number;
  selectedIsPrimary: boolean;
  saving: boolean;
  saved: boolean;
  error: string;
};

type MuscleUploadState = {
  file: File | null;
  uploading: boolean;
  uploaded: boolean;
  error: string;
};

export default function AdminExercisesPage() {
  const [activeTab, setActiveTab] = useState<Tab>("pending");

  // --- Pending tab state ---
  const [pending, setPending] = useState<PendingExercise[]>([]);
  const [pendingLoading, setPendingLoading] = useState(true);
  const [pendingError, setPendingError] = useState("");

  // --- Per-card expanded muscle state (keyed by exercise id) ---
  const [expandedMusclePanel, setExpandedMusclePanel] = useState<number | null>(
    null,
  );
  const [pendingMuscleState, setPendingMuscleState] = useState<
    Record<number, PendingMuscleState>
  >({});

  // --- Library tab state ---
  const [library, setLibrary] = useState<AdminExercise[]>([]);
  const [libraryLoading, setLibraryLoading] = useState(true);
  const [libraryError, setLibraryError] = useState("");
  const [search, setSearch] = useState("");

  // --- All muscles for dropdowns ---
  const [allMuscles, setAllMuscles] = useState<Muscle[]>([]);
  const [pendingMuscles, setPendingMuscles] = useState<PendingMuscle[]>([]);
  const [pendingMusclesLoading, setPendingMusclesLoading] = useState(true);
  const [pendingMusclesError, setPendingMusclesError] = useState("");
  const [muscleUploadState, setMuscleUploadState] = useState<
    Record<number, MuscleUploadState>
  >({});

  // --- Edit panel state ---
  const [editingExercise, setEditingExercise] = useState<AdminExercise | null>(
    null,
  );
  const [editName, setEditName] = useState("");
  const [editCategory, setEditCategory] = useState("");
  const [editVideoUrl, setEditVideoUrl] = useState("");
  const [editMuscles, setEditMuscles] = useState<
    { muscleId: number; muscleName: string; isPrimary: boolean }[]
  >([]);
  const [selectedMuscleId, setSelectedMuscleId] = useState<number>(0);
  const [selectedMuscleIsPrimary, setSelectedMuscleIsPrimary] = useState(true);
  const [editSaving, setEditSaving] = useState(false);
  const [editSaved, setEditSaved] = useState(false);
  const [editError, setEditError] = useState("");
  const [newMuscleName, setNewMuscleName] = useState("");
  const [newMuscleGroup, setNewMuscleGroup] = useState("Chest");
  const [newMuscleImageUrl, setNewMuscleImageUrl] = useState("");
  const [muscleFormSaving, setMuscleFormSaving] = useState(false);
  const [muscleFormSaved, setMuscleFormSaved] = useState(false);
  const [muscleFormError, setMuscleFormError] = useState("");

  useEffect(() => {
    getPendingExercises()
      .then(setPending)
      .catch(() => setPendingError("Failed to load pending exercises."))
      .finally(() => setPendingLoading(false));

    getAllExercises()
      .then(setLibrary)
      .catch(() => setLibraryError("Failed to load exercise library."))
      .finally(() => setLibraryLoading(false));

    getAllMuscles()
      .then((muscles) => {
        setAllMuscles(muscles);
        if (muscles.length > 0) setSelectedMuscleId(muscles[0].id);
      })
      .catch(() => {});

    getPendingMuscles()
      .then(setPendingMuscles)
      .catch(() => setPendingMusclesError("Failed to load pending muscles."))
      .finally(() => setPendingMusclesLoading(false));
  }, []);

  // --- Pending muscle panel helpers ---
  const getOrInitPendingMuscleState = (
    exerciseId: number,
  ): PendingMuscleState => {
    if (pendingMuscleState[exerciseId]) return pendingMuscleState[exerciseId];
    return {
      assignments: [],
      selectedMuscleId: allMuscles.length > 0 ? allMuscles[0].id : 0,
      selectedIsPrimary: true,
      saving: false,
      saved: false,
      error: "",
    };
  };

  const updatePendingMuscleState = (
    exerciseId: number,
    patch: Partial<PendingMuscleState>,
  ) => {
    setPendingMuscleState((prev) => ({
      ...prev,
      [exerciseId]: { ...getOrInitPendingMuscleState(exerciseId), ...patch },
    }));
  };

  const handleToggleMusclePanel = (exerciseId: number) => {
    setExpandedMusclePanel((prev) => {
      if (prev === exerciseId) return null;
      if (!pendingMuscleState[exerciseId]) {
        // Pre-populate from what the user submitted
        const exercise = pending.find((e) => e.id === exerciseId);
        const preloaded = (exercise?.muscles ?? []).map((m) => ({
          muscleId: m.muscleId,
          muscleName: m.muscleName,
          isPrimary: m.isPrimary,
        }));
        setPendingMuscleState((ps) => ({
          ...ps,
          [exerciseId]: {
            assignments: preloaded, // <--- pre-filled from user submission
            selectedMuscleId: allMuscles.length > 0 ? allMuscles[0].id : 0,
            selectedIsPrimary: true,
            saving: false,
            saved: false,
            error: "",
          },
        }));
      }
      return exerciseId;
    });
  };

  const handlePendingAddMuscle = (exerciseId: number) => {
    const state = getOrInitPendingMuscleState(exerciseId);
    if (!state.selectedMuscleId) return;
    if (state.assignments.some((m) => m.muscleId === state.selectedMuscleId))
      return;
    const muscle = allMuscles.find((m) => m.id === state.selectedMuscleId);
    if (!muscle) return;
    updatePendingMuscleState(exerciseId, {
      assignments: [
        ...state.assignments,
        {
          muscleId: muscle.id,
          muscleName: muscle.name,
          isPrimary: state.selectedIsPrimary,
        },
      ],
    });
  };

  const handlePendingRemoveMuscle = (exerciseId: number, muscleId: number) => {
    const state = getOrInitPendingMuscleState(exerciseId);
    updatePendingMuscleState(exerciseId, {
      assignments: state.assignments.filter((m) => m.muscleId !== muscleId),
    });
  };

  const handlePendingTogglePrimary = (exerciseId: number, muscleId: number) => {
    const state = getOrInitPendingMuscleState(exerciseId);
    updatePendingMuscleState(exerciseId, {
      assignments: state.assignments.map((m) =>
        m.muscleId === muscleId ? { ...m, isPrimary: !m.isPrimary } : m,
      ),
    });
  };

  const handlePendingSaveMuscles = async (exerciseId: number) => {
    const state = getOrInitPendingMuscleState(exerciseId);
    updatePendingMuscleState(exerciseId, {
      saving: true,
      error: "",
      saved: false,
    });
    try {
      await assignMuscles(
        exerciseId,
        state.assignments.map((m) => ({
          muscleId: m.muscleId,
          isPrimary: m.isPrimary,
        })),
      );
      updatePendingMuscleState(exerciseId, { saving: false, saved: true });
    } catch {
      updatePendingMuscleState(exerciseId, {
        saving: false,
        error: "Failed to save muscles.",
      });
    }
  };

  const handleApprove = async (exerciseId: number) => {
    try {
      await approveExercise(exerciseId);
      setPending((prev) => prev.filter((e) => e.id !== exerciseId));
      setPendingMuscleState((prev) => {
        const next = { ...prev };
        delete next[exerciseId];
        return next;
      });
    } catch {
      setPendingError("Failed to approve exercise.");
    }
  };

  const handleReject = async (exerciseId: number) => {
    try {
      await rejectExercise(exerciseId);
      setPending((prev) => prev.filter((e) => e.id !== exerciseId));
      setPendingMuscleState((prev) => {
        const next = { ...prev };
        delete next[exerciseId];
        return next;
      });
    } catch {
      setPendingError("Failed to reject exercise.");
    }
  };

  // --- Pending muscle handlers ---
  const getMuscleUploadState = (muscleId: number): MuscleUploadState =>
    muscleUploadState[muscleId] ?? {
      file: null,
      uploading: false,
      uploaded: false,
      error: "",
    };

  const updateMuscleUploadState = (
    muscleId: number,
    patch: Partial<MuscleUploadState>,
  ) => {
    setMuscleUploadState((prev) => ({
      ...prev,
      [muscleId]: { ...getMuscleUploadState(muscleId), ...patch },
    }));
  };

  const handleMuscleFileChange = (muscleId: number, file: File | null) => {
    updateMuscleUploadState(muscleId, { file, uploaded: false, error: "" });
  };

  const handleMuscleImageUpload = async (muscleId: number) => {
    const state = getMuscleUploadState(muscleId);
    if (!state.file) return;
    updateMuscleUploadState(muscleId, { uploading: true, error: "" });
    try {
      await uploadMuscleImage(muscleId, state.file);
      updateMuscleUploadState(muscleId, { uploading: false, uploaded: true });
    } catch {
      updateMuscleUploadState(muscleId, {
        uploading: false,
        error: "Upload failed. Please try again.",
      });
    }
  };

  const handleApproveMuscle = async (muscleId: number) => {
    try {
      await approveMuscle(muscleId);
      setPendingMuscles((prev) => prev.filter((m) => m.id !== muscleId));
      setMuscleUploadState((prev) => {
        const next = { ...prev };
        delete next[muscleId];
        return next;
      });
    } catch {
      setPendingMusclesError("Failed to approve muscle.");
    }
  };

  const handleRejectMuscle = async (muscle: PendingMuscle) => {
    if (!confirm(`Reject and delete "${muscle.name}"? This cannot be undone.`))
      return;
    try {
      await deletePendingMuscle(muscle.id);
      setPendingMuscles((prev) => prev.filter((m) => m.id !== muscle.id));
      setMuscleUploadState((prev) => {
        const next = { ...prev };
        delete next[muscle.id];
        return next;
      });
    } catch {
      setPendingMusclesError("Failed to reject muscle.");
    }
  };

  // --- Library edit handlers (unchanged) ---
  const handleEditOpen = (exercise: AdminExercise) => {
    setEditingExercise(exercise);
    setEditName(exercise.name);
    setEditCategory(exercise.category);
    setEditVideoUrl(exercise.videoUrl ?? "");
    setEditMuscles(
      exercise.muscles.map((m) => ({
        muscleId: m.muscleId,
        muscleName: m.muscleName,
        isPrimary: m.isPrimary,
      })),
    );
    setEditSaved(false);
    setEditError("");
  };

  const handleEditClose = () => {
    setEditingExercise(null);
    setEditSaved(false);
    setEditError("");
  };

  const handleRemoveMuscle = (muscleId: number) => {
    setEditMuscles((prev) => prev.filter((m) => m.muscleId !== muscleId));
  };

  const handleTogglePrimary = (muscleId: number) => {
    setEditMuscles((prev) =>
      prev.map((m) =>
        m.muscleId === muscleId ? { ...m, isPrimary: !m.isPrimary } : m,
      ),
    );
  };

  const handleEditSave = async () => {
    if (!editingExercise) return;
    if (!editName.trim()) {
      setEditError("Name cannot be empty.");
      return;
    }
    if (!editCategory) {
      setEditError("Please select a category.");
      return;
    }

    setEditSaving(true);
    setEditError("");
    setEditSaved(false);
    try {
      await updateExercise(editingExercise.id, {
        name: editName.trim(),
        category: editCategory,
        videoUrl: editVideoUrl.trim() || null,
      });
      await assignMuscles(
        editingExercise.id,
        editMuscles.map((m) => ({
          muscleId: m.muscleId,
          isPrimary: m.isPrimary,
        })),
      );
      setLibrary((prev) =>
        prev.map((e) =>
          e.id === editingExercise.id
            ? {
                ...e,
                name: editName.trim(),
                category: editCategory,
                videoUrl: editVideoUrl.trim() || null,
                muscles: editMuscles.map((m) => ({
                  muscleId: m.muscleId,
                  muscleName: m.muscleName,
                  muscleGroup: "",
                  isPrimary: m.isPrimary,
                })),
              }
            : e,
        ),
      );
      setEditSaved(true);
    } catch {
      setEditError("Failed to save changes. Please try again.");
    } finally {
      setEditSaving(false);
    }
  };
  //
  const handleAddMuscle = async () => {
    if (!newMuscleName.trim()) {
      setMuscleFormError("Name is required.");
      return;
    }
    setMuscleFormSaving(true);
    setMuscleFormError("");
    setMuscleFormSaved(false);
    try {
      const created = await addMuscle({
        name: newMuscleName.trim(),
        muscleGroup: newMuscleGroup,
        imageUrl: newMuscleImageUrl.trim() || null,
      });
      setAllMuscles((prev) => [...prev, created]);
      setNewMuscleName("");
      setNewMuscleImageUrl("");
      setMuscleFormSaved(true);
    } catch {
      setMuscleFormError("Failed to add muscle. Please try again.");
    } finally {
      setMuscleFormSaving(false);
    }
  };

  const handleDeleteExercise = async (exercise: AdminExercise) => {
    if (
      !confirm(
        `Delete "${exercise.name}" from the library? This cannot be undone.`,
      )
    )
      return;
    try {
      await deleteExercise(exercise.id);
      setLibrary((prev) => prev.filter((e) => e.id !== exercise.id));
      handleEditClose();
    } catch {
      setEditError("Failed to delete exercise. Please try again.");
    }
  };

  const filteredLibrary = library.filter(
    (e) =>
      e.name.toLowerCase().includes(search.toLowerCase()) ||
      e.category.toLowerCase().includes(search.toLowerCase()),
  );

  // --- Edit view ---
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
              onChange={(e) => setEditName(e.target.value)}
            />
          </label>
        </div>
        <div>
          <label>
            Category
            <select
              value={editCategory}
              onChange={(e) => setEditCategory(e.target.value)}
            >
              {CATEGORIES.map((c) => (
                <option key={c} value={c}>
                  {c}
                </option>
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
              onChange={(e) => setEditVideoUrl(e.target.value)}
              placeholder="https://youtube.com/watch?v=..."
            />
          </label>
        </div>
        <div>
          <h2>Muscle Assignments</h2>
          {editMuscles.length === 0 ? (
            <p>No muscles assigned yet.</p>
          ) : (
            editMuscles.map((m) => (
              <div key={m.muscleId}>
                <span>{m.muscleName}</span>
                <button onClick={() => handleTogglePrimary(m.muscleId)}>
                  {m.isPrimary ? "Primary" : "Secondary"}
                </button>
                <button onClick={() => handleRemoveMuscle(m.muscleId)}>
                  Remove
                </button>
              </div>
            ))
          )}
          <div>
            <select
              value={selectedMuscleId}
              onChange={(e) => setSelectedMuscleId(Number(e.target.value))}
            >
              {allMuscles.map((m) => (
                <option key={m.id} value={m.id}>
                  {m.name} ({m.muscleGroup})
                </option>
              ))}
            </select>
            <select
              value={selectedMuscleIsPrimary ? "primary" : "secondary"}
              onChange={(e) =>
                setSelectedMuscleIsPrimary(e.target.value === "primary")
              }
            >
              <option value="primary">Primary</option>
              <option value="secondary">Secondary</option>
            </select>
            <button
              onClick={() => {
                if (!selectedMuscleId) return;
                if (editMuscles.some((m) => m.muscleId === selectedMuscleId))
                  return;
                const muscle = allMuscles.find(
                  (m) => m.id === selectedMuscleId,
                );
                if (!muscle) return;
                setEditMuscles((prev) => [
                  ...prev,
                  {
                    muscleId: muscle.id,
                    muscleName: muscle.name,
                    isPrimary: selectedMuscleIsPrimary,
                  },
                ]);
              }}
            >
              Add Muscle
            </button>
          </div>
        </div>
        {editSaved && <p>Changes saved!</p>}
        {editError && <p>{editError}</p>}
        <button onClick={handleEditSave} disabled={editSaving}>
          {editSaving ? "Saving..." : "Save Changes"}
        </button>
        <button onClick={handleEditClose}>Cancel</button>
        <button
          onClick={() => handleDeleteExercise(editingExercise)}
          disabled={editSaving}
          style={{ color: "red" }}
        >
          Delete Exercise
        </button>
      </div>
    );
  }

  // --- Default view ---
  return (
    <div>
      <h1>Exercises</h1>
      <div>
        <button onClick={() => setActiveTab("library")}>
          Exercise Library
        </button>
        <button onClick={() => setActiveTab("pending")}>
          Pending Exercises {pending.length > 0 && `(${pending.length})`}
        </button>
        <button onClick={() => setActiveTab("pendingMuscles")}>
          Pending Muscles{" "}
          {pendingMuscles.length > 0 && `(${pendingMuscles.length})`}
        </button>
        <button onClick={() => setActiveTab("muscles")}>Add Muscle</button>
      </div>

      {activeTab === "pending" && (
        <div>
          {pendingLoading && <p>Loading...</p>}
          {pendingError && <p>{pendingError}</p>}
          {!pendingLoading && !pendingError && pending.length === 0 && (
            <p>No pending exercises — you're all caught up.</p>
          )}
          {!pendingLoading &&
            !pendingError &&
            pending.length > 0 &&
            pending.map((ex) => {
              const muscleState = getOrInitPendingMuscleState(ex.id);
              const isExpanded = expandedMusclePanel === ex.id;
              return (
                <div
                  key={ex.id}
                  id={`pending-exercise-card-${ex.id}`}
                  style={{
                    border: "1px solid #444",
                    padding: "1rem",
                    marginBottom: "1rem",
                  }}
                >
                  <div
                    style={{
                      display: "flex",
                      gap: "1rem",
                      alignItems: "center",
                      flexWrap: "wrap",
                    }}
                  >
                    <strong>{ex.name}</strong>
                    <span>{ex.category}</span>
                    <span>by {ex.submittedByUsername ?? "Unknown"}</span>
                    <span>{new Date(ex.createdAt).toLocaleDateString()}</span>
                    <button
                      id={`toggle-muscles-${ex.id}`}
                      onClick={() => handleToggleMusclePanel(ex.id)}
                    >
                      {isExpanded ? "Hide Muscles ▲" : "Assign Muscles ▼"}
                    </button>
                    <button
                      id={`approve-exercise-${ex.id}`}
                      onClick={() => handleApprove(ex.id)}
                    >
                      Approve
                    </button>
                    <button
                      id={`reject-exercise-${ex.id}`}
                      onClick={() => handleReject(ex.id)}
                      style={{ color: "#e74c3c" }}
                    >
                      Reject
                    </button>
                  </div>

                  {isExpanded && (
                    <div
                      id={`muscle-panel-${ex.id}`}
                      style={{
                        marginTop: "0.75rem",
                        paddingTop: "0.75rem",
                        borderTop: "1px solid #555",
                      }}
                    >
                      {muscleState.assignments.length === 0 ? (
                        <p>No muscles assigned yet.</p>
                      ) : (
                        muscleState.assignments.map((m) => (
                          <div
                            key={m.muscleId}
                            style={{
                              display: "flex",
                              gap: "0.5rem",
                              alignItems: "center",
                              marginBottom: "0.25rem",
                            }}
                          >
                            <span>{m.muscleName}</span>
                            <button
                              onClick={() =>
                                handlePendingTogglePrimary(ex.id, m.muscleId)
                              }
                            >
                              {m.isPrimary ? "Primary" : "Secondary"}
                            </button>
                            <button
                              onClick={() =>
                                handlePendingRemoveMuscle(ex.id, m.muscleId)
                              }
                            >
                              Remove
                            </button>
                          </div>
                        ))
                      )}

                      <div
                        style={{
                          display: "flex",
                          gap: "0.5rem",
                          marginTop: "0.5rem",
                          flexWrap: "wrap",
                        }}
                      >
                        <select
                          value={muscleState.selectedMuscleId}
                          onChange={(e) =>
                            updatePendingMuscleState(ex.id, {
                              selectedMuscleId: Number(e.target.value),
                            })
                          }
                        >
                          {allMuscles.map((m) => (
                            <option key={m.id} value={m.id}>
                              {m.name} ({m.muscleGroup})
                            </option>
                          ))}
                        </select>
                        <select
                          value={
                            muscleState.selectedIsPrimary
                              ? "primary"
                              : "secondary"
                          }
                          onChange={(e) =>
                            updatePendingMuscleState(ex.id, {
                              selectedIsPrimary: e.target.value === "primary",
                            })
                          }
                        >
                          <option value="primary">Primary</option>
                          <option value="secondary">Secondary</option>
                        </select>
                        <button onClick={() => handlePendingAddMuscle(ex.id)}>
                          Add
                        </button>
                      </div>

                      {muscleState.saved && <p>Muscles saved.</p>}
                      {muscleState.error && <p>{muscleState.error}</p>}

                      <button
                        id={`save-muscles-${ex.id}`}
                        onClick={() => handlePendingSaveMuscles(ex.id)}
                        disabled={muscleState.saving}
                        style={{ marginTop: "0.5rem" }}
                      >
                        {muscleState.saving ? "Saving..." : "Save Muscles"}
                      </button>
                    </div>
                  )}
                </div>
              );
            })}
        </div>
      )}

      {activeTab === "library" && (
        <div>
          <input
            type="text"
            placeholder="Search by name or category..."
            value={search}
            onChange={(e) => setSearch(e.target.value)}
          />
          <p>
            {filteredLibrary.length} exercise
            {filteredLibrary.length !== 1 ? "s" : ""} found
          </p>
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
                {filteredLibrary.map((ex) => (
                  <tr key={ex.id}>
                    <td>{ex.name}</td>
                    <td>{ex.category}</td>
                    <td>{ex.isApproved ? "Approved" : "Pending"}</td>
                    <td>
                      {ex.muscles.length === 0
                        ? "None assigned"
                        : ex.muscles
                            .map(
                              (m) =>
                                `${m.muscleName}${m.isPrimary ? " (primary)" : ""}`,
                            )
                            .join(", ")}
                    </td>
                    <td>{ex.videoUrl ? "✓ Set" : "Not set"}</td>
                    <td>
                      <button onClick={() => handleEditOpen(ex)}>Edit</button>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          )}
        </div>
      )}
      {activeTab === "pendingMuscles" && (
        <div>
          {pendingMusclesLoading && <p>Loading...</p>}
          {pendingMusclesError && <p>{pendingMusclesError}</p>}
          {!pendingMusclesLoading &&
            !pendingMusclesError &&
            pendingMuscles.length === 0 && (
              <p>No pending muscles — you're all caught up.</p>
            )}
          {!pendingMusclesLoading &&
            !pendingMusclesError &&
            pendingMuscles.map((muscle) => {
              const upload = getMuscleUploadState(muscle.id);
              return (
                <div
                  key={muscle.id}
                  style={{
                    border: "1px solid #444",
                    padding: "1rem",
                    marginBottom: "1rem",
                  }}
                >
                  <div
                    style={{
                      display: "flex",
                      gap: "1rem",
                      alignItems: "center",
                      flexWrap: "wrap",
                    }}
                  >
                    <strong>{muscle.name}</strong>
                    <span>{muscle.muscleGroup}</span>
                    <span>by {muscle.submittedByUsername ?? "Unknown"}</span>
                    <span>
                      {new Date(muscle.createdAt).toLocaleDateString()}
                    </span>
                  </div>

                  <div
                    style={{
                      marginTop: "0.75rem",
                      display: "flex",
                      gap: "0.5rem",
                      alignItems: "center",
                      flexWrap: "wrap",
                    }}
                  >
                    <input
                      type="file"
                      accept="image/*"
                      onChange={(e) =>
                        handleMuscleFileChange(
                          muscle.id,
                          e.target.files?.[0] ?? null,
                        )
                      }
                    />
                    <button
                      onClick={() => handleMuscleImageUpload(muscle.id)}
                      disabled={!upload.file || upload.uploading}
                    >
                      {upload.uploading ? "Uploading..." : "Upload Image"}
                    </button>
                    {upload.uploaded && (
                      <span style={{ color: "#2ecc71" }}>✓ Image uploaded</span>
                    )}
                    {upload.error && (
                      <span style={{ color: "#e74c3c" }}>{upload.error}</span>
                    )}
                  </div>

                  <div
                    style={{
                      marginTop: "0.75rem",
                      display: "flex",
                      gap: "0.5rem",
                    }}
                  >
                    <button
                      onClick={() => handleApproveMuscle(muscle.id)}
                      disabled={!upload.uploaded}
                    >
                      Approve
                    </button>
                    <button
                      onClick={() => handleRejectMuscle(muscle)}
                      style={{ color: "#e74c3c" }}
                    >
                      Reject
                    </button>
                  </div>
                </div>
              );
            })}
        </div>
      )}

      {activeTab === "muscles" && (
        <div>
          <h2>Add New Muscle</h2>
          <div>
            <label>
              Name
              <input
                type="text"
                value={newMuscleName}
                onChange={(e) => setNewMuscleName(e.target.value)}
                placeholder="e.g. Upper Chest"
              />
            </label>
          </div>
          <div>
            <label>
              Muscle Group
              <select
                value={newMuscleGroup}
                onChange={(e) => setNewMuscleGroup(e.target.value)}
              >
                {CATEGORIES.map((c) => (
                  <option key={c} value={c}>
                    {c}
                  </option>
                ))}
              </select>
            </label>
          </div>
          <div>
            <label>
              Image URL (optional — paste Azure Blob Storage URL)
              <input
                type="text"
                value={newMuscleImageUrl}
                onChange={(e) => setNewMuscleImageUrl(e.target.value)}
                placeholder="https://azulstoress23u277wpfnw.blob.core.windows.net/muscle-images/..."
              />
            </label>
          </div>
          {muscleFormSaved && <p>Muscle added successfully!</p>}
          {muscleFormError && <p>{muscleFormError}</p>}
          <button onClick={handleAddMuscle} disabled={muscleFormSaving}>
            {muscleFormSaving ? "Adding..." : "Add Muscle"}
          </button>
        </div>
      )}
    </div>
  );
}
