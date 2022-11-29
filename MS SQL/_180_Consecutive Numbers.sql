
DECLARE @Logs TABLE (id int, num int)

insert into @Logs (id, num) values ('1', '1')
insert into @Logs (id, num) values ('2', '1')
insert into @Logs (id, num) values ('3', '1')
insert into @Logs (id, num) values ('4', '2')
insert into @Logs (id, num) values ('5', '1')
insert into @Logs (id, num) values ('6', '2')
insert into @Logs (id, num) values ('7', '2')

SELECT a.num as [ConsecutiveNums]
FROM
(SELECT a.id, a.num, IIF(a.num = b.num AND b.num = c.num, 1, 0) as [count]
FROM @Logs  a
JOIN @Logs  b
ON a.id = b.id - 1
JOIN @Logs  c
ON b.id = c.id - 1) AS a
WHERE a.[count] = 1
group by num