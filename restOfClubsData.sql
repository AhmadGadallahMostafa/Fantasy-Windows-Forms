ALTER TABLE Club
ADD Stadium_Name varchar(50),ManagerName varchar(50), FoundationDate varchar(50);




Insert into Club values(7,'Aston Villa',0,0,0,'Smith',' Villa Park','1874');
Insert into Club values(8,'Brighton',0,0,0,'Potter','Falmer','1901');
Insert into Club values(9,'Burnely',0,0,0,'Dyche','Turf Moor','1882');
Insert into Club values(10,'Crystal Palace',0,0,0,'Hodgson','Selhurst Park','1905');
Insert into Club values(11,'Everton',0,0,0,'Ancelotti','Goodison Park','1878');
Insert into Club values(12,'Fulham',0,0,0,'Parker','Craven Cottage','1879');
Insert into Club values(13,'Leeds United',0,0,0,'Bielsa','Ellan Road','1919');
Insert into Club values(14,'Leicester City',0,0,0,'Rodgers','King Power','1884');
Insert into Club values(15,'Newcastle United',0,0,0,'Bruce','St James Park','1892');
Insert into Club values(16,'Sheffield',0,0,0,'Wilder','Bramall Lane','1889');
Insert into Club values(17,'Southampton',0,0,0,'Hasenhuttl','St Mary','1885');
Insert into Club values(18,'West Bromich',0,0,0,'Allardyce','Hawthorns','1878');
Insert into Club values(19,'West Ham',0,0,0,'Moyes','London Stadium','1900');
Insert into Club values(20,'Wolves',0,0,0,'Nuno','Molineux','1877');

/*add the three values of the already added clubs */
Update Club set Stadium_Name = 'Old Trafford' , ManagerName = 'Solskjaer', FoundationDate = '1902' where Club_Id = 1;
Update Club set Stadium_Name = 'Ethiad' , ManagerName = 'Guardiola', FoundationDate = '1880' where Club_Id = 2;
Update Club set Stadium_Name = 'Spurs Stadium' , ManagerName = 'Mourinho', FoundationDate = '1882' where Club_Id = 3;
Update Club set Stadium_Name = 'Stamford Bridge' , ManagerName = 'Lampard', FoundationDate = '1905' where Club_Id = 4;
Update Club set Stadium_Name = 'Anfield' , ManagerName = 'Klopp', FoundationDate = '1892' where Club_Id = 5;

Update Club set Stadium_Name = 'Emiartes' , ManagerName = 'Arteta', FoundationDate = '1886' where Club_Id = 6;