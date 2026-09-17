CREATE DATABASE ItensDB;
GO

USE ItensDB;
GO

CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(200) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    Senha VARBINARY(32) NOT NULL
);
GO

CREATE TABLE Item (
    IdItem INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(200) NOT NULL,
    Quantidade INT NOT NULL,
    Comprado BIT NOT NULL DEFAULT 0,
    IdUsuario INT NOT NULL,

    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);
GO

INSERT INTO Usuario (Nome, Email, Senha)
VALUES (
    'Fulano',
    'fulano@email.com',
    HASHBYTES('SHA2_256', '123456')
);
GO

INSERT INTO Item (Nome, Quantidade, Comprado, IdUsuario)
VALUES (
    'Coisa',
    1,
    0,
    1
);
GO

SELECT * FROM Usuario;
SELECT * FROM Item;