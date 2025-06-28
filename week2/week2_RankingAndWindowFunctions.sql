--create products table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);
--insert into products table
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Monitor', 'Electronics', 8000),
(2, 'Keyboard', 'Electronics', 1200),
(3, 'Mouse', 'Electronics', 800),
(4, 'T-shirt', 'Apparel', 700),
(5, 'Hoodie', 'Apparel', 1200),
(6, 'Jeans', 'Apparel', 1000),
(7, 'Speakers', 'Electronics', 1200),
(8, 'Smartwatch', 'Electronics', 5000),
(9, 'Cap', 'Apparel', 300),
(10, 'Sneakers', 'Apparel', 2200);
--use ROW_NUMBER() to assign a unique rank within each category
SELECT *
FROM (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS Ranked
WHERE RowNum <= 3;
-- Using RANK() to see how ties are handled
SELECT *
FROM (
    SELECT *, 
           RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products
) AS Ranked
WHERE RankNum <= 3;

-- Using DENSE_RANK() to compare with RANK()
SELECT *
FROM (
    SELECT *, 
           DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM Products
) AS Ranked
WHERE DenseRankNum <= 3;

