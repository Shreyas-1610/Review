CREATE TABLE Books (
BookID INT PRIMARY KEY,
Title VARCHAR(50),
Author VARCHAR(20) 
);

ALTER TABLE Books ADD PublicationYear INT;

ALTER TABLE Books ALTER COLUMN Author VARCHAR(150);

ALTER TABLE Books DROP COLUMN PublicationYear;

SELECT * FROM Books;

