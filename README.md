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
├── week4/ # (to be added)
├── week5/
├── week6/
├── week7/
└── week8/
> Each `weekN/` folder contains separate C# console projects as per the weekly assessment tasks.
```

## 📚 Week 1 Summary

In **Week 1**, I explored the following:

- 🔹 **Object-Oriented Design Patterns**: Singleton & Factory Method
- 🔹 **SOLID Principles**: Applied foundational principles of clean code
- 🔹 **Algorithms**: Implemented and analyzed Linear Search, Binary Search, and Recursive Logic

Projects are organized as standalone console applications inside the `week1/` folder.

---

## 📚 Week 2 Summary  
In **Week 2**, I explored the following:

- 🔹 **Advanced SQL Concepts:** Used `ROW_NUMBER()`, `RANK()`, and `DENSE_RANK()` with `PARTITION BY` to rank data and handle ties within categories.

- 🔹 **Stored Procedures in SQL Server:** Created and executed stored procedures to insert employee records and return the total count of employees per department using input parameters.

- 🔹 **Unit Testing with NUnit:** Wrote structured unit tests for a basic calculator using `[TestFixture]`, `[SetUp]`, and `[TestCase]` attributes.

- 🔹 **Mocking with Moq:** Simulated external dependencies like email sending using the Moq library and dependency injection, ensuring isolated and testable code.

Projects and outputs are organized under the `week2/` folder.

---
## 📚 Week 3 Summary  
In **Week 3**, I focused on applying **Entity Framework (EF) Core** to implement Object-Relational Mapping (ORM) in a real-world retail inventory scenario using SQL Server and C#.

- 🔹 **ORM with EF Core:** Learned how ORM bridges the gap between relational tables and C# classes. Created `Product` and `Category` models and mapped them to SQL tables using EF Core.

- 🔹 **DbContext & Connection Setup:** Configured `AppDbContext` with `UseSqlServer()` to connect to the SQL Server database. Defined `DbSet<Product>` and `DbSet<Category>` for database operations.

- 🔹 **EF Core CLI & Migrations:** Used `dotnet ef migrations add` and `dotnet ef database update` to generate schema and apply changes to the database.

- 🔹 **Async CRUD Operations:** Inserted initial data using `AddRangeAsync()` and `SaveChangesAsync()`, and retrieved data using `ToListAsync()`, `FindAsync()`, and `FirstOrDefaultAsync()` with LINQ.

- 🔹 **Validation via SSMS:** Verified that the data was correctly inserted and tables were created by checking SQL Server Management Studio (SSMS).

Projects and outputs are organized under the `week3/` folder.

---

## 👩‍💻 Author

**Ritaja Tarafder**  
GitHub: [@Ritaja21](https://github.com/Ritaja21)

---

> This repository will be updated weekly with assessments and solutions as I progress through the Cognizant DeepSkilling Program.
