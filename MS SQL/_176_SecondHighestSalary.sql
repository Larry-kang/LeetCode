DECLARE @Employee table (id int, salary int)

insert into @Employee (id, salary) values ('1', '100')
insert into @Employee (id, salary) values ('2', '200')
insert into @Employee (id, salary) values ('3', '300')


SELECT MAX(a.salary) AS SecondHighestSalary 
FROM @Employee a
WHERE a.salary < (SELECT MAX(b.salary) FROM @Employee b)