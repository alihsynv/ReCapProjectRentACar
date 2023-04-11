USE [master]
GO

CREATE DATABASE RentACar
GO

USE RentACar
GO

CREATE TABLE Brands (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL
)

CREATE TABLE Colors (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL
)

CREATE TABLE Cars (
    Id INT PRIMARY KEY IDENTITY,
    BrandId INT FOREIGN KEY REFERENCES Brands(Id),
    ColorId INT FOREIGN KEY REFERENCES Colors(Id),
    Name NVARCHAR(50) NOT NULL,
    ModelYear INT NOT NULL,
    DailyPrice MONEY NOT NULL,
    Description NVARCHAR(MAX)
)

USE RentACar
GO

-- Add data to the Brands table
INSERT INTO Brands (Name) VALUES ('Toyota')
INSERT INTO Brands (Name) VALUES ('Honda')
INSERT INTO Brands (Name) VALUES ('Nissan')
INSERT INTO Brands (Name) VALUES ('Chevrolet')
INSERT INTO Brands (Name) VALUES ('Hyundai')
INSERT INTO Brands (Name) VALUES ('Ford')
INSERT INTO Brands (Name) VALUES ('Dodge')

-- Add data to the Colors table
INSERT INTO Colors (Name) VALUES ('Silver')
INSERT INTO Colors (Name) VALUES ('Blue')
INSERT INTO Colors (Name) VALUES ('Green')
INSERT INTO Colors (Name) VALUES ('Yellow')
INSERT INTO Colors (Name) VALUES ('Purple')

-- Add data to the Cars table
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (1, 2, 'Toyota Camry', 2021, 200, 'Mid-size sedan')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (2, 1, 'Honda Civic', 2022, 180, 'Compact car')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (3, 3, 'Nissan Altima', 2021, 220, 'Mid-size sedan')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (4, 2, 'Chevrolet Camaro', 2023, 300, 'Muscle car')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (5, 4, 'Hyundai Kona', 2021, 150, 'Compact SUV')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (1, 5, 'Toyota Prius', 2022, 170, 'Hybrid car')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (2, 1, 'Honda Accord', 2023, 230, 'Mid-size sedan')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (3, 2, 'Nissan Maxima', 2022, 240, 'Full-size sedan')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (4, 3, 'Chevrolet Equinox', 2021, 200, 'Compact SUV')
INSERT INTO Cars (BrandId, ColorId, Name, ModelYear, DailyPrice, Description) 
VALUES (5, 4, 'Hyundai Santa Fe', 2023, 270, 'Mid-size SUV')
