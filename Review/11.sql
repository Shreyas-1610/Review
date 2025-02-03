CREATE TABLE Orders (
OrderID INT PRIMARY KEY,
CustomerID INT,
OrderAmount DECIMAL(10, 2),
OrderDate DATE
);

INSERT INTO Orders (OrderID, CustomerID, OrderAmount, OrderDate) VALUES
(1, 101, 150.00, '2023-10-26'),
(2, 102, 50.00, '2023-10-27'),
(3, 101, 200.00, '2023-10-28'),
(4, 103, 75.00, '2023-10-29'),
(5, 102, 125.00, '2023-10-30'),
(6, 101, 300.00, '2023-10-31'),
(7, 104, 100.00, '2023-11-01'),
(8, 103, 25.00, '2023-11-02'),
(9, 105, 175.00, '2023-11-03'),
(10, 101, 500.00, '2023-11-04');

SELECT * FROM Orders
ORDER BY OrderAmount DESC;

SELECT TOP 5 * FROM Orders
ORDER BY OrderDate DESC;

