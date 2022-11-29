SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[getNthHighestSalary](@N INT) RETURNS INT AS
BEGIN
    RETURN (
        SELECT salary FROM 
        (
            SELECT 
                ROW_NUMBER() OVER (ORDER BY salary DESC) AS [ROW_Id],
                salary AS [salary] FROM Employee GROUP BY salary
        ) AS result
        WHERE [ROW_Id] = @N
    );
END