CREATE TABLE Sales (
SaleID INT PRIMARY KEY,
ProductID INT,
Quantity INT,
SaleDate DATE
);

INSERT INTO Sales (SaleID, ProductID, Quantity, SaleDate) VALUES
(1, 101, 20, '2023-10-26'),
(2, 102, 30, '2023-10-26'),
(3, 101, 15, '2023-10-27'),
(4, 103, 40, '2023-10-27'),
(5, 102, 25, '2023-10-28'),
(6, 101, 10, '2023-10-28'),
(7, 103, 10, '2023-10-29'),
(8, 104, 60, '2023-10-29');

SELECT * FROM Sales;

SELECT ProductID, SUM(Quantity) AS Total
FROM Sales
GROUP BY ProductID;

SELECT ProductID, SUM(Quantity) AS Above50
FROM Sales
GROUP BY ProductID HAVING SUM(Quantity) > 50; 


