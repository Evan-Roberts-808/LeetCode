# Write your MySQL query statement below
SELECT name, bonus
FROM Employee
LEFT JOIN BONUS ON Employee.empId = Bonus.empId
WHERE bonus < 1000 OR bonus IS NULL;