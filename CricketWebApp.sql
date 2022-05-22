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

INSERT INTO Country values
('Nepal','South-Asia','+977'),
('India','South-Asia','+91'),
('England','Europe','+44'),
('New Zealand','Oceania','+64'),
('West Indies','Americas','+868')

INSERT INTO Players values
('Sandeep Lamichanne', 21),
('Gyanendra Malla', 31), 
('Binod Bhandari', 32), 
('Aarif Sheikh', 31), 
('Kushal Bhurtel', 25),
('Rohit Paudel', 19), 
('Lokesh Bam', 18), 
('Bhim Sharki', 20), 
('Dev Khanal', 16), 
('Sompal Kami', 26), 
('Kushal Malla', 18)

INSERT INTO Players values
('Rohit Sharma',35),
('Virat Kohli',33),
('Jasprit Bumrah',28),
('KL Rahul',30),
('Mohammed Shami',31),
('Rishabh Pant',24),
('Ravindra Jadeja',33),
('Shreyas Iyer',27),
('Shardul Thakur',30),
('Ravichandran Ashwin',35),
('Shikhar Dhawan',36);

INSERT INTO Players values
('Moeen Ali',34),
('Joe Root',31),
('Jos Buttler',31),
('Mark Wood',32),
('Jason Roy',31),
('Ben Stokes',30),
('Sam Curran',23),
('Liam Livingstone',28),	
('Eoin Morgan',35),
('Jofra Archer',27),
('Adil Rashid',34);

INSERT INTO Players values
('Ross Taylor',38),
('Matt Henry',30),
('Colin Munro',35),
('Kane Williamson',31),
('Ish Sodhi',29),
('Martin Guptill',35),
('James Neesham',31),
('Tom Latham',30),
('Tim Southee',33),
('Colin de Grandhomme',35),
('Lockie Ferguson',30);

INSERT INTO Players values
('Kraigg Brathwaite', 23),
('Evin Lewis', 25),
('Darren Bravo', 33),
('John Campbell', 26),
('Kyle Marks', 28),
('Chris Gyale', 42),
('Brandon King', 27),
('Odean Smiths', 25),
('Shai Hope', 28),
('Akeal Hosain', 32),
('Jason Hodler', 30);

INSERT INTO Matches values
(1,'Nepal','India','','2022-01-01 10:00:00',''),
(2,'England','New Zealand','','2022-01-29 11:00:00',''),  
(3,'New Zealand','Nepal','','2022-02-02 12:30:00',''),  
(4,'England','West Indies','','2022-02-22 13:30:00',''),  
(5,'New Zealand','Engkand','','2022-03-03 14:00:00',''),  
(6,'India','Nepal','','2022-03-23 15:30:00',''),  
(7,'New Zealand','Nepal','','2022-04-04 16:30:00',''),  
(8,'England','India','','2022-04-24 17:30:00',''),  
(9,'West Indies','India','','2022-05-05 19:18:00',''),  
(10,'New Zealand','West Indies','','2022-05-25 19:00:00','');

 