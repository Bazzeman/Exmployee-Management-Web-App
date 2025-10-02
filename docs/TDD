# Technical Design Document

## Architecture
The system is a **three-tier architecture**:
- **Frontend (JS)**: Handles UI, login, and dashboard.
- **Backend (.NET C#)**: Provides REST APIs, handles authentication, business logic.
- **Database (SQL)**: Stores user accounts, employee details, pay rates.

## Data Models
**User**
- userId (PK)
- username
- passwordHash
- role (`Employee` | `Employer`)

**Employee**
- employeeId (PK)
- userId (FK to User)
- name
- department
- payRate

## API Endpoints
- `POST /api/auth/login` → login, returns JWT
- `GET /api/employees` → list all employees (employer only)
- `POST /api/employees` → add employee (employer only)
- `GET /api/employees/{id}` → get employee details (employee self or employer)
- `PUT /api/employees/{id}` → update employee (employer only)

## Security
- JWT authentication
- Role-based authorization
- Passwords stored as hashed values
333