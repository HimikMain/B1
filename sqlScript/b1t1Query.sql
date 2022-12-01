CREATE OR ALTER PROCEDURE B1t1_Procedure
AS
BEGIN
	SELECT SUM(CAST(b1t1_evenNumber AS BIGINT)) AS sumEven, AVG(b1t1_lessNumber) AS med FROM B1t1
END;

GO
EXEC B1t1_Procedure