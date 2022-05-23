CREATE DATABASE CricketDB
Use CricketDB
Go

CREATE TABLE Country
(
	Country_ID int primary key identity(1,1),
	Country_Name varchar(30),
	Continent varchar(30),
	Country_Code int
)

CREATE TABLE Players
(
	Player_ID int primary key identity(1,1),
	Player_Name varchar(30),
	Age int
)

CREATE TABLE Stadium
(
	Stadium_ID int primary key,
	Stadium_Country int,
	Stadium_Name varchar(30),
	No_of_Matches_Allowed int
)

CREATE TABLE Matches
(
	Match_ID int primary key identity(1,1),
	Stadium_ID int not null,
	Team_A varchar(30),
	Team_B varchar(30),
	Result varchar(10),
	Date_Time smalldatetime,
	Was_Match_Played varchar(5)
)
