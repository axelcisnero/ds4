select * from Products

select ProductID, ProductName, UnitPrice FROM Products

select ProductID, ProductName, UnitPrice
From Products
Where UnitPrice > 15

select ProductID, ProductName, UnitPrice
From Products
Where UnitPrice >= 15 and UnitPrice <= 50

select ProductID, ProductName, UnitPrice
From Products
Where UnitPrice between 15 and 50

select ProductID, ProductName, UnitPrice
From Products
Where not UnitPrice > 15

select ProductID, ProductName, UnitPrice
From Products
Where ProductID > 15 or UnitPrice < 10

Select EmployeeID, LastName from Employees
where LastName like 'D%'

Select EmployeeID, LastName from Employees
where LastName like '%N'

Select EmployeeID, LastName, Title from Employees
where Title like '%SALES%'

Select EmployeeID, LastName from Employees
where LastName Not like 'D%'

Select ProductID, ProductName, UnitPrice
from Products
Order By ProductID ASC

Select ProductID, ProductName, UnitPrice
from Products
Order By ProductID DESC

select distinct OrderID from [Order Details]

select top 5 OrderID, ProductID, Quantity
from [Order Details]

select top 10 percent OrderID, ProductID, Quantity
from [Order Details]

Select CategoryName AS [Nombre de Categoria]
From Categories

Select OrderID, OrderDate, ShippedDate, ShippedDate + 5 AS RetrasoEnvio
From orders

Select OrderID, P.ProductID, ProductName
from Products P
Inner join [Order Details] OD
On P.ProductID=OD.ProductID

Select OrderID, P.ProductID, ProductName
from Products P
Inner join [Order Details] OD
On P.ProductID=OD.ProductID

Select ProductName, CompanyName, ContactName
From Products P
Full Join Suppliers S
On P.SupplierID=S.SupplierID