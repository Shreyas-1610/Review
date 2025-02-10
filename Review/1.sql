CREATE DATABASE Review;
USE Review;

CREATE TABLE Employees(
EmployeeId INT NOT NULL PRIMARY KEY,
Name VARCHAR(20),
Age INT,
Department VARCHAR(10),
Salary INT);

INSERT INTO Employees(EmployeeId, Name, Age, Department, Salary) VALUES
(1,'Shreyas',21,'Dev',4),
(2,'Kulkarni',21,'Dev',6),
(3,'ABC',25,'HR',5),
(4,'XYZ',23,'Finance',3),
(5,'John Doe',40,'HR',5);

UPDATE Employees SET Salary = 8 WHERE EmployeeId = 3;

DELETE FROM Employees WHERE Name = 'John Doe';

SELECT * FROM Employees;