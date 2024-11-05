/* Write your T-SQL query statement below */
WITH nnn AS (SELECT product_name,YEAR(order_date) AS year,MONTH(order_date) AS month, DAY(order_date) AS day, unit FROM Orders o LEFT JOIN Products p ON o.product_id = p.product_id )

SELECT product_name, SUM(unit) AS unit FROM nnn WHERE year = 2020 AND month = 2 GROUP BY product_name HAVING SUM(unit) >=100 ORDER BY  SUM(unit)