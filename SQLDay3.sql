-- #1. 
SELECT c.ContactName, c.City FROM dbo.Customers c 
WHERE EXISTS (SELECT 1 FROM dbo.Employees e WHERE e.city = c.city)

UNION ALL

SELECT e.FirstName + ' / ' + e.LastName, e.City FROM dbo.Employees e
WHERE EXISTS (SELECT 1 FROM dbo.Customers c WHERE c.city = e.city);

-- #2. 
-- a.Use sub-query
SELECT c.City FROM dbo.Customers c 
WHERE NOT EXISTS (SELECT e.City FROM dbo.Employees e WHERE c.City = e.City )

-- b.Do not use sub-query
SELECT c.City FROM dbo.Customers c 
LEFT JOIN dbo.Employees e ON c.City = e.City
WHERE e.City IS NULL

-- #3.
SELECT ProductID, SUM(Quantity) AS TotalOrder FROM dbo.[Order Details]
GROUP BY ProductID

-- #4. 
SELECT c.City, SUM(od.Quantity) AS NumOfProducts FROM dbo.Customers c 
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City

-- #5. 
-- a. Use union
SELECT A.City, COUNT(A.CustomerID) AS Num FROM (
    SELECT c.CustomerID, c.City FROM dbo.Customers c
    UNION 
    SELECT cu.CustomerID, cu.City FROM dbo.Customers cu
    ) A
    WHERE A.CustomerID = A.CustomerID
    GROUP BY A.City
    HAVING COUNT(A.CustomerID) >= 2

-- b. Use sub-query and no union
SELECT * FROM(
    SELECT c.City, COUNT(c.CustomerID) AS NumOfCustomer FROM dbo.Customers c  
    GROUP BY c.City
) A
WHERE A.NumOfCustomer >= 2

-- #6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, COUNT(od.ProductID) AS TotalProduct FROM dbo.Customers c 
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(od.ProductID) >= 2

-- #7. 
SELECT DISTINCT c.CustomerID, c.City FROM dbo.Customers c 
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID 
WHERE o.ShipCity != c.City

-- #8. 
SELECT ProductID, AVGPrice, CustomerCity FROM 
(
    SELECT DISTINCT ode.ProductID, CustomerCity, AVGPrice, 
    RANK() OVER (PARTITION BY ode.ProductID ORDER BY CustomerCity DESC) AS myrank 
    FROM dbo.[Order Details] ode

JOIN (
    SELECT TOP 5 od.ProductID, COUNT(od.ProductID) AS Num_Of_Product_Ordered, AVG(od.UnitPrice) AS AVGPrice
    FROM dbo.[Order Details] od JOIN Orders o ON o.OrderID = od.OrderID
    GROUP BY od.ProductID  -- => get 5 product ID
    ORDER BY COUNT(od.ProductID) DESC) AS SQ ON ode.ProductID = SQ.ProductID -- => get all orders

JOIN (
    SELECT os.CustomerID, cu.City AS CustomerCity, os.OrderID 
    FROM dbo.Orders os JOIN dbo.Customers cu ON os.CustomerID = cu.CustomerID 
) AS AB ON ode.OrderID = AB.OrderID

)RNK 
WHERE myrank = 1

-- #9. 
-- a. Use sub-query
SELECT e.City FROM dbo.Employees e 
WHERE e.City IN 
(
    SELECT c.City From dbo.Customers c 
    WHERE c.CustomerID NOT IN(
        SELECT o.CustomerID FROM dbo.Orders o
        ) --=> cities that have never ordered
        )

-- b. Do not use sub-query
SELECT e.City FROM dbo.Customers c
LEFT JOIN dbo.Orders o ON o.CustomerID = c.CustomerID --=> cities that have never ordered
JOIN dbo.Employees e ON c.City = e.City 
WHERE o.CustomerID IS NULL 


-- #10. 
SELECT COUNT(od.OrderID) AS Order_Sold, City, SUM(od.QuanEachOrder) AS QuantityForCity FROM 
(
    SELECT OrderID, SUM(Quantity) AS QuanEachOrder FROM [Order Details]  
    GROUP BY OrderID 
) od, Customers c 
JOIN Orders o ON c.CustomerID = o.CustomerID 
WHERE o.OrderID = od.OrderID
GROUP BY c.City
ORDER BY Order_Sold DESC

--Based on above result, there is not exist a city where sold most orders and also have the most total quantity of products ordered

-- #11.How do you remove the duplicates record of a table?
 -- 1. We can use DELETE statement and WHERE clause to remove the duplicate records, in the WHERE clause we specify the primary key of the duplicate row;
 
 -- 2. Use CTE with ROW_NUMBER function, use ROW_NUMBER function find the total number of rows of the duplicate records, then DELETE if the ROW_NUMBER > 1; 

