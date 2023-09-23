SELECT DISTINCT
    p.product_id,
    COALESCE(
        (SELECT new_price
         FROM Products AS sub
         WHERE sub.product_id = p.product_id
           AND sub.change_date <= '2019-08-16'
         ORDER BY sub.change_date DESC
         LIMIT 1),
        10
    ) AS price
FROM (
    SELECT DISTINCT product_id
    FROM Products
) AS p;
