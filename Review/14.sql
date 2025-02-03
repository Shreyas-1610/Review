CREATE TABLE Emps (
EmployeeID INT PRIMARY KEY,
Name VARCHAR(255)
);

CREATE TABLE Projects (
ProjectID INT PRIMARY KEY,
EmployeeID INT,
ProjectName VARCHAR(255),
FOREIGN KEY (EmployeeID) REFERENCES Emps(EmployeeID)
);

INSERT INTO Emps (EmployeeID, Name) VALUES
(1, 'Alice'),
(2, 'Bob'),
(3, 'Charlie');

INSERT INTO Projects (ProjectID, EmployeeID, ProjectName) VALUES
(1, 1, 'Project A'),
(2, 2, 'Project B');

SELECT p.ProjectID, p.ProjectName, e.Name AS EmployeeName
FROM Emps e
RIGHT JOIN Projects p ON e.EmployeeID = p.EmployeeID;