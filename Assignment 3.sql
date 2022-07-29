--1.
CREATE VIEW view_product_order_Tong
AS
SELECT DISTINCT p.ProductName, dt.Quantity
FROM Products p LEFT JOIN 
(SELECT ProductID, Quantity FROM [Order Details] GROUP BY ProductID) dt ON p.ProductID = dt.ProductID
ORDER BY ProductName

--2. 
CREATE PROC sp_product_order_quantity_Tong
AS
@ProductID int
BEGIN
PRINT @Quantity
END

--3. 
CREATE PROC sp_product_order_city_Tong
AS
@ProductName varchar(20)
BEGIN
PRINT SELECT TOP 5 o.ShipCity, dt.Quantity
	  FROM Orders o LEFT JOIN
	  (SELECT o.OrderID, od.Quantity
	  FROM [Order Details] od JOIN Orders o ON o.OrderID = od.OrderID) dt ON dt.OrderID = o.OrderID
	  ORDER BY o.ShipCity DESC
END

--4.
