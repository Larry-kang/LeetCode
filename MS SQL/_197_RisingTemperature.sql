--v1
SELECT a.id
FROM Weather a, Weather b
WHERE DATEDIFF(DAY , b.recordDate, a.recordDate) = 1 AND a.temperature > b.temperature

--v2
SELECT a.id
FROM Weather a
JOIN Weather b
ON a.recordDate = DATEADD(DAY, 1, b.recordDate)
WHERE a.temperature > b.temperature