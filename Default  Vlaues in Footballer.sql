ALTER TABLE Footballer
ADD CONSTRAINT df_Goals
DEFAULT 0 FOR Goals;

ALTER TABLE Footballer
ADD CONSTRAINT df_Assists
DEFAULT 0 FOR Assists;

ALTER TABLE Footballer
ADD CONSTRAINT df_CleanSheets
DEFAULT 0 FOR CleanSheets;

