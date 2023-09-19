# Write your MySQL query statement below
WITH StartTimes AS (
    SELECT machine_id, process_id, timestamp AS start_time
    FROM Activity
    WHERE activity_type = 'start'
),
EndTimes AS (
    SELECT machine_id, process_id, timestamp AS end_time
    FROM Activity
    WHERE activity_type = 'end'
)
SELECT s.machine_id,
    ROUND(SUM(end_time - start_time) / COUNT(DISTINCT s.process_id), 3) AS processing_time
FROM StartTimes s
JOIN Endtimes e ON s.machine_id = e.machine_id AND s.process_id = e.process_id
GROUP BY s.machine_id;