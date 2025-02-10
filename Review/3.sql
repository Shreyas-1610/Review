CREATE TABLE Products(
ProductId INT,
ProductName VARCHAR(20),
Price DECIMAL(10,2),
Stock INT);

INSERT INTO Products(ProductId, ProductName, Price, Stock) VALUES
(1, 'Laptop', 40000, 10),
(2, 'Mobile', 25000, 8),
(3, 'Headphone', 3500, 20),
(4, 'Keyboard', 600, 15),
(5, 'Monitor', 2000, 5),
(6, 'Mouse', 400, 3),
(7, 'Printer', 1200, 2);

UPDATE Products SET Price = Price * 1.10;

DELETE FROM Products WHERE Stock < 5;

SELECT * FROM Products;

