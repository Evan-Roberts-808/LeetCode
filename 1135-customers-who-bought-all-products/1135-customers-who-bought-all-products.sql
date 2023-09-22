# Write your MySQL query statement below
WITH CustomerProducts AS (
    SELECT customer_id, product_key
    FROM Customer
    GROUP BY customer_id, product_key
),

DistinctProducts AS (
    SELECT DISTINCT product_key
    FROM Product
)

SELECT DISTINCT cp.customer_id
FROM CustomerProducts cp
JOIN DistinctProducts dp
    ON cp.product_key = dp.product_key
GROUP BY cp.customer_id
HAVING COUNT(DISTINCT cp.product_key) = (SELECT COUNT(*) FROM DistinctProducts)