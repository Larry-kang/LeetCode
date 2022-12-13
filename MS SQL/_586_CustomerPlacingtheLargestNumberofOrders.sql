declare @orders table (order_number int, customer_number int)

insert into @orders (order_number, customer_number) values ('1', '1')
insert into @orders (order_number, customer_number) values ('2', '2')
insert into @orders (order_number, customer_number) values ('3', '3')
insert into @orders (order_number, customer_number) values ('4', '3')

SELECT * FROM @orders

SELECT dd.customer_number FROM
(SELECT oo.customer_number ,COUNT(oo.customer_number) AS count FROM @orders oo GROUP BY oo.customer_number) dd
WHERE dd.[count] = 
(SELECT TOP 1 aa.[count] FROM 
(SELECT oo.customer_number ,COUNT(oo.customer_number) AS count FROM @orders oo GROUP BY oo.customer_number) aa
ORDER BY aa.[count] DESC)
