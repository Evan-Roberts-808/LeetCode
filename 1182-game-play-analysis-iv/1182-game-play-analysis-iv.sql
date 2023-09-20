# Write your MySQL query statement below
WITH FirstLogin AS (
    SELECT
        player_id,
        MIN(event_date) AS first_login
    FROM
        Activity
    GROUP BY
        player_id
)

SELECT
    ROUND(COUNT(FL.player_id) / (SELECT COUNT(DISTINCT player_id) FROM FirstLogin), 2) AS fraction
FROM
    FirstLogin FL
JOIN
    Activity A ON FL.player_id = A.player_id
WHERE
    A.event_date = DATE_ADD(FL.first_login, INTERVAL 1 DAY);