CREATE PROCEDURE [dbo].[addFootballer]
	@clubID int,
	@firstName varchar(40),
	@lastName varchar(40),
	@position int,
	@price int,
	@age int,
	@points int
AS
BEGIN
INSERT INTO Footballer(Club_ID,First_Name,Last_Name,Poisition,Price,Age,points)
Values (@clubID ,
	@firstName ,
	@lastName,
	@position ,
	@price ,
	@age ,
	@points )
END
GO

