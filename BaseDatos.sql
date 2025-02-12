
CREATE DATABASE Factory;
USE Factory;

CREATE TABLE Usuario
(
    UsuarioId INT IDENTITY(1, 1) PRIMARY KEY,

    Nombre VARCHAR(100) NOT NULL,
    Identificacion VARCHAR(15) NOT NULL,
    Correo VARCHAR(500) NOT NULL,
    UserName VARCHAR(10) NOT NULL UNIQUE,
    Pass VARCHAR(10) NOT NULL
);

CREATE TABLE ComicFavorito
(
	ComicFavoritoId INT IDENTITY(1, 1) PRIMARY KEY,

	Id INT NOT NULL,
	Title VARCHAR(255) NOT NULL,
	Path VARCHAR(MAX) NOT NULL,
	Extension NVARCHAR(10) NOT NULL,

	UsuarioId INT FOREIGN KEY REFERENCES Usuario(UsuarioId)
);