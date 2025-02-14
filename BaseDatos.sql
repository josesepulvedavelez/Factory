
CREATE DATABASE Factory;
USE Factory;

CREATE TABLE Usuario
(
    UsuarioId INT IDENTITY(1, 1) PRIMARY KEY,

    Nombre VARCHAR(100),
    Identificacion VARCHAR(15),
    Correo VARCHAR(500),
    UserName VARCHAR(20) UNIQUE,
    Pass VARCHAR(10)
);

CREATE TABLE ComicFavorito
(
	ComicFavoritoId INT IDENTITY(1, 1) PRIMARY KEY,

	Id INT,
	Title VARCHAR(255),
	Path VARCHAR(MAX),
	Extension NVARCHAR(10),

	UsuarioId INT FOREIGN KEY REFERENCES Usuario(UsuarioId)
);