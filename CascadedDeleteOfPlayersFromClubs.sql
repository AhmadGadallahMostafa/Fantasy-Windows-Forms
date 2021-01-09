alter table Footballer
drop constraint FK__Footballe__Club___267ABA7A;

alter table Footballer
add constraint Club_ID_FK
foreign key (Club_ID)
references Club (Club_Id)
on delete cascade;