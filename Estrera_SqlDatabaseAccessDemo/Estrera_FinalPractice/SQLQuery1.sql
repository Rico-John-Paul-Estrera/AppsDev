-- Create a new database called 'MySampleDB' if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'MySampleDB')
BEGIN
CREATE DATABASE MySampleDB;
END;
GO -- Batch separator
-- Switch context to the new database
USE MySampleDB;
GO
-- Create a table called 'Users' if it doesn't exist
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA
= 'dbo' AND TABLE_NAME = 'Users')
BEGIN
CREATE TABLE Users (
UserID INT PRIMARY KEY IDENTITY(1,1), -- Auto-incrementing ID
FirstName NVARCHAR(50) NOT NULL,
Email NVARCHAR(100) UNIQUE
);
END;
GO
-- Insert some sample data (optional, but helpful for testing reads)
-- Check if data already exists before inserting to avoid errors on re-run
IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'alice@example.com')
BEGIN
INSERT INTO Users (FirstName, Email) VALUES ('Alice',
'alice@example.com');
END;
IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'bob@example.com')
BEGIN
INSERT INTO Users (FirstName, Email) VALUES ('Bob',
'bob@example.com');
END;
GO
-- Verify the table creation and data
SELECT * FROM Users;
PRINT 'Database MySampleDB and Table Users setup complete.';