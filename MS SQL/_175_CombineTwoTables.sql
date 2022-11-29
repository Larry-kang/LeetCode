DECLARE @Person table (personId int, firstName varchar(255), lastName varchar(255))
DECLARE @Address table (addressId int, personId int, city varchar(255), state varchar(255))

insert into @Person (personId, lastName, firstName) values ('1', 'Wang', 'Allen')
insert into @Person (personId, lastName, firstName) values ('2', 'Alice', 'Bob')
Truncate table Address
insert into @Address (addressId, personId, city, state) values ('1', '2', 'New York City', 'New York')
insert into @Address (addressId, personId, city, state) values ('2', '3', 'Leetcode', 'California')


SELECT a.firstName, a.lastName, b.city, b.state 
FROM @Person a
LEFT JOIN @Address b
ON a.personId = b.personId