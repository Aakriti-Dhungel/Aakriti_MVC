# Aakriti\_MVC - CRUD Project

## Overview

A basic ASP.NET Core MVC app with CRUD functionality.

---

## Setup

1. **Clone the repository**:

   ```bash
   git clone https://github.com/Aakriti-Dhungel/Aakriti_MVC.git
   cd Aakriti_MVC
   ```

2. **Create `appsettings.json`** from the example:

   ```bash
   cp appsettings.example.json appsettings.json
   ```

3. **Update `appsettings.json`** with your credentials (e.g., database connection string).

---

## Handling Sensitive Data

1. **Store the connection string** using User Secrets:

   ```bash
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "YourConnectionString"
   ```

---

## Running the Application

1. **Restore packages**:

   ```bash
   dotnet restore
   ```

2. **Run the app**:

   ```bash
   dotnet run
   ```

3. Access at: `http://localhost:5000`

---

## Directory Structure

```plaintext
/Aakriti_MVC
    ├── Controllers/
    ├── Models/
    ├── Views/
    ├── uploads/  # User-uploaded images (ignored by Git)
    ├── output/   # Generated files (ignored by Git)
    ├── Program.cs
    ├── appsettings.json  # Sensitive data (ignored by Git)
    ├── .gitignore
    └── README.md
```

---