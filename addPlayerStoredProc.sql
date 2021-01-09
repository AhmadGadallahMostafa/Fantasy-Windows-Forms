CREATE PROCEDURE [dbo].[addFootballer]
	-- Add the parameters for the stored procedure here
	@Player_Id int,
	@Club_ID int,
	@First_Name varchar(50), 
	@Last_Name varchar(50),
	@Position int, 
	@Price int,
	@Goals int , 
	@Assists int , 
	@Age int,
	@CleanSheets int,
	@Points int
AS
BEGIN
INSERT INTO Footballer
Values (@Player_Id ,
	@Club_ID ,
	@First_Name , 
	@Last_Name ,
	@Position , 
	@Price ,
	@Goals, 
	@Assists  , 
	@Age ,
	@CleanSheets ,
	@Points )
END
GO

