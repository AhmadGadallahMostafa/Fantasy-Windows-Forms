create database fantasy
USE [Fantasy]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Email] [varchar](255) NOT NULL,
	[Date_Of_Birth] [date] NULL,
	[Account_Type] [int] NULL,
	[Password] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Club]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Club](
	[Club_Id] [int] IDENTITY(1,1) NOT NULL,
	[Club_Rank] [int] NULL,
	[Club_Name] [varchar](50) NOT NULL,
	[Club_Points] [int] NULL,
	[Goals_Against] [int] NULL,
	[Total_Goals] [int] NULL,
	[Stadium_Name] [varchar](50) NULL,
	[ManagerName] [varchar](50) NULL,
	[FoundationDate] [varchar](50) NULL,
	[inFpl] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Club_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Club_Fixtures]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Club_Fixtures](
	[Host_id] [int] NOT NULL,
	[Guest_Id] [int] NOT NULL,
	[Week_number] [int] NOT NULL,
	[Season_number] [int] NOT NULL,
	[Score] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Host_id] ASC,
	[Guest_Id] ASC,
	[Week_number] ASC,
	[Season_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comepteing_Leauges]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comepteing_Leauges](
	[Fantasy_Team_Id] [int] NOT NULL,
	[Fantasy_Leauge_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Fantasy_Team_Id] ASC,
	[Fantasy_Leauge_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fantasy_League]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fantasy_League](
	[League_Id] [int] IDENTITY(1,1) NOT NULL,
	[League_Name] [varchar](50) NOT NULL,
	[Country] [varchar](50) NULL,
	[Total_Players] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[League_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fantasy_Player_Team]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fantasy_Player_Team](
	[Player_Username] [varchar](50) NOT NULL,
	[Age] [int] NULL,
	[Email] [varchar](255) NULL,
	[Fantasy_Team_ID] [int] IDENTITY(1,1) NOT NULL,
	[Team_Name] [varchar](50) NULL,
	[Total_Value] [int] NULL,
	[Team_Funds] [int] NULL,
	[Total_Points] [int] NULL,
	[Total_Transfers] [int] NULL,
	[Overall_Rank] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Fantasy_Team_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Footballer]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Footballer](
	[Player_Id] [int] IDENTITY(1,1) NOT NULL,
	[Club_ID] [int] NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Poisition] [int] NULL,
	[Price] [int] NULL,
	[Goals] [int] NULL,
	[Assists] [int] NULL,
	[Age] [int] NULL,
	[CleanSheets] [int] NULL,
	[points] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Player_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plays_In_Fantasy_Team]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plays_In_Fantasy_Team](
	[Player_ID] [int] NOT NULL,
	[Fantasy_Team_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Player_ID] ASC,
	[Fantasy_Team_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Season]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Season](
	[Season_Number] [int] IDENTITY(1,1) NOT NULL,
	[year] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Season_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transfered]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfered](
	[Player_ID] [int] NOT NULL,
	[Week_Number] [int] NOT NULL,
	[Season_Number] [int] NOT NULL,
	[Fantasy_Team_ID] [int] NOT NULL,
	[status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Player_ID] ASC,
	[Week_Number] ASC,
	[Season_Number] ASC,
	[Fantasy_Team_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unavailable_Player]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unavailable_Player](
	[ID] [int] NOT NULL,
	[Suspension_Status] [bit] NULL,
	[Start_Date] [date] NOT NULL,
	[Duration] [int] NULL,
	[Injury_Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[Start_Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Week]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Week](
	[Week_Number] [int] IDENTITY(1,1) NOT NULL,
	[Season_Number] [int] NOT NULL,
	[Start_Date] [date] NULL,
	[End_Date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Week_Number] ASC,
	[Season_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Club] ON 

INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (1, 1, N'Manchester United', 0, 0, 0, N'Old Trafford', N'Solskjaer', N'1902', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (2, 2, N'Manchester City', 0, 0, 0, N'Ethiad', N'Guardiola', N'1880', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (3, 3, N'Spurs', 0, 0, 0, N'Spurs Stadium', N'Mourinho', N'1882', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (4, 4, N'Chelsea', 0, 0, 0, N'Stamford Bridge', N'Lampard', N'1905', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (5, 5, N'LiverPool', 0, 0, 0, N'Anfield', N'Klopp', N'1892', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (6, 6, N'Arsenal', 0, 0, 0, N'Emiartes', N'Arteta', N'1886', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (7, 7, N'Aston Villa', 0, 0, 0, N'Smith', N' Villa Park', N'1874', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (8, 8, N'Brighton', 0, 0, 0, N'Potter', N'Falmer', N'1901', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (9, 9, N'Burnely', 0, 0, 0, N'Dyche', N'Turf Moor', N'1882', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (10, 10, N'Crystal Palace', 0, 0, 0, N'Hodgson', N'Selhurst Park', N'1905', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (11, 11, N'Everton', 0, 0, 0, N'Ancelotti', N'Goodison Park', N'1878', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (12, 12, N'Fulham', 0, 0, 0, N'Parker', N'Craven Cottage', N'1879', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (13, 13, N'Leeds United', 0, 0, 0, N'Bielsa', N'Ellan Road', N'1919', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (14, 14, N'Leicester City', 0, 0, 0, N'Rodgers', N'King Power', N'1884', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (15, 15, N'Newcastle United', 0, 0, 0, N'Bruce', N'St James Park', N'1892', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (16, 16, N'Sheffield', 0, 0, 0, N'Wilder', N'Bramall Lane', N'1889', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (17, 17, N'Southampton', 0, 0, 0, N'Hasenhuttl', N'St Mary', N'1885', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (18, 18, N'West Bromich', 0, 0, 0, N'Allardyce', N'Hawthorns', N'1878', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (19, 19, N'West Ham', 0, 0, 0, N'Moyes', N'London Stadium', N'1900', 1)
INSERT [dbo].[Club] ([Club_Id], [Club_Rank], [Club_Name], [Club_Points], [Goals_Against], [Total_Goals], [Stadium_Name], [ManagerName], [FoundationDate], [inFpl]) VALUES (20, 20, N'Wolves', 0, 0, 0, N'Nuno', N'Molineux', N'1877', 1)
SET IDENTITY_INSERT [dbo].[Club] OFF
GO
SET IDENTITY_INSERT [dbo].[Fantasy_Player_Team] ON 

INSERT [dbo].[Fantasy_Player_Team] ([Player_Username], [Age], [Email], [Fantasy_Team_ID], [Team_Name], [Total_Value], [Team_Funds], [Total_Points], [Total_Transfers], [Overall_Rank]) VALUES (N'111', 26, N'ahmadgad@gmail.com', 1, NULL, 0, 100, 0, 1, 1)
SET IDENTITY_INSERT [dbo].[Fantasy_Player_Team] OFF
GO
SET IDENTITY_INSERT [dbo].[Footballer] ON 

INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (1, 1, N'David', N'De Gea', 0, 5, 0, 0, 30, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (2, 1, N'Luke', N'Shaw', 1, 5, 0, 0, 30, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (3, 1, N'Vector', N'Lindelof', 1, 5, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (4, 1, N'Wan', N'Bissaka', 1, 6, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (5, 1, N'Harry', N'Maguire', 1, 2, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (6, 1, N'Bruno', N'Fernandez', 2, 10, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (7, 1, N'Paul', N'Pogba', 2, 8, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (8, 1, N'Antony', N'Martial', 2, 8, 0, 0, 25, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (9, 1, N'Donny', N'Van de beek', 2, 8, 0, 0, 23, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (10, 1, N'Marcus', N'Rashford', 3, 7, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (11, 1, N'Edisnon', N'Cavani', 3, 8, 0, 0, 33, 0, 0)

INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (12, 2, N'Ederson', N'Mutually', 0, 6, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (13, 2, N'Kyle', N'Walker', 1, 6, 0, 0, 30, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (14, 2, N'joaa', N'Cancelo', 1, 5, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (15, 2, N'john', N'Stones', 1, 5, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (16, 2, N'Nathan', N'Ake', 1, 5, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (17, 2, N'Kevin', N'De Bryune', 2, 11, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (18, 2, N'Ilkay', N'Goundogan', 2, 5, 0, 0, 29, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (19, 2, N'Riyad', N'Mahrez', 2, 8, 0, 0, 28, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (20, 2, N'Raheem', N'Sterling', 2, 9, 0, 0, 26, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (21, 2, N'Sergio', N'Aguero', 3, 10, 0, 0, 33, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (22, 2, N'Phill', N'Foden', 3, 7, 0, 0, 20, 0, 0)

INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (23, 3, N'Hugo', N'Loris', 0, 5, 0, 0, 33, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (24, 3, N'Sergi', N'Aurier', 1, 5, 0, 0, 25, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (25, 3, N'Eric', N'Dier', 1, 5, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (26, 3, N'Victor', N'Sanchez', 1, 6, 0, 0, 25, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (27, 3, N'Matt', N'Doherty', 1, 5, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (28, 3, N'Deli', N'Ali', 2, 7, 0, 0, 23, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (29, 3, N'Heung-min', N'Son', 2, 10, 0, 0, 29, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (30, 3, N'Tanguy', N'Ndombele', 2, 7, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (31, 3, N'Giovani', N'Lo Celso', 2, 8, 0, 0, 26, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (32, 3, N'Harry', N'Kane', 3, 10, 0, 0, 29, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (33, 3, N'Lucas', N'Moura', 3, 7, 0, 0, 28, 0, 0)

INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (34, 4, N'Edward', N'Mendy', 0, 5, 0, 0, 28, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (35, 4, N'Thiago', N'Silva', 1, 5, 0, 0, 35, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (36, 4, N'Kurt', N'Zouma', 1, 5, 0, 0, 25, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (37, 4, N'Bin', N'Chilwell', 1, 5, 0, 0, 26, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (38, 4, N'Reese', N'James', 1, 5, 0, 0, 22, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (39, 4, N'Ngolo', N'Kante', 2, 5, 0, 0, 28, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (40, 4, N'Christian', N'Pulisic', 2, 8, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (41, 4, N'Kai', N'Havertz', 2, 8, 0, 0, 23, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (42, 4, N'Hakim', N'Ziyech', 2, 8, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (43, 4, N'Olivier', N'Giroud', 3, 6, 0, 0, 32, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (44, 4, N'Timo', N'Werner', 3, 9, 0, 0, 23, 0, 0)

INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (45, 5, N'Alisson', N'Becker', 0, 6, 0, 0, 28, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (46, 5, N'Virgil', N'Van-Dijk', 1, 6, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (47, 5, N'Trent', N'Arnold', 1, 7, 0, 0, 25, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (48, 5, N'Andy', N'Robertson', 1, 6, 0, 0, 26, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (49, 5, N'Joel', N'Matip', 1, 4, 0, 0, 28, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (50, 5, N'Thiago', N'Alcantara', 2, 5, 0, 0, 30, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (51, 5, N'Nabi', N'Kieta', 2, 5, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (52, 5, N'Jordan', N'Henderson', 2, 6, 0, 0, 31, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (53, 5, N'Georgino', N'Wijnaldum', 2, 5, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (54, 5, N'Mohamed', N'Salah', 3, 12, 0, 0, 28, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (55, 5, N'Sadio', N'Mane', 3, 11, 0, 0, 28, 0, 0)

INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (56, 6, N'Bernd', N'Leno', 0, 6, 0, 0, 28, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (57, 6, N'David', N'Luiz', 1, 5, 0, 0, 33, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (58, 6, N'Hector', N'Bellerin', 1, 6, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (59, 6, N'Robb', N'Holding', 1, 5, 0, 0, 25, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (60, 6, N'Kieran', N'Tierny', 1, 6, 0, 0, 33, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (61, 6, N'Mohamed', N'EL-Neny', 2, 5, 0, 0, 30, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (62, 6, N'Dani', N'Ceballos', 2, 5, 0, 0, 27, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (63, 6, N'Granit', N'Xhaka', 2, 5, 0, 0, 25, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (64, 6, N'Tomas', N'Parte', 2, 5, 0, 0, 24, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (65, 6, N'Pierre', N'Aubamayoung', 3, 8, 0, 0, 28, 0, 0)
INSERT [dbo].[Footballer] ([Player_Id], [Club_ID], [First_Name], [Last_Name], [Poisition], [Price], [Goals], [Assists], [Age], [CleanSheets], [points]) VALUES (66,6, N'Alexander', N'Lacazete', 3, 8, 0, 0, 28, 0, 0)
SET IDENTITY_INSERT [dbo].[Footballer] OFF
GO
ALTER TABLE [dbo].[Footballer] ADD  CONSTRAINT [df_Goals]  DEFAULT ((0)) FOR [Goals]
GO
ALTER TABLE [dbo].[Footballer] ADD  CONSTRAINT [df_Assists]  DEFAULT ((0)) FOR [Assists]
GO
ALTER TABLE [dbo].[Footballer] ADD  CONSTRAINT [df_CleanSheets]  DEFAULT ((0)) FOR [CleanSheets]
GO
ALTER TABLE [dbo].[Club_Fixtures]  WITH CHECK ADD FOREIGN KEY([Guest_Id])
REFERENCES [dbo].[Club] ([Club_Id])
GO
ALTER TABLE [dbo].[Club_Fixtures]  WITH CHECK ADD FOREIGN KEY([Host_id])
REFERENCES [dbo].[Club] ([Club_Id])
GO
ALTER TABLE [dbo].[Club_Fixtures]  WITH CHECK ADD FOREIGN KEY([Week_number], [Season_number])
REFERENCES [dbo].[Week] ([Week_Number], [Season_Number])
GO
ALTER TABLE [dbo].[Comepteing_Leauges]  WITH CHECK ADD FOREIGN KEY([Fantasy_Team_Id])
REFERENCES [dbo].[Fantasy_Player_Team] ([Fantasy_Team_ID])
GO
ALTER TABLE [dbo].[Comepteing_Leauges]  WITH CHECK ADD FOREIGN KEY([Fantasy_Leauge_Id])
REFERENCES [dbo].[Fantasy_League] ([League_Id])
GO
ALTER TABLE [dbo].[Footballer]  WITH CHECK ADD FOREIGN KEY([Club_ID])
REFERENCES [dbo].[Club] ([Club_Id])
GO
ALTER TABLE [dbo].[Plays_In_Fantasy_Team]  WITH CHECK ADD FOREIGN KEY([Fantasy_Team_Id])
REFERENCES [dbo].[Fantasy_Player_Team] ([Fantasy_Team_ID])
GO
ALTER TABLE [dbo].[Plays_In_Fantasy_Team]  WITH CHECK ADD FOREIGN KEY([Player_ID])
REFERENCES [dbo].[Footballer] ([Player_Id])
GO
ALTER TABLE [dbo].[Transfered]  WITH CHECK ADD FOREIGN KEY([Fantasy_Team_ID])
REFERENCES [dbo].[Fantasy_Player_Team] ([Fantasy_Team_ID])
GO
ALTER TABLE [dbo].[Transfered]  WITH CHECK ADD FOREIGN KEY([Player_ID])
REFERENCES [dbo].[Footballer] ([Player_Id])
GO
ALTER TABLE [dbo].[Transfered]  WITH CHECK ADD FOREIGN KEY([Week_Number], [Season_Number])
REFERENCES [dbo].[Week] ([Week_Number], [Season_Number])
GO
ALTER TABLE [dbo].[Unavailable_Player]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Footballer] ([Player_Id])
GO
ALTER TABLE [dbo].[Week]  WITH CHECK ADD FOREIGN KEY([Season_Number])
REFERENCES [dbo].[Season] ([Season_Number])
GO
/****** Object:  StoredProcedure [dbo].[addFootballer]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  StoredProcedure [dbo].[getClubsByRank]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getClubsByRank]
AS
Begin
	SELECT  Club_Rank, Club_Name,Club_Points,Total_Goals,Goals_Against From Club order by club_rank asc
End
GO
/****** Object:  StoredProcedure [dbo].[getFootballlerNameAndClub]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getFootballlerNameAndClub]
AS
BEGIN
Select Footballer.First_Name,Footballer.Last_Name,Club.Club_Name from Footballer , Club where Footballer.Club_ID = Club.Club_Id; 
END
GO
/****** Object:  StoredProcedure [dbo].[getPointsByName]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getPointsByName]
	@Fname varchar(55),
	@lname varchar(55)
AS
begin
	SELECT Footballer.points from Footballer where Footballer.Last_Name = @lname and Footballer.First_Name = @Fname  
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePoints]    Script Date: 1/9/2021 8:39:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[UpdatePoints]
	@Fname varchar(55),
	@Lname varchar(55),
	@points int
AS
begin
	update Footballer set points = @points where First_Name = @Fname and Last_Name = @Lname
end
GO
