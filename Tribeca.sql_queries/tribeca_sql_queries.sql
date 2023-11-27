--thinking process

-- 1. create database "tribeca_test"
CREATE DATABASE tribeca_test;

-- 2. create table "clients". Primary key makes sure that id is unique
CREATE TABLE Clients (
    clientId int PRIMARY KEY NOT NULL,	
	Name VARCHAR(255)
);

-- 3. create table "Offices"
-- foreign keys creates clear relactionships with tables: consistant and valid
-- foreign keys link tables with referential relationships
--(i.e. Offices.ClientID references Clients.clientId
-- used bit for boolean value if it is clients head office

CREATE TABLE Offices (
    OfficeID int PRIMARY KEY NOT NULL,
    ClientID int NOT NULL,
    Address VARCHAR(255) NOT NULL,
	IsHeadOffice bit NULL DEFAULT 0,	
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

-- 4. create table "Employees"


-- 4. create table "Employees"
CREATE TABLE Employees (
    EmployeeID int PRIMARY KEY,
    ClientID int,
    OfficeID int,
    Name VARCHAR(255) NOT NULL,
    Bio TEXT,
    DateOfBirth DATE,
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
    FOREIGN KEY (OfficeID) REFERENCES Offices(OfficeID)
);

-- 5. insert data Clients into "Clients" database
INSERT INTO Clients (ClientID, Name)
VALUES
(1, 'Client A'),
(2, 'Client B'),
(3, 'Client C');

-- 6. insert office info into "Offices" table
INSERT INTO Offices (OfficeID, ClientID, Address, IsHeadOffice)
 VALUES
(1, 1, '123 Street',0),
(2, 1, '66 Road',0),
(3, 1, '11 Spooner Road',1),
(4, 2, '123 Flight Street',0),
(5, 2, '64 Zoo Lane',1),
(6, 2, '22 Round Tree Road',0),
(7, 3, '33 Mile Street',1),
(8, 3, '66 Road',0),
(9, 3, '44 Sprinkle Road',0);


-- 7.  Inserting employees intormation to "Employees" table
INSERT INTO Employees (EmployeeID, ClientID, OfficeID, Name, Bio, DateOfBirth) VALUES
(1, 1, 1, 'Sam Fisher', 'I love snowboarding and dogs', '2001-02-11'),
(2, 1, 2, 'John Fisher', 'I live in a yellow submarine', '1992-01-14'),
(3, 1, 3, 'Peter Fisher', 'Flowers are great!', '1995-08-11'),
(4, 2, 4, 'Sam Kemp', 'Fish are friends, not food.', '1992-01-14'),
(5, 2, 5, 'John Kemp', 'I live in a blue submarine', '1980-03-16'),
(6, 2, 6, 'Peter Kemp', 'Coffee is the best!', '1997-08-14'),
(7, 3, 7, 'John Doe', 'I hate robots!', '1982-04-16'),
(8, 3, 8, 'Jane Doe', 'Life is like a house of cards', '1991-09-19'),
(9, 3, 9, 'Peter Doe', 'Birds fly around my head!', '1995-07-22');



---Testing queries on database EmployeeDb
CREATE TABLE Employees (
    EmpId int NOT NULL, 
    EmpName VARCHAR(255) NOT NULL,
    EmpContact VARCHAR(255) NOT NULL,
    EmpEmail VARCHAR(255) NOT NULL,
    EmpAddress VARCHAR(255) NOT NULL,
);

--testing ends