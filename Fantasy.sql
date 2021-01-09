---------------Database creation-------------

create database Fantasy
Go

use Fantasy

------------Table Creation-----------------
create table Club
(
Club_Id int identity(1,1),
Club_Rank int ,
Club_Name varchar(50) not null,
Club_Points int,
Goals_Against int,
Total_Goals int,
primary key (Club_Id),
)

create table Footballer
(
Player_Id int identity(1,1),
Club_ID int,
First_Name varchar(50) not null,
Last_Name varchar(50) not null,
Poisition int,
Price int,
Goals int,
Assists int,
Age int,
CleanSheets int
primary key (Player_Id),

Foreign key (Club_ID) references Club,
)

create table Unavailable_Player
(
ID int,
Suspension_Status bit,
Start_Date date,
Duration int,
Injury_Status bit,
Primary key (ID,Start_Date),
foreign key (ID) references Footballer,
)

create table Season
(
Season_Number int identity(1,1),
Primary key (Season_Number),
)


create table Week
(
Week_Number int identity(1,1),
Season_Number int,
Start_Date date,
End_Date date,
Primary key (Week_Number,Season_Number),
foreign key (Season_Number) references Season,
)



create table Club_Fixtures
(
Host_id int,
Guest_Id int,
Week_number int,
Season_number int,
Score int,
primary key(Host_id,Guest_Id,Week_number,Season_number),
foreign key (Host_id) references Club(Club_Id),
foreign key (Guest_Id) references Club(Club_Id),
foreign key (Week_number,Season_number) references Week(Week_Number,Season_number), 
)



create table Account
(
Email varchar(255),
Date_Of_Birth date,
Account_Type int,
Password varchar(50),
Gender varchar(50)
primary key (Email),
)

create table Fantasy_Player_Team
(
Player_Username varchar(50) not null,
Age int,
Email varchar(255),
Fantasy_Team_ID int identity(1,1),
Team_Name varchar(50),
Total_Value int,
Team_Funds int,
Total_Points int,
Total_Transfers int,
Overall_Rank int,
primary key (Fantasy_Team_ID),
)

 create table Transfered
(
Player_ID int,
Week_Number int,
Season_Number int,
Fantasy_Team_ID int,
status varchar(50),
primary key (Player_ID,Week_Number,Season_Number,Fantasy_Team_ID),
foreign key (Player_ID) references Footballer,
foreign key (Week_Number,Season_Number) references Week(Week_Number,Season_Number),
foreign key (Fantasy_Team_ID) references Fantasy_Player_Team,
)

create table Plays_In_Fantasy_Team
(
Player_ID int,
Fantasy_Team_Id int,
primary key (Player_ID,Fantasy_Team_Id),
foreign key (Player_ID) references Footballer,
foreign key (Fantasy_Team_Id) references Fantasy_Player_Team(Fantasy_Team_ID),
)
create table Fantasy_League
(
League_Id int identity(1,1),
League_Name varchar(50) not null,
Country varchar(50),
Total_Players int,
primary key (League_Id),
)

create table Comepteing_Leauges
(
Fantasy_Team_Id int,
Fantasy_Leauge_Id int,
primary key (Fantasy_Team_Id,Fantasy_Leauge_Id),
foreign key (Fantasy_Team_Id) references Fantasy_Player_Team,
foreign key (Fantasy_Leauge_Id) references Fantasy_League,
)