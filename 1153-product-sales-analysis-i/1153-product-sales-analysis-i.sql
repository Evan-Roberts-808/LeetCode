# Write your MySQL query statement below

SELECT product_name, year, price
FROM Product
LEFT JOIN Sales ON Product.product_id = Sales.product_id
WHERE year IS NOT NULL AND price IS NOT NULL;