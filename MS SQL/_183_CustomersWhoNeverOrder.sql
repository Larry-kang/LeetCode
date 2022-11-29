DECLARE @Customers TABLE (id int, name varchar(255))
DECLARE @Orders TABLE (id int, customerId int)

insert into @Customers (id, name) values ('1', 'Joe')
insert into @Customers (id, name) values ('2', 'Joe')
--insert into @Customers (id, name) values ('2', 'Henry')
--insert into @Customers (id, name) values ('3', 'Sam')
--insert into @Customers (id, name) values ('4', 'Max')

--insert into @Orders (id, customerId) values ('1', '3')
--insert into @Orders (id, customerId) values ('2', '1')

SELECT * FROM @Customers
SELECT * FROM @Orders

--Output Customers

SELECT D.name AS Customers
FROM(
SELECT C.name,COUNT(O.id) AS count
FROM @Customers C
LEFT JOIN @Orders O
ON c.id = O.customerId
GROUP BY C.id, C.name) AS D
WHERE D.[count] = 0
