-- #1.

SELECT ProductID, Name, Color, ListPrice FROM Production.Product;

-- #2.
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE ListPrice != 0;

-- #3.
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE Color IS NULL;

-- #4.
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE Color IS NOT NULL;

-- #5.
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE Color IS NOT NULL AND ListPrice > 0;

-- #6.
SELECT Name, Color FROM Production.Product
WHERE Color IS NOT NULL;

-- #7.
SELECT Name, Color FROM Production.Product
WHERE Color = 'Silver' or Color = 'Black';

-- #8.
SELECT ProductID, Name FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500;

-- #9.
SELECT ProductID, Name, Color FROM Production.Product
WHERE Color = 'Blue' or Color = 'Black';

-- #10.
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE Name LIKE 'S%';

-- #11.
SELECT Name, ListPrice FROM Production.Product
Order by Name;

-- #12.
SELECT Name, ListPrice FROM Production.Product
WHERE Name LIKE 'S%' or Name LIKE 'A%'
Order by Name;

-- #13.
SELECT ProductID, Name, Color, ListPrice FROM Production.Product
WHERE Name LIKE 'SPO%' AND Name NOT LIKE '___k%'
Order by Name;

-- #14.
SELECT DISTINCT Color FROM Production.Product
Order by color DESC;

-- #15.
SELECT DISTINCT ProductSubcategoryID, Color FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND
Color IS NOT NULL;