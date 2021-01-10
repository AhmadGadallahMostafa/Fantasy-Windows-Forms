CREATE PROCEDURE [dbo].[playerCleanSheet]
    -- Add the parameters for the stored procedure here
    @FootBallerName  varchar(50), 
    @FCleansheets int, 
	@Fpoints int

AS
BEGIN

UPDATE Footballer SET CleanSheets=@FCleansheets,points=@Fpoints WHERE Last_Name=@FootBallerName
END
GO