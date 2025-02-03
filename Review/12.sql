CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(255)
);

CREATE TABLE Orderr (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    Amount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

INSERT INTO Customer (CustomerID, Name) VALUES
(1, 'ABC'),
(2, 'BCD'),
(3, 'CDE');

INSERT INTO Orderr (OrderID, CustomerID, OrderDate, Amount) VALUES
(101, 1, '2023-10-26', 100.00),
(102, 2, '2023-10-27', 50.00),
(103, 1, '2023-10-28', 75.00),
(104, 2, '2023-10-29', 25.00); 

SELECT o.OrderID, c.Name AS CustomerName, o.OrderDate, o.Amount
FROM Orderr o
INNER JOIN Customer c ON o.CustomerID = c.CustomerID;