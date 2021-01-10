CREATE PROCEDURE [dbo].[playerAssisted]
    -- Add the parameters for the stored procedure here
    @FootBallerName  varchar(50), 
    @FAssists int, 
	@Fpoints int

AS
BEGIN

UPDATE Footballer SET Assists=@FAssists,points=@Fpoints WHERE Last_Name=@FootBallerName
END
GO