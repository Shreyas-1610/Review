CREATE TABLE Students (
StudentID INT PRIMARY KEY,
Name VARCHAR(20),
Class VARCHAR(10),
DOB DATE,
Grade CHAR(1)
);

INSERT INTO Students (StudentID, Name, Class, DOB, Grade) VALUES
(1, 'ABC', '9th', '2003-05-15', 'A'),
(2, 'BCD', '10th', '2000-07-22', 'B'),
(3, 'CDE', '9th', '2001-09-10', 'A'),
(4, 'DEF', '10th', '2017-03-18', 'C'),
(5, 'EFG', '9th', '2001-11-25', 'B'),
(6, 'FGH', '10th', '2000-08-30', 'A'),
(7, 'GHI', '9th', '2003-06-14', 'B'),
(8, 'HIJ', '11th', '2006-12-05', 'A'),
(9, 'IJK', '10th', '2007-04-27', 'C'),
(10, 'JKL', '9th', '2008-10-09', 'B');

UPDATE Students SET Grade = 'A' WHERE StudentID = 5;

DELETE FROM Students WHERE Class = '10th';

SELECT * FROM Students;