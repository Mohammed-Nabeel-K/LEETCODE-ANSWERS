/* Write your T-SQL query statement below */
WITH jooin AS (
    SELECT s.student_id, s.student_name, j.subject_name
    FROM Students AS s
    CROSS JOIN Subjects AS j
),
datas AS (
    SELECT student_id, subject_name, COUNT(*) AS attended_exams
    FROM Examinations
    GROUP BY student_id, subject_name
)
SELECT 
    jooin.student_id, 
    jooin.student_name, 
    jooin.subject_name, 
    COALESCE(datas.attended_exams, 0) AS attended_exams
FROM jooin
LEFT JOIN datas 
    ON jooin.student_id = datas.student_id 
    AND jooin.subject_name = datas.subject_name
ORDER BY jooin.student_id,jooin.subject_name;