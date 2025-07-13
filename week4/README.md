# Week 4 Assignment: ASP.NET Core 8.0 WebAPI
This repository contains a collection of .NET Core Web API hands-on assignments focused on RESTful services, Swagger integration, JWT authentication, Kafka messaging, and client-server communication using Windows Forms.

---

## Project Overview
This repository covers a wide range of Web API concepts using .NET Core, with hands-on assignments that help understand and implement core features of modern APIs.

### Key Concepts Explained
🔹 RESTful Web Services
- Based on the Representational State Transfer (REST) architecture, RESTful APIs are stateless, use standard HTTP verbs (GET, POST, PUT, DELETE), and work with resources represented in JSON/XML. They allow decoupled communication using URLs and messages.

🔹Web API vs Web Service

 - Web Service: XML-based, SOAP protocol, tightly coupled
 - Web API: Lightweight, JSON/REST-based, loosely coupled
 - Web API is not restricted to XML — it can return JSON, plain text, or even custom formats.

🔹Microservices
- Microservices are independently deployable, loosely coupled services. Each service handles one business feature and communicates over HTTP/REST or messaging systems (like Kafka).

🔹 HttpRequest & HttpResponse

- `HttpRequest`: Represents the incoming request from the client (method, headers, body, etc.)

- `HttpResponse`: Represents the response sent back (status code, headers, result)

🔹 Action Verbs in Web API

- `HttpGet`: Retrieve data

- `HttpPost`: Create data

- `HttpPut`: Update data

- `HttpDelete`: Remove data

These are mapped to controller methods using attributes like `[HttpGet]`.

🔹 Common HTTP Status Codes

- `200 OK`: Request succeeded

- `400 BadRequest`: Malformed request

- `401 Unauthorized`: Token/credentials missing or invalid

- `500 InternalServerError`: Unhandled error

🔹 Structure of a Simple Web API

- Uses **Controllers** inheriting from `ControllerBase` or `ApiController`

- Methods are decorated with `[HttpGet]`, `[HttpPost]`, etc.

- Follows a clean route structure: `api/controller/action`

🔹Configuration Files

- `Program.cs`: App startup entry

- `Startup.cs`: Service registration & middleware pipeline

- `appsettings.json`: App config like JWT keys, DB strings

- `launchSettings.json`: Debug profile & port settings

- `Web.config / Route.config` (used in .NET Framework, not .NET Core): Traditional config for routing and services

🔹CORS (Cross-Origin Resource Sharing)

CORS allows a frontend (like React/Angular) to access **Web API from another origin (port/domain)**.
To enable:
```
csharp

services.AddCors(options => {
    options.AddPolicy("AllowAll", builder => 
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

app.UseCors("AllowAll");
```
🔹JWT Authentication

Secure your API using JWT (JSON Web Token).

- `AuthController` generates tokens with claims and roles

- `Authorize` attribute restricts access based on roles

- `Startup.cs` uses `AddAuthentication()` and `AddJwtBearer()` to validate incoming tokens

### Topics Covered

| Folder              | Description                                                                |
| ------------------- | -------------------------------------------------------------------------- |
| `FirstWebAPI`       | Basic Web API with GET/POST/PUT/DELETE using controller                    |
| `SwaggerDemoAPI`    | Swagger UI setup and API documentation hands-on                            |
| `EmployeeCustomAPI` | Custom model classes, filters (auth & exception), and attribute-based APIs |
| `JWTAuthAPI`        | JWT generation, claim setup, and role-based API access                     |
| `KafkaChatAPI`      | Kafka producer API to send chat messages                                   |
| `KafkaChatConsumer` | Kafka consumer console app to receive and display messages                 |
| `KafkaChatClient`   | Windows Forms app to send chat messages via API                            |
---

## Technologies Used

- .NET 6/ .NET Core
- C#
- Kafka (Apache Kafka for messaging)
- Swagger / Swashbuckle
- JWT (JSON Web Tokens)
- Windows Forms (WinForms)
- Postman (API Testing)
- Visual Studio Code / Visual Studio

---

## Key Learning Outcomes
- Creating robust REST APIs with proper routing and attributes

- Integrating Swagger for developer-friendly UI & testing

- Implementing security using JWT Bearer tokens

- Building custom action/exception filters

- Understanding Kafka messaging system & integration with .NET

- Consuming APIs from WinForms app using `HttpClient`
---
## Folder Structure

```
week4/
├── FirstWebAPI/  # WebAPI 1 – CRUD
├── SwaggerDemoAPI/ # WebAPI 2 –   Swagger Integration
├── EmployeeCustomAPI/  # WebAPI 3 & 4 – Custom Models & Filters
├── JWTAuthAPI/   # WebAPI 5 – JWT Auth & Role Validation
├── KafkaChatAPI/ # WebAPI 6 – Kafka Producer
├── KafkaChatConsumer/ # Kafka Consumer (Console App)
├── KafkaChatClient/  # Kafka Chat Client (WinForms UI)
└── README.md  # Project overview and explanation
```

---
## Outputs 
> Screenshots for Swagger, Postman, Console, and WinForms GUI are placed inside their respective folders (e.g., KafkaChatClient/outputs/, etc.)