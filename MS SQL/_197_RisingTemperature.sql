DECLARE @Weather table (id int, recordDate date, temperature int)

insert into @Weather (id, recordDate, temperature) values ('1', '2015-01-01', '10')
insert into @Weather (id, recordDate, temperature) values ('2', '2015-01-02', '25')
insert into @Weather (id, recordDate, temperature) values ('3', '2015-01-03', '20')
insert into @Weather (id, recordDate, temperature) values ('4', '2015-01-04', '30')

--v1
SELECT a.id
FROM @Weather a, @Weather b
WHERE DATEDIFF(DAY , b.recordDate, a.recordDate) = 1 AND a.temperature > b.temperature

--v2
SELECT a.id
FROM @Weather a
JOIN @Weather b
ON a.recordDate = DATEADD(DAY, 1, b.recordDate)
WHERE a.temperature > b.temperature