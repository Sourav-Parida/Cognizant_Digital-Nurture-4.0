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


EXEC sp_InsertEmployee 
    @FirstName = 'Sourav', 
    @LastName = 'Parida', 
    @DepartmentID = 2, 
    @Salary = 6200.00, 
    @JoinDate = '2022-05-10';

--DROP PROCEDURE sp_InsertEmployee;
