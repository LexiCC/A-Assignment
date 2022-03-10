-- #1.
SELECT COUNT(ProductID) AS Products FROM Production.Product;

-- #2.
SELECT COUNT(ProductID) AS Products FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL;

-- #3.
SELECT ProductSubcategoryID, COUNT(ProductID) AS CountedProducts 
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID;

-- #4.
SELECT COUNT(ProductID) AS Products 
FROM Production.Product
WHERE ProductSubcategoryID IS NULL;

-- #5.
SELECT SUM(Quantity) 
FROM Production.ProductInventory;

SELECT * 
FROM Production.ProductInventory;

-- #6.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100;

-- #7.
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID, Shelf
HAVING SUM(Quantity) < 100;

-- #8.
SELECT AVG(Quantity) AS AverageQuantity
FROM Production.ProductInventory
WHERE LocationID = 10;

-- #9.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY Shelf, ProductID;

-- #10.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY Shelf, ProductID;

-- #11.
SELECT Color, Class, COUNT(ProductID) AS TheCount, AVG(ListPrice) AS TheAvg 
FROM Production.Product
WHERE Color IS NOT NULL AND CLASS IS NOT NULL
GROUP BY Color, Class;

-- #12.
SELECT c.CountryRegionCode, s.StateProvinceCode FROM
person.CountryRegion c JOIN person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode;

-- #13.
SELECT c.CountryRegionCode, s.StateProvinceCode FROM
person.CountryRegion c JOIN person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.CountryRegionCode = 'CA' or c.CountryRegionCode = 'DE';

------------------------------------------------------------------------ Using Northwnd Database:

-- #14.
SELECT DISTINCT p.ProductID, p.ProductName
FROM dbo.Products p JOIN dbo.[Order Details] od ON p.ProductID = od.ProductID 
WHERE od.OrderID IN (
    SELECT o.OrderID 
    FROM dbo.Orders o
    WHERE DATEDIFF(YEAR, o.OrderDate, GetDate()) <= 25);

-- #15.
SELECT TOP 5 ShipPostalCode, COUNT(OrderID) AS SoldAmount
FROM dbo.Orders
WHERE ShipPostalCode IS NOT NULL
GROUP BY ShipPostalCode
ORDER BY SoldAmount DESC;

-- #16.
SELECT TOP 5 ShipPostalCode, COUNT(OrderID) AS SoldAmount
FROM dbo.Orders
WHERE ShipPostalCode IS NOT NULL AND DATEDIFF(YEAR, OrderDate, GetDate()) <= 25
GROUP BY ShipPostalCode
ORDER BY SoldAmount DESC;

-- #17.
SELECT City, COUNT(CustomerID) AS NumOfCustomer
FROM dbo.Customers
GROUP BY City;

-- #18.
SELECT City, COUNT(CustomerID) AS NumOfCustomer
FROM dbo.Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2;

-- #19.
SELECT DISTINCT c.ContactName
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate >= '1998-01-01'

-- #20.
SELECT c.ContactName, MAX(o.OrderDate)
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName;

-- #21.
SELECT c.ContactName, COUNT(od.Quantity) AS CountOfProduct
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName

-- #22.
SELECT c.CustomerID, COUNT(od.Quantity) AS CountOfProduct
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.Quantity) >= 100

-- #23.
SELECT su.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
FROM dbo.Suppliers su CROSS JOIN dbo.Shippers sh
ORDER BY su.CompanyName

-- #24.
SELECT o.OrderDate, p.ProductName
FROM dbo.Products p JOIN dbo.[Order Details] od ON od.ProductID = p.ProductID
JOIN dbo.Orders o ON o.OrderID = od.OrderID

-- #25.
SELECT DISTINCT e1.FirstName + ' ' + e1.LastName [Full Name], e1.Title
FROM dbo.Employees e1, dbo.Employees e2 
WHERE e1.Title = e2.Title AND e1.EmployeeID != e2.EmployeeID

-- #26.
SELECT ReportsTo AS Manager_ID, COUNT(EmployeeID) AS NumOfSub
FROM dbo.Employees
GROUP BY ReportsTo
HAVING COUNT(EmployeeID) >= 2 

-- #27.
SELECT City, CompanyName, ContactName, 'Customer' as Type
FROM dbo.Customers 
UNION ALL
SELECT City, CompanyName, ContactName, 'Supplier' as Type
FROM dbo.Suppliers