CREATE PROCEDURE [dbo].[getClubsByRank]
AS
Begin
    SELECT  Club_Rank, Club_Name,Club_Points,Total_Goals,Goals_Against From Club order by club_rank asc
End