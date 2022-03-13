--- 1. --- 
CREATE VIEW view_product_order_chi AS
SELECT p.ProductID, SUM(od.Quantity) AS Total_Qaun_Ordered FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID;
GO;

SELECT * FROM view_product_order_chi
GO;

--- 2. --- 
CREATE PROCEDURE sp_product_order_quantity_chi @ProductID int
AS
SELECT COUNT(od.Quantity) AS Total_Product_Ordered 
FROM [Order Details] od 
WHERE od.ProductID = @ProductID
GO

EXEC sp_product_order_quantity_chi @ProductID = 1
GO

--- 3.---  
CREATE PROCEDURE sp_product_order_city_chi @ProductName nvarchar(30)
AS
SELECT TOP 5 c.City, SUM(od.Quantity) AS Quantity FROM [Order Details] od
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON c.CustomerID = o.CustomerID
WHERE od.OrderID IN(
    SELECT ode.OrderID FROM [Order Details] ode
    WHERE ode.ProductID IN (
        SELECT p.ProductID FROM Products p
        WHERE p.ProductName = @ProductName
    )
)
GROUP BY c.City
ORDER BY Quantity DESC
GO

EXEC sp_product_order_city_chi @ProductName = 'Lakkalikööri'
GO

--- 4. --- 
CREATE TABLE city_chi(
    ID int PRIMARY KEY NOT NULL,
    City VARCHAR(10) NOT NULL
)

CREATE TABLE people_chi(
    ID int PRIMARY KEY NOT NULL,
    Name VARCHAR(20) NOT NULL,
    City int FOREIGN KEY REFERENCES city_chi(ID)
)

INSERT INTO city_chi VALUES(1, 'Seattle');
INSERT INTO city_chi VALUES(2, 'Green Bay');

INSERT INTO people_chi VALUES(1, 'Aaron Rodgers', 2);
INSERT INTO people_chi VALUES(2, 'Russell Wilson', 1);
INSERT INTO people_chi VALUES(3, 'Jody Nelson', 2);

-- Put ppl in a new City "Madison"
INSERT INTO city_chi VALUES(3, 'Madison');

UPDATE people_chi SET City = (SELECT ID FROM city_chi WHERE City = 'Madison')
WHERE City = (SELECT ID FROM city_chi WHERE City = 'Seattle')

-- Remove City 'Seattle'
DELETE FROM city_chi WHERE City = 'Seattle'
GO

-- Create View
CREATE VIEW Packers_Chi AS 
SELECT * FROM people_chi p 
WHERE p.City IN(
    SELECT c.ID FROM city_chi c WHERE c.City = 'Green Bay'
)
GO

DROP TABLE people_chi
DROP TABLE city_chi
DROP VIEW Packers_Chi

GO
--- 5. --- 
CREATE PROCEDURE sp_birthday_employees_chi @Month INT AS
SELECT * INTO birthday_employees_chi 
FROM dbo.Employees
WHERE MONTH(BirthDate) = @Month;
GO

EXEC sp_birthday_employees_chi @Month = 2;

DROP TABLE dbo.birthday_employees_chi;

--- 6. --- How do you make sure two tables have the same data?
-- Use INNER JOIN to find the duplicate rows, for example SELECT col FROM table1 INNER JOIN table2 ON table1.col1 = table2
