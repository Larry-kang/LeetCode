SELECT * FROM Scores


DECLARE @table TABLE(
    score DECIMAL(3,2),
    rank  INT
)

INSERT @table
SELECT s.score, RANK() OVER(ORDER BY s.score DESC) AS rank  FROM (SELECT score FROM Scores s GROUP BY s.score) AS s

SELECT a.score, b.rank FROM Scores a LEFT JOIN (SELECT s.score, RANK() OVER(ORDER BY s.score DESC) AS rank  FROM (SELECT score FROM Scores s GROUP BY s.score) AS s) AS b
ON a.score = b.score ORDER BY a.score DESC

