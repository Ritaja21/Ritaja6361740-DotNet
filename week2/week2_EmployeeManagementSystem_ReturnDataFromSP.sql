--creating store procedure to count the number of employees by department id
CREATE PROCEDURE sp_GetEmployeeCountByDepartment 
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
--testing the procedure
EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 2;
