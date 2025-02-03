CREATE TABLE Users (
UserID INT PRIMARY KEY,
Username VARCHAR(50),
Email VARCHAR(100) UNIQUE,  
Password VARCHAR(50) CHECK (LEN(Password) >= 8)  
);

INSERT INTO Users (UserID, Username, Email, Password) VALUES
(1, 'Shreyas', 'shreyas@example.com', 'password'),
(2, 'Kulkarni', 'shreyas@example.com', 'pass'); --invalid

