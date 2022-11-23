SELECT MAX(a.salary) AS SecondHighestSalary 
FROM Employee a
WHERE a.salary < (SELECT MAX(b.salary) FROM Employee b)