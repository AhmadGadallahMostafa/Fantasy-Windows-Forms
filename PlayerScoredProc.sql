CREATE PROCEDURE [dbo].[playerScored]
    -- Add the parameters for the stored procedure here
    @FootBallerName  varchar(50), 
    @FGoals int,
    @FAssists int, 
    @FCleansheets int,
	@Fpoints int

AS
BEGIN

UPDATE Footballer SET Goals=@FGoals ,Assists=@FAssists,CleanSheets=@FCleansheets,points=@Fpoints WHERE Last_Name=@FootBallerName
END
GO