CREATE TABLE Customers (
CustomerID INT PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
Phone INT
);

--rename
--ALTER TABLE Customers ALTER COLUMN Phone TO ContactNumber; 

ALTER TABLE Customers ALTER COLUMN Phone VARCHAR(15);

