alter table Plays_In_Fantasy_Team
drop constraint FK__Plays_In___Fanta__3F466844;

alter table Plays_In_Fantasy_Team
add constraint Player_ID_FK
foreign key (Player_ID)
references Footballer (Player_ID)
on delete cascade;



alter table Plays_In_Fantasy_Team
drop constraint FK__Plays_In___Playe__3E52440B;

alter table Plays_In_Fantasy_Team
add constraint Fantasy_Team_Id_FK
foreign key (Fantasy_Team_Id)
references Fantasy_Player_Team (Fantasy_Team_ID)
on delete cascade;