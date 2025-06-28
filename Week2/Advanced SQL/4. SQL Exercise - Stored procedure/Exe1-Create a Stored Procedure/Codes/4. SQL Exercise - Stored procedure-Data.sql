--4. SQL Exercise - Stored procedure

--Database Schema

CREATE TABLE Departments (
    DepartmentID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-increment
    DepartmentName VARCHAR(100)
);


CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-increment
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);

INSERT INTO Departments (DepartmentName) VALUES 
('HR'), 
('Finance'), 
('IT'), 
('Marketing'); 

INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, 
JoinDate) VALUES 
('John', 'Doe', 1, 5000.00, '2020-01-15'), 
('Jane', 'Smith', 2, 6000.00, '2019-03-22'), 
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'), 
('Emily', 'Davis', 4, 5500.00, '2021-11-05'); 

Select * from Departments;
Select * from Employees;

delete from Employees where FirstName = 'Sourav';