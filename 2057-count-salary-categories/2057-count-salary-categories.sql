# Write your MySQL query statement below
WITH 
LowSalary AS (
    SELECT COUNT(account_id) AS accounts_count
    FROM Accounts low
    WHERE income < 20000
),
AverageSalary AS (
    SELECT COUNT(account_id) AS accounts_count
    FROM Accounts average
    WHERE income >= 20000 AND income <= 50000
),
HighSalary AS (
    SELECT COUNT(account_id) AS accounts_count
    FROM Accounts high
    WHERE income > 50000
)

SELECT 'Low Salary' AS category, COALESCE(LowSalary.accounts_count, 0) AS accounts_count
FROM LowSalary
UNION
SELECT 'Average Salary' AS category, COALESCE(AverageSalary.accounts_count, 0) AS accounts_count
FROM AverageSalary
UNION
SELECT 'High Salary' AS category, COALESCE(HighSalary.accounts_count, 0) AS accounts_count
FROM HighSalary;