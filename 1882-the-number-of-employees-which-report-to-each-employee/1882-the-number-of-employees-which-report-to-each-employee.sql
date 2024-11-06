/* Write your T-SQL query statement below */
WITH nnn AS (SELECT reports_to , COUNT(name) AS reports_count,ROUND(AVG(CAST(age AS DECIMAL(10,2))),0) AS average_age FROM Employees GROUP BY reports_to HAVING reports_to IS NOT NULL)

SELECT DISTINCT employee_id,name,reports_count,average_age FROM Employees e LEFT JOIN nnn ON e.employee_id = nnn.reports_to WHERE reports_count IS NOT NULL