--#########################################################################################################################
-- CREATE TABLES
--#########################################################################################################################

-- Users
CREATE TABLE users (
    Id INT IDENTITY(1,1),
    Dni VARCHAR (10) NOT NULL UNIQUE,
    Name VARCHAR(20) NOT NULL,
    Lastname VARCHAR(20) NOT NULL,
    BirthDate DATE NOT NULL,
    Address TEXT NOT NULL,
    PhoneNumber VARCHAR(8) NOT NULL,
    Email TEXT NOT NULL,
    Username VARCHAR(20) NOT NULL UNIQUE,
    Password VARCHAR(64) NOT NULL,
    CreatedBy VARCHAR(20),
    UpdatedBy VARCHAR(20),
    CreationDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdateDate DATETIME,
    FOREIGN KEY (CreatedBy) REFERENCES users(Username),
    FOREIGN KEY (UpdatedBy) REFERENCES users(Username),
    PRIMARY KEY (Id)
); Go


-- Products
CREATE TABLE products (
    Id INT IDENTITY(1,1),
    ProductName VARCHAR(30) NOT NULL,
    ProductPrice INT NOT NULL,
    Stock INT NOT NULL,
    CreatedBy VARCHAR(20),
    UpdatedBy VARCHAR(20),
    CreationDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdateDate DATETIME,
    FOREIGN KEY (CreatedBy) REFERENCES users(Username),
    FOREIGN KEY (UpdatedBy) REFERENCES users(Username),
    PRIMARY KEY (Id)
); Go


-- Clients
CREATE TABLE clients (
    Id INT IDENTITY(1,1),
    Dni VARCHAR (10) NOT NULL UNIQUE,
    Name VARCHAR(20) NOT NULL,
    CreatedBy VARCHAR(20),
    UpdatedBy VARCHAR(20),
    CreationDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdateDate DATETIME,
    FOREIGN KEY (CreatedBy) REFERENCES users(Username),
    FOREIGN KEY (UpdatedBy) REFERENCES users(Username),
    PRIMARY KEY (Id)
); Go


-- Sales
CREATE TABLE sales (
    Id INT IDENTITY(1,1),
    IdClient INT NOT NULL,
    ProductsList TEXT,
    SaleDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Status BIT,
    TotalPrice INT,
    CreatedBy VARCHAR(20),
    UpdatedBy VARCHAR(20),
    CreationDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CreatedBy) REFERENCES users(Username),
    FOREIGN KEY (UpdatedBy) REFERENCES users(Username),
    FOREIGN KEY (IdClient) REFERENCES clients(Id),
    PRIMARY KEY (Id)
);
