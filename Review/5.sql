CREATE TABLE Departments (
DepartmentID INT PRIMARY KEY,
DepartmentName VARCHAR(100) NOT NULL
);

CREATE TABLE Emp (
    EmpID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID) 
);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance');

INSERT INTO Emp (EmpID, Name, DepartmentID) VALUES
(101, 'ABC', 1),
(102, 'BCD', 2),
(103, 'CDE', 3);

INSERT INTO Emp (EmpID, Name, DepartmentID) VALUES
(104,'Shreyas',5); --invalid no dept 5
