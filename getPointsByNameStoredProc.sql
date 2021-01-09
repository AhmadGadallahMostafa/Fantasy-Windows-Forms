USE [Fantasy]
GO
/****** Object:  StoredProcedure [dbo].[getPointsByName]    Script Date: 1/9/2021 6:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[getPointsByName]
	@Fname varchar(55),
	@lname varchar(55)
AS
begin
	SELECT Footballer.points from Footballer where Footballer.Last_Name = @lname and Footballer.First_Name = @Fname  
end