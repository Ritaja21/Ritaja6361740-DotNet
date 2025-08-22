# Cognizant DeepSkilling Assessment – DotNet Track

This repository contains weekly assignments and assessments completed as part of the **Cognizant DotNet DeepSkilling Program**.

Each week covers hands-on exercises on .NET concepts, object-oriented programming, data structures & algorithms, and real-world application design using C#.

---

## 📁 Folder Structure
```
Ritaja6361740-DotNet/
├── README.md # Main repo overview (this file)
├── week1/ # Design Patterns, SOLID principles, DSA
├── week2/ # Advanced SQL & C# Unit Testing
├── week3/ # Entity Framework Core 8.0
├── week4/ # ASP.NET Core 8.0 Web API
├── week5/ # Microservices Architecture using ASP.NET Core Web API
├── week6/ # Understanding React
├── week7/ # ReactJS
└── week8/ # GIT
> Each `weekN/` folder contains separate C# console projects as per the weekly assessment tasks.
```

## 📚 Week 1 Summary

In **Week 1**, I explored the following:

-  **Object-Oriented Design Patterns**: Singleton & Factory Method
-  **SOLID Principles**: Applied foundational principles of clean code
-  **Algorithms**: Implemented and analyzed Linear Search, Binary Search, and Recursive Logic

Projects are organized as standalone console applications inside the `week1/` folder.

---

## 📚 Week 2 Summary  
In **Week 2**, I explored the following:

-  **Advanced SQL Concepts:** Used `ROW_NUMBER()`, `RANK()`, and `DENSE_RANK()` with `PARTITION BY` to rank data and handle ties within categories.

-  **Stored Procedures in SQL Server:** Created and executed stored procedures to insert employee records and return the total count of employees per department using input parameters.

-  **Unit Testing with NUnit:** Wrote structured unit tests for a basic calculator using `[TestFixture]`, `[SetUp]`, and `[TestCase]` attributes.

-  **Mocking with Moq:** Simulated external dependencies like email sending using the Moq library and dependency injection, ensuring isolated and testable code.

Projects and outputs are organized under the `week2/` folder.

---
## 📚 Week 3 Summary  
In **Week 3**, I focused on applying **Entity Framework (EF) Core** to implement Object-Relational Mapping (ORM) in a real-world retail inventory scenario using SQL Server and C#.

-  **ORM with EF Core:** Learned how ORM bridges the gap between relational tables and C# classes. Created `Product` and `Category` models and mapped them to SQL tables using EF Core.

-  **DbContext & Connection Setup:** Configured `AppDbContext` with `UseSqlServer()` to connect to the SQL Server database. Defined `DbSet<Product>` and `DbSet<Category>` for database operations.

-  **EF Core CLI & Migrations:** Used `dotnet ef migrations add` and `dotnet ef database update` to generate schema and apply changes to the database.

-  **Async CRUD Operations:** Inserted initial data using `AddRangeAsync()` and `SaveChangesAsync()`, and retrieved data using `ToListAsync()`, `FindAsync()`, and `FirstOrDefaultAsync()` with LINQ.

-  **Validation via SSMS:** Verified that the data was correctly inserted and tables were created by checking SQL Server Management Studio (SSMS).

Projects and outputs are organized under the `week3/` folder.

---
##  📚 Week 4 Summary
-  Built multiple RESTful Web APIs using .NET Core with CRUD operations and action verbs (`GET`, `POST`, `PUT`, `DELETE`)

-  Implemented JWT authentication and role-based access using `[Authorize]` with custom roles

-  Created Custom Filters for authorization and global exception handling

-  Integrated Swagger (OpenAPI) for API documentation and testing

-  Enabled CORS to allow frontend and Postman access to APIs

-  Developed a real-time chat system using Kafka:

   -  KafkaChatAPI: Sends messages to Kafka
   - KafkaChatConsumer: Console app to receive messages
   - KafkaChatClient: WinForms UI to send messages via API

 Organized all outputs and projects under the `week4/` folder
 
 ---

 ## 📚 Week 5 Summary
 In **Week 5**, I explored the following:

- **Authentication & Authorization:** Implemented JWT-based authentication for secure login.

- **Role-Based Access Control:** Applied `[Authorize(Roles = "Admin")]` to protect admin-specific endpoints.

- **Token Management:** Configured token expiry and added custom handling for expired or invalid tokens.

- **API Security:** Secured endpoints with `[Authorize]` and tested using Postman and Swagger.

 Projects are organized as standalone Web API microservices inside the `week5/` folder.

--- 

## 📚 Week 6 Summary
In Week 6, I explored the following:

- **React Fundamentals:** Understood the basics of React, including JSX syntax, virtual DOM, and the concept of component-based architecture.

- **Component Creation:** Built multiple React apps using both functional and class components to understand their structure and use cases.

- **Props and State:** Passed data between components using props, and managed internal data using state.

- **Lifecycle Methods:** Implemented lifecycle methods like `componentDidMount` and `componentWillUnmount` in class components to understand rendering phases.

- **SPA vs MPA:** Studied the differences between Single Page and Multi Page Applications and how React enables SPA behavior through client-side routing.

Projects are organized as standalone React apps inside the `week6/` folder.

---

## 📚 Week 7 Summary

In Week 7, I explored the following:

- **JSX and DOM Rendering:** Practiced using JSX to define UI structure and understood how it's compiled to `React.createElement()` for rendering virtual DOM elements.

- **Event Handling in React:** Implemented event handlers using React’s synthetic event system and practiced handling user interactions like button clicks.

- **Conditional Rendering:** Applied various conditional rendering techniques including `if-else`, ternary operators, short-circuiting, and element variables to control what components appear on the screen.

- **List Rendering with `map()` and Keys:** Created reusable components that render lists using `map()`, while applying the key prop correctly to ensure efficient updates.

- **Component Reusability:** Structured the app using multiple reusable components to reinforce modular design and separation of concerns.

- **ES6 Features in Practice:** Strengthened knowledge of `let`, `const`, arrow functions, classes, destructuring, and map/set usage within React apps.

Projects are organized as standalone React apps inside the `week7/` folder.

---
## 📚 Week 8 Summary
In Week 8, I explored the following:

- **Git Configuration and Setup:** Configured Git on the local machine, integrated Notepad++ as the default editor, and practiced adding files to a repository.

- **Using `.gitignore`:** Learned how to ignore unwanted files and folders to keep the repository clean and organized.

- **Branching and Merging:** Created branches, made changes, and merged them with the master branch, understanding the workflow of branching in collaborative development.

- **Conflict Resolution:** Practiced handling merge conflicts when multiple users modify the same files and resolved conflicts manually to maintain code integrity.

- **Syncing with Remote Repository:** Pulled changes from the remote repository, committed local changes, and pushed them back to ensure synchronization between local and remote repositories.

Projects are organized as standalone Git hands-on assignments inside the `week8/` folder, with outputs stored in each assignment folder under `outputs/`.

## 👩‍💻 Author

**Ritaja Tarafder**  
GitHub: [@Ritaja21](https://github.com/Ritaja21)

---

>This repository contains all the completed weekly assignments as part of the Cognizant DeepSkilling Program.
