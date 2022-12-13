DECLARE @Stadium TABLE (id int, visit_date DATE NULL, people int)

--insert into @Stadium (id, visit_date, people) values ('1', '2017-01-01', '10')
--insert into @Stadium (id, visit_date, people) values ('2', '2017-01-02', '109')
--insert into @Stadium (id, visit_date, people) values ('3', '2017-01-03', '150')
--insert into @Stadium (id, visit_date, people) values ('4', '2017-01-04', '99')
--insert into @Stadium (id, visit_date, people) values ('5', '2017-01-05', '145')
--insert into @Stadium (id, visit_date, people) values ('6', '2017-01-06', '1455')
--insert into @Stadium (id, visit_date, people) values ('7', '2017-01-07', '199')
--insert into @Stadium (id, visit_date, people) values ('8', '2017-01-09', '188')

insert into @Stadium (id, visit_date, people) values ('1', '2017-01-01', '10')
insert into @Stadium (id, visit_date, people) values ('2', '2017-01-02', '109')
insert into @Stadium (id, visit_date, people) values ('3', '2017-01-03', '150')
insert into @Stadium (id, visit_date, people) values ('4', '2017-01-04', '100')


SELECT * FROM @Stadium

SELECT s1.id, s1.visit_date, s1.people
FROM @Stadium s1 
JOIN @Stadium s2 
ON s2.id = s1.id + 1 
JOIN @Stadium s3 
ON s3.id = s2.id + 1
WHERE s1.people >= 100 
AND s2.people >= 100 
AND s3.people >= 100 
UNION
SELECT s1.id, s1.visit_date, s1.people
FROM @Stadium s1 
JOIN @Stadium s2 
ON s2.id = s1.id - 1 
JOIN @Stadium s3 
ON s3.id = s2.id - 1
WHERE s1.people >= 100
AND s2.people >= 100 
AND s3.people >= 100 
UNION
SELECT s1.id, s1.visit_date, s1.people
FROM @Stadium s1 
JOIN @Stadium s2 
ON s2.id = s1.id - 1 
JOIN @Stadium s3 
ON s3.id = s1.id + 1
WHERE s1.people >= 100
AND s2.people >= 100
AND s3.people >= 100
GROUP BY s1.id, s1.visit_date, s1.people
ORDER BY s1.visit_date ASC