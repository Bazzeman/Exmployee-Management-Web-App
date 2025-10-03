# Technical Design Document

## Architecture
The system is a **three-tier architecture**:
- **Frontend (JS)**: Handles UI, login, and dashboard.
- **Backend (.NET C#)**: Provides REST APIs, handles authentication, business logic.
- **Database (SQL)**: Stores user accounts, employee details, pay rates.

## Data Models
**users** 
- user_id (PK)
- password_hash
- role (`Employee`,`Employer`)
- name
- email
- phone
- creation_timestamp

**employee**
- employee_id (PK)
- user_id (FK)
- department (`ICT`,`HR`, `Engineering`)
- position
- pay_rate

**audit_logs**
- log_id (PK)
- employer_id (FK)
- action (e.g. `ADD_EMPLOYEE`, `UPDATE_PAYRATE`)
- employee_id (FK)
- timestamp

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