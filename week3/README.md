#  Week 3 Assignment: Entity Framework Core with SQL Server

This repository contains the solution for setting up and interacting with a SQL Server database using **Entity Framework (EF) Core** in a `.NET 6` console application. It focuses on implementing a **Retail Inventory System** with core concepts like **ORM**, **DbContext configuration**, **EF Core migrations**, and **async database operations**.

---

##  Project Overview

### 🔹 What is ORM?

**Object-Relational Mapping (ORM)** is a technique that connects database tables with C# classes. With an ORM like Entity Framework Core, you write and manage data access code using C# objects, not raw SQL.

>  Example: A `Product` class in C# maps to a `Products` table in SQL Server. You insert and fetch data using LINQ instead of `INSERT` and `SELECT` statements.

###  Why EF Core?

EF Core is a modern, lightweight, open-source, and cross-platform ORM built by Microsoft. It provides:
- Support for LINQ queries
- Async database operations
- Clean migrations system
- Easy database integration using `DbContext`

---

##  Technologies Used

-  .NET 6 Console Application  
-  Entity Framework Core 8  
-  SQL Server 2022 (with SSMS)  
-  Visual Studio Code  
-  EF CLI for migrations  

---

##  Key Learning Outcomes

###  EF Core Setup & ORM Mapping
- Defined `Product` and `Category` classes with one-to-many relationship.
- Created `AppDbContext` inheriting from `DbContext` and configured with `UseSqlServer`.
- Used `DbSet<T>` to expose tables.

```
public class Category {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}

public class Product {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
```

###  EF Core CLI for Migrations

- Used `dotnet ef migrations add InitialCreate` to generate schema
- Applied schema to the database using `dotnet ef database update`
- Verified the tables `Products` and `Categories` in SQL Server Management Studio (SSMS)

###  Async Data Operations with LINQ
Implemented CRUD-style operations using EF Core async methods

```
await context.Categories.AddRangeAsync(electronics, groceries);
await context.Products.AddRangeAsync(product1, product2);
await context.SaveChangesAsync();

var products = await context.Products.ToListAsync();
var product = await context.Products.FindAsync(1);
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
```

## Folder Structure

```
week3/
└── Q1RetailInventory/
    ├── Models/
    │   ├── Product.cs
    │   └── Category.cs
    ├── Data/
    │   └── AppDbContext.cs
    ├── Migrations/
    │   └── (Auto-generated migration files)
    ├── Program.cs
    └── outputs/
        └── (Screenshots of SQL tables and console output)
```

## Outputs 

> All screenshots from SSMS (tables and inserted data) and console output after `dotnet run` are saved under the `outputs/` folder for verification.