# Write your MySQL query statement below
WITH RankedSalaries AS (
  SELECT
    e.departmentId,
    e.name AS Employee,
    e.salary AS Salary,
    DENSE_RANK() OVER (PARTITION BY e.departmentId ORDER BY e.salary DESC) AS SalaryRank
  FROM Employee e
)

SELECT
  d.name AS Department,
  r.Employee,
  r.Salary
FROM RankedSalaries r
JOIN Department d ON r.departmentId = d.id
WHERE r.SalaryRank <= 3
ORDER BY d.name, r.SalaryRank;
