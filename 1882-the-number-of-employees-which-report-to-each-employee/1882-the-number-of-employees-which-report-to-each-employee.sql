# Write your MySQL query statement below
WITH ManagerInfo AS (
    SELECT
        e.employee_id AS manager_id,
        e.name AS manager_name,
        COUNT(r.employee_id) AS reports_count,
        ROUND(AVG(r.age), 0) AS average_age
    FROM Employees e
    LEFT JOIN Employees r ON e.employee_id = r.reports_to
    WHERE e.employee_id IN (SELECT DISTINCT reports_to FROM Employees WHERE reports_to IS NOT NULL)
    GROUP BY e.employee_id, e.name
)

SELECT manager_id AS employee_id, manager_name AS name, reports_count, average_age
FROM ManagerInfo
ORDER BY manager_id;