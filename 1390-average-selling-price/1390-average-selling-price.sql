/* Write your T-SQL query statement below */
WITH nnn AS (SELECT p.product_id ,units, (price*units) AS price  FROM Prices p LEFT JOIN UnitsSold u ON p.product_id =  u.product_id WHERE purchase_date BETWEEN start_date AND end_date),

nnnn AS (SELECT product_id , ISNULL(CAST(SUM(price) * 1.0/SUM(units) AS DECIMAL(10,2)),0) AS average_price  FROM nnn GROUP BY product_id )

SELECT DISTINCT Prices.product_id, ISNULL(average_price,0) AS average_price FROM Prices Left JOIN nnnn ON Prices.product_id = nnnn.product_id