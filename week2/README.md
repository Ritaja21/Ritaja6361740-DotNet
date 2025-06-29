# 📘 Week 2 Assignment: Advanced SQL & C# Unit Testing

This repository contains solutions for advanced SQL exercises and C# unit testing using NUnit and Moq. Each section demonstrates practical implementations and output verification to strengthen concepts of testable design, mocking, and database procedures.

---

## ✅ Project Overview

### 🟡 SQL – Advanced Concepts

#### 🔹 Ranking and Window Functions
- Learned to use `ROW_NUMBER()`, `RANK()`, and `DENSE_RANK()` with `PARTITION BY` and `ORDER BY`.
- Extracted the top 3 most expensive products in each category using window functions.
- Understood the differences in how `RANK()` and `DENSE_RANK()` handle ties.

#### 🔹 Stored Procedures in SQL Server
- Created a stored procedure to insert employee details with department linkage.
- Built a stored procedure to count employees by department, using `@DepartmentID` as a parameter.
- Executed and verified these procedures inside SQL Server Management Studio (SSMS).

---

### 🔵 C# – Unit Testing and Mocking

#### 🔹 NUnit Testing with Calculator
- Wrote a unit test for a basic Calculator class using NUnit.
- Learned to use `[TestFixture]`, `[Test]`, `[SetUp]`, and `[TestCase]` attributes for structured test development.

#### 🔹 Mocking with Moq
- Understood the concept of mocking external dependencies using Moq (e.g., fake mail sender).
- Implemented dependency injection via constructor for `CustomerComm` to allow isolated testing.
- Validated behavior of `SendMailToCustomer()` without actually sending emails by mocking `IMailSender`.

---
## 📁 Folder Structure

```

week2/
├── RankingFunctions.sql
├── StoredProcedure_InsertEmployee.sql
├── StoredProcedure_EmployeeCount.sql
│
├── CalculatorSolution/
│ ├── CustomerCommLib/
│ └── CustomerComm.Tests/
│
├── MockMailTest/
│ ├── CustomerCommLib/
│ └── CustomerComm.Tests/
│
├── outputs/
│ └── (Screenshots or result logs for SQL queries and unit tests)

```
---

## 📂 Outputs

> All execution results and screenshots for SQL queries and C# test outputs are added in the `outputs/` folder for review.

---

## 🛠️ Tools & Technologies

- SQL Server Management Studio (SSMS)
- .NET 6 SDK
- Visual Studio Code
- Moq
- NUnit
- Git & GitHub
