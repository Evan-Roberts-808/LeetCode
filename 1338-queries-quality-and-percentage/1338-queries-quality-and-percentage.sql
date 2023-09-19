# Write your MySQL query statement below
WITH QueryStats AS (
    SELECT
        query_name,
        AVG(CAST(rating AS DECIMAL) / position) AS quality,
        SUM(CASE WHEN rating < 3 THEN 1 ELSE 0 END) AS poor_queries,
        COUNT(*) AS total_queries
    FROM Queries
    GROUP BY query_name
)

SELECT
    query_name,
    ROUND(quality, 2) AS quality,
    ROUND((poor_queries / total_queries) * 100, 2) AS poor_query_percentage
FROM QueryStats;