DECLARE @Employee table (id int, name varchar(255), salary int, departmentId int)
DECLARE @Department table (id int, name varchar(255))

insert into @Employee (id, name, salary, departmentId) values ('1', 'Joe', '70000', '1')
insert into @Employee (id, name, salary, departmentId) values ('2', 'Jim', '90000', '1')
insert into @Employee (id, name, salary, departmentId) values ('3', 'Henry', '80000', '2')
insert into @Employee (id, name, salary, departmentId) values ('4', 'Sam', '60000', '2')
insert into @Employee (id, name, salary, departmentId) values ('5', 'Max', '90000', '1')

insert into @Department (id, name) values ('1', 'IT')
insert into @Department (id, name) values ('2', 'Sales')

SELECT * FROM @Employee
SELECT * FROM @Department


SELECT b.name AS Department, a.name AS Employee, a.salary AS Salary
FROM @Employee a
JOIN (SELECT *,(SELECT MAX(emp.salary) FROM @Employee emp WHERE emp.departmentId = dep.id) AS maxVal
FROM @Department dep) AS b
ON a.departmentId = b.id
AND a.salary = b.maxVal
ORDER BY a.id
