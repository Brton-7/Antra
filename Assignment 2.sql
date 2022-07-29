--1.
SELECT c.Name AS Country, p.Name AS Province
FROM Person.CountryRegion c INNER JOIN  Person.StateProvince p ON c.CountryRegionCode = p.CountryRegionCode

--2.
SELECT c.Name AS Country, p.Name AS Province
FROM Person.CountryRegion c INNER JOIN Person.StateProvince p ON c.CountryRegionCode = p.CountryRegionCode
WHERE c.Name IN ('Canada', 'Germany')

--3. 
SELECT ProductName
FROM Products
WHERE UnitsOnOrder >= 1

--4.


--5.
SELECT City, COUNT(CustomerID) as NumOfCustomers
FROM Customers
GROUP BY City

--6.
SELECT DISTINCT City, COUNT(CustomerID) as NumOfCustomers
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2

--7. 
SELECT c.ContactName as Name, COUNT(o.OrderID) as [Products Bought]
FROM Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.ContactName

--8.

--9.
SELECT su.CompanyName as [Supplier Company Name], sh.CompanyName as [Shipping Company Name]
FROM Shippers sh CROSS JOIN Suppliers su

--10.
SELECT o.OrderDate as OrderDate, p.ProductName as ProductName
FROM Orders o INNER JOIN [Order Details] od ON o.OrderID = od.OrderID INNER JOIN Products p ON od.ProductID = p.ProductID

--11.
SELECT e1.FirstName, e1.LastName, e2.FirstName, e2.LastName
FROM Employees e1 INNER JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.FirstName != e2.FirstName

--12.
SELECT FirstName + ' ' + LastName as Managers
FROM Employees
WHERE Title LIKE '%Manager' AND ReportsTo > 1

--13.

--14.
SELECT DISTINCT c.City
FROM Customers c INNER JOIN Employees e ON c.City = e.City

--15a.
SELECT DISTINCT c.City
FROM Customers c 
WHERE c.City NOT IN
(
	SELECT e.City
	FROM Employees e
)

--15b.

--16.
SELECT p.ProductName, COUNT(o.OrderID) as [Order Quantity]
FROM Orders o INNER JOIN [Order Details] od ON o.OrderID = od.OrderID INNER JOIN Products p ON od.ProductID = p.ProductID
GROUP BY p.ProductName

--17a.


--17b.
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2

SELECT * FROM Customers

--18.
SELECT c.City
FROM Customers c INNER JOIN Orders o ON o.CustomerID = c.CustomerID INNER JOIN [Order Details] od ON o.OrderID = od.OrderID INNER JOIN Products p ON od.ProductID = p.ProductID
GROUP BY c.City
HAVING COUNT(p.ProductID) > 1

SELECT DISTINCT ShipCity FROM Orders

--19.


--20.

--21. Using common table expressions we select column fields and use the RowNumber() OVER() functions as well as ORDER BY row_num to delete where row_num > 1
