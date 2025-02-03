CREATE TABLE Product(
Price INT CHECK(Price > 0));

INSERT INTO Product(Price) VALUES
(10),
(-1); --invalid