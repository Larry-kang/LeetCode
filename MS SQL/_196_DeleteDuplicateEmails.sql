create table #Person  (Id int, Email varchar(255))

insert into #Person (id, email) values ('3', 'john@example.com')
insert into #Person (id, email) values ('2', 'bob@example.com')
insert into #Person (id, email) values ('1', 'john@example.com')

select * FROM #Person

SELECT * FROM #Person

DELETE FROM [#Person] WHERE ID NOT IN(SELECT MIN(Id) FROM [#Person]
GROUP BY Email)