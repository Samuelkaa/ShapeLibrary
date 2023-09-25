CREATE TABLE Products (
	Id INT PRIMARY KEY,
	ProductName VARCHAR(30)
);

INSERT INTO Products
VALUES
	(1, 'Hamburger'),
	(2, 'Rolls Royce'),
	(3, 'T-Shirt'),
	(4, 'Pizza'),
	(5, 'Air');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	CategoryName VARCHAR(30)
);

INSERT INTO Categories
VALUES
	(1, 'Cars'),
	(2, 'Food'),
	(3, 'Clothes'),
	(4, 'For Gift');

CREATE TABLE ProductCategory (
	ProductId INT REFERENCES Products(Id),
	CategoryId INT REFERENCES Categories(Id)
);

INSERT INTO ProductCategory
VALUES
	(1, 2),
	(2, 1),
	(2, 4),
	(3, 3),
	(4, 2);

SELECT ProductName, CategoryName
FROM Products
LEFT JOIN ProductCategory
	ON Products.Id = ProductCategory.ProductId
LEFT JOIN Categories
	ON ProductCategory.CategoryId = Categories.Id;