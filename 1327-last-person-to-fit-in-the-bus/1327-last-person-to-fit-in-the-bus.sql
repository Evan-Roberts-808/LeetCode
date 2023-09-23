SELECT person_name
FROM Queue
WHERE (
    SELECT SUM(weight)
    FROM Queue AS sub
    WHERE sub.turn <= Queue.turn
) <= 1000
ORDER BY turn DESC
LIMIT 1;
