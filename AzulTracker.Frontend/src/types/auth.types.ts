// Matches RegisterDto in AuthDtos.cs
export interface RegisterRequest {
  username: string;
  email: string;
  password: string;
}

// Matches LoginDto in AuthDtos.cs
export interface LoginRequest {
  email: string;
  password: string;
}

// Matches AuthResponseDto in AuthDtos.cs
export interface AuthResponse {
  token: string;
  username: string;
  email: string;
  role: string;
}

// The user object we store in React state after login
export interface AuthUser {
  username: string;
  email: string;
  role: string;
}