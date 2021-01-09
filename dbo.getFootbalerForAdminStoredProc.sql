CREATE PROCEDURE [dbo].[getFootballlerNameAndClub]
AS
BEGIN
Select Footballer.First_Name,Footballer.Last_Name,Club.Club_Name from Footballer , Club where Footballer.Club_ID = Club.Club_Id; 
END