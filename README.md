# ChallengeRSM

## CTE that represents the report


 ``` sql
USE [AdventureWorks2022]

CREATE VIEW [dbo].[vSalesReport] AS
 
WITH SalesOrderDetails AS (
    SELECT 
        so.SalesOrderID AS OrderID,
        so.OrderDate,
        so.CustomerID,
        sod.ProductID,
        p.Name AS ProductName,
        pc.Name AS ProductCategory,
        sod.UnitPrice,
        sod.OrderQty AS Quantity,
        (sod.UnitPrice * sod.OrderQty) AS TotalPrice,
        so.SalesPersonID,
        CONCAT(pp.FirstName, ' ', pp.LastName) AS SalesPersonName,
        ship.AddressLine1 AS ShippingAddress,
        bill.AddressLine1 AS BillingAddress
    FROM 
        Sales.SalesOrderHeader so
    INNER JOIN 
        Sales.SalesOrderDetail sod ON so.SalesOrderID = sod.SalesOrderID
    INNER JOIN 
        Production.Product p ON sod.ProductID = p.ProductID
    INNER JOIN 
        Production.ProductSubcategory psc ON p.ProductSubcategoryID = psc.ProductSubcategoryID
    INNER JOIN 
        Production.ProductCategory pc ON psc.ProductCategoryID = pc.ProductCategoryID
    INNER JOIN 
        Person.Address ship ON so.ShipToAddressID = ship.AddressID
    INNER JOIN 
        Person.Address bill ON so.BillToAddressID = bill.AddressID
    INNER JOIN 
        Person.Person pp ON so.SalesPersonID = pp.BusinessEntityID
    WHERE 
        pp.PersonType = 'SP'
)

SELECT	TOP(10) OrderID,
        OrderDate,
        CustomerID,
        ProductID,
        ProductName,
        ProductCategory,
        UnitPrice,
        Quantity,
        TotalPrice,
        SalesPersonID,
        SalesPersonName,
        ShippingAddress,
        BillingAddress
FROM	SalesOrderDetails
GO



```


 ``` sql
USE [AdventureWorks2022]

CREATE VIEW [dbo].[vTopProducts] AS
WITH SalesOrderDetails AS (
    SELECT 
        so.SalesOrderID AS OrderID,
        so.OrderDate,
        so.CustomerID,
        sod.ProductID,
        p.Name AS ProductName,
        pc.Name AS ProductCategory,
        sod.UnitPrice,
        sod.OrderQty AS Quantity,
        (sod.UnitPrice * sod.OrderQty) AS TotalPrice,
        so.SalesPersonID,
        CONCAT(pp.FirstName, ' ', pp.LastName) AS SalesPersonName,
        ship.AddressLine1 AS ShippingAddress,
        bill.AddressLine1 AS BillingAddress
    FROM 
        Sales.SalesOrderHeader so
    INNER JOIN 
        Sales.SalesOrderDetail sod ON so.SalesOrderID = sod.SalesOrderID
    INNER JOIN 
        Production.Product p ON sod.ProductID = p.ProductID
    INNER JOIN 
        Production.ProductSubcategory psc ON p.ProductSubcategoryID = psc.ProductSubcategoryID
    INNER JOIN 
        Production.ProductCategory pc ON psc.ProductCategoryID = pc.ProductCategoryID
    INNER JOIN 
        Person.Address ship ON so.ShipToAddressID = ship.AddressID
    INNER JOIN 
        Person.Address bill ON so.BillToAddressID = bill.AddressID
    INNER JOIN 
        Person.Person pp ON so.SalesPersonID = pp.BusinessEntityID
    WHERE 
        pp.PersonType = 'SP'
)

SELECT TOP (10)
    ProductID,
    ProductName,
    ProductCategory,
    SUM(Quantity) AS TotalQuantity,
    SUM(TotalPrice) AS TotalSales
FROM
    SalesOrderDetails
GROUP BY
    ProductID,
    ProductName,
    ProductCategory
ORDER BY
    TotalSales DESC;
GO
```
