CREATE TABLE Prod (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255)
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (ProductID) REFERENCES Prod(ProductID)
);

INSERT INTO Prod (ProductID, ProductName) VALUES
(1, 'Laptop'),
(2, 'Mouse'),
(3, 'Keyboard');

INSERT INTO OrderDetails (OrderDetailID, ProductID, Quantity) VALUES
(1, 1, 2),
(2, 2, 5),
(3, 1, 1);

SELECT p.ProductID, p.ProductName, o.Quantity
FROM Prod p
LEFT JOIN OrderDetails o ON p.ProductID = o.ProductID;
