--create department table
CREATE TABLE Departments (
  DepartmentID INT PRIMARY KEY,
  DepartmentName VARCHAR(100)
);
--create employees table
CREATE TABLE Employees (
   EmployeeID INT PRIMARY KEY IDENTITY(1,1),
   FirstName VARCHAR(50),
   LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
   Salary DECIMAL(10,2),
   JoinDate DATE
);
--Insert data into Departments table
INSERT INTO Departments (DepartmentID,DepartmentName) VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT'),
(4,'Marketing');
--Insert into Employees table
INSERT INTO Employees (FirstName,LastName,DepartmentID,Salary,JoinDate) VALUES
('John','Doe',1,5000.00,'2020-01-15'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22'),
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
('Emily', 'Davis', 4, 5500.00, '2021-11-05');
--create store procedure using parameter Departmentid
CREATE PROCEDURE sp_GetEmployeesByDepartment 
 @DepartmentID INT
 AS
BEGIN
  SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
  FROM Employees
  WHERE DepartmentID = @DepartmentID;
END;
EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;
--creating sp_InsertEmployee 
CREATE PROCEDURE sp_InsertEmployee
 @FirstName VARCHAR(50),
 @LastName VARCHAR(50),
 @DepartmentID INT,
 @Salary DECIMAL(10,2),
 @JoinDate DATE
AS
BEGIN
 INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
 VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
--inserting data in sp_InsertEmployee
EXEC sp_InsertEmployee
 @FirstName = 'Ravi',
 @LastName = 'Kumar',
 @DepartmentID = 2,
 @Salary = 6200.00,
 @JoinDate = '2024-01-10';
 --displaying the full table after inserting new data
SELECT * FROM Employees;
