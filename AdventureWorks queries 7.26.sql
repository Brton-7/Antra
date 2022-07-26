--1.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

--2.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice > 0

--3.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

--4.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL AND ListPrice > 0

--5.
SELECT Name + ' ' + Color as [Name and Color]
FROM Production.Product
WHERE Color IS NOT NULL

--6.
SELECT 'NAME:' + Name + ' -- COLOR:' + Color as [Name and Color]
FROM Production.Product
WHERE Color IS NOT NULL

--7.
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

--8.
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color = 'Black' OR Color = 'Blue'

--9. 
SELECT Name
FROM Production.Product
WHERE Name LIKE 'A%'

--10.
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'A%' OR Name LIKE 'S%'
ORDER BY Name ASC

--11.
SELECT *
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%'
ORDER BY Name

--12.
SELECT ISNULL(ProductSubcategoryID,0) [ProductSubcategoryID], ISNULL(Color,0) [Color]
FROM Production.Product