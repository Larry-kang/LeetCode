DECLARE @Courses TABLE (student varchar(255), class varchar(255))

insert into @Courses (student, class) values ('A', 'Math')
insert into @Courses (student, class) values ('B', 'English')
insert into @Courses (student, class) values ('C', 'Math')
insert into @Courses (student, class) values ('D', 'Biology')
insert into @Courses (student, class) values ('E', 'Math')
insert into @Courses (student, class) values ('F', 'Computer')
insert into @Courses (student, class) values ('G', 'Math')
insert into @Courses (student, class) values ('H', 'Math')
insert into @Courses (student, class) values ('I', 'Math')

SELECT * FROM @Courses

SELECT class 
FROM @Courses 
GROUP BY class 
HAVING COUNT(*) >= 5;