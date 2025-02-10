CREATE TABLE Employee(
EmployeeId INT NOT NULL PRIMARY KEY,
Name VARCHAR(20),
Age INT,
Salary INT);

INSERT INTO Employee(EmployeeId, Name, Age, Salary) VALUES
(1,'Shreyas',21,40000),
(2,'Kulkarni',21,60000),
(3,'ABC',25,52000),
(4,'XYZ',43,30000),
(5,'Ash',40,45000),
(6,'BCD',27,40000);
SELECT * FROM Employee WHERE Salary > 50000;

SELECT * FROM Employee WHERE Name LIKE 'A%';

SELECT * FROM Employee WHERE Age > 25 AND Age <35;