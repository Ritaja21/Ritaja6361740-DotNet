# Week 5 Assignment : Microservices Architecture using ASP.NET Core Web API

This assignment focused on building a secure Web API using ASP.NET Core by implementing JWT-based authentication and role-based authorization. It involved generating tokens on successful login, protecting endpoints using `[Authorize]` attributes, and enforcing role-specific access control (e.g., Admin-only endpoints). Additionally, it included logic to handle expired tokens by sending a custom header `(Token-Expired: true)` to the client when the token is no longer valid.

---
## Project Overview

This project demonstrates how to **secure a .NET Core Web API** using **JWT (JSON Web Tokens)**. It implements:

-  **JWT Authentication** to restrict access to endpoints
-  **Role-Based Authorization** for Admin-only access
-  **Token Expiry Handling** with custom error responses
-  `[Authorize]` attribute usage to protect sensitive routes

  The API issues a JWT token during login, validates it on protected routes, and supports role-specific access and expiry handling.

---

##  Technologies Used

- **.NET 6 / .NET Core**
- **C#**
- **ASP.NET Core Web API**
- **JWT (System.IdentityModel.Tokens.Jwt)**
- **Postman** (for API testing)

---

##  Key Learning Outcomes

-  Understand how JWT works in web applications
-  Implement custom claims (roles) in JWT tokens
-  Secure API endpoints with `[Authorize]` and roles
-  Handle expired/invalid tokens gracefully
-  Sync tokens and refresh expiry for better UX

---

## Folder Structure
```
JWTAuthApi/
├── Controllers/
│ ├── AuthController.cs # Handles login and token generation
│ ├── SecureController.cs # Protected endpoint with [Authorize]
│ └── AdminController.cs # Role-based endpoint [Authorize(Roles="Admin")]
│
├── Program.cs # Main config: authentication, authorization, middleware
├── appsettings.json # JWT config: issuer, audience, key, expiry (optional)
├── Models/
│ └── LoginModel.cs #Represents login credentials
├── Properties/
│ └── launchSettings.json # Local dev settings
```
---

## 📤 Outputs / API Endpoints

| Endpoint | Method | Auth Required | Role Required | Description |
|----------|--------|---------------|----------------|-------------|
| `/api/auth/login` | `POST` | ❌ | ❌ | Login and receive JWT token |
| `/api/secure/data` | `GET` | ✅ | ❌ | Protected data for authenticated users |
| `/api/admin/dashboard` | `GET` | ✅ | `Admin` | Admin-only access |
  
  Use the JWT token in headers:  
 `Authorization: Bearer <your-token>`

>Screenshots of Postman is provided under the outputs folder.

---