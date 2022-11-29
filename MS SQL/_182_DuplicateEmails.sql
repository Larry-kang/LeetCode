DECLARE @Person TABLE (id int, email varchar(255))

insert into @Person (id, email) values ('1', 'a@b.com')
insert into @Person (id, email) values ('2', 'c@d.com')
insert into @Person (id, email) values ('3', 'a@b.com')

SELECT * FROM @Person

SELECT A.email AS Email
FROM
(SELECT email, COUNT(email) AS COUNT
FROM @Person
GROUP BY email) AS A
WHERE a.[COUNT] > 1