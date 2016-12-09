DROP DATABASE ProjektarbeteDB;
CREATE DATABASE ProjektarbeteDB;
Use ProjektarbeteDB;

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


DROP TABLE Employees;
DROP TABLE Stores;
DROP TABLE Roles;

CREATE TABLE Employees (
    [ID]        INT             PRIMARY KEY IDENTITY NOT NULL,
    [FirstName] VARCHAR (50)    NOT NULL,
    [LastName]  VARCHAR (50)    NOT NULL,
    [Email]     VARCHAR (150)   NOT NULL,
    [OnLeave]   BIT             NULL,
    [Role]      INT             NULL,
    [Salary]    DECIMAL (12, 2) NULL,
    [Birthdate] DATETIME        NULL,
    [Store]     INT             NOT NULL
);

CREATE TABLE Stores (
    [Id]   INT           PRIMARY KEY IDENTITY NOT NULL,
    [Name] VARCHAR (100) NOT NULL
);

CREATE TABLE Roles (
    [Id]   INT           PRIMARY KEY IDENTITY NOT NULL,
    [Name] VARCHAR (100) NOT NULL
);

--Add some users
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Anna', 'Larsson', 'annalarsson@gmail.com', 'True', 2, '240000', '20151129', 4)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Jouni', 'Saarinen', 'jounisaarinen@inspecta.com', 'True', 3, '180000', '19661129', 1)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Robert', 'Solomon', 'robson@gmail.com', 'True', 2, '250000', '19871129', 1)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Ándreas', 'Svensson', 'adde1337@gmail.com', 'True', 3, '1900000', '19811001', 3)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Lisa', 'Samuelsson', 'lisam@outlook.se', 'True', 3, '180000', '19661129', 6)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Jonas', 'Rydberg', 'rydberg@gmail.com', 'True', 4, '250000', '19871129', 5)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Sten', 'Fridolfsson', 'stenfr@gmail.com', 'True', 2, '1900000', '19850805', 3)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Anders', 'Saarinen', 'asaar@google.com', 'True', 3, '180000', '19651223', 4)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Carl', 'Skogsmo', 'carlskgsm@gmail.com', 'True', 2, '250000', '19930221', 2)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('George', 'Skoglund', 'george.skoglund@gmail.com', 'True', 5, '1900000', '19800503', 3)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Walter', 'Ljung', 'walter@ljung.co.uk', 'True', 3, '180000', '19800101', 2)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Madison', 'Andersson', 'maddismadde@gmail.com', 'True', 5, '250000', '19881011', 4)
INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) 
VALUES ('Lee', 'Sun-Yung', 'lsuyu@net.kr.ax', 'True', 6, '284500.50', '19560101', 3)


--Add some stores
INSERT INTO Stores (Name)
VALUES ('Stadium Örebro')
INSERT INTO Stores (Name)
VALUES ('Stadium Göteborg')
INSERT INTO Stores (Name)
VALUES ('Stadium Stockholm')
INSERT INTO Stores (Name)
VALUES ('Stadium Helsingborg')
INSERT INTO Stores (Name)
VALUES ('Stadium Göteborg City')
INSERT INTO Stores (Name)
VALUES ('Stadium Kalix')

--Add some roles!
INSERT INTO Roles(Name)
VALUES ('Intern')
INSERT INTO Roles(Name)
VALUES ('Part Time')
INSERT INTO Roles(Name)
VALUES ('Full Time')
INSERT INTO Roles(Name)
VALUES ('Store Manager')
INSERT INTO Roles(Name)
VALUES ('Regional Manager')
INSERT INTO Roles(Name)
VALUES ('Board Member')
INSERT INTO Roles(Name)
VALUES ('CEO')


