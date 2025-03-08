CREATE DATABASE DB_Proyecto

USE DB_Proyecto

CREATE TABLE Usuario(
Email VARCHAR(100) NOT NULL PRIMARY KEY,
NomCompleto VARCHAR(100) NOT NULL,
FechaNacimiento DATE,
Genero CHAR(1) DEFAULT 'M',
Estatus INT DEFAULT 1, -- 1 Activo 0 Inactivo
Recordar INT DEFAULT 0, -- 0 No recordar 1 Recordar
Fuente INT,
FechaAlta DATETIME,
FechaBaja DATETIME,
ApPaterno VARCHAR(50),
ApMaterno VARCHAR(50),
);

CREATE TABLE Contraseña(
IdContraseña INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Contraseña VARCHAR(25) NOT NULL,
Usuario  VARCHAR(100) NOT NULL,
Estado INT DEFAULT 1, --1 Activo 0 Inactivo, 2 temporal

FOREIGN KEY(Usuario)REFERENCES Usuario(Email)
);

CREATE TABLE Filtro(
IdFiltro INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NombreFiltro VARCHAR(20),

);

CREATE TABLE Busqueda(
IdBusqueda INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
PalabrasBuscadas VARCHAR(100),
Filtro INT NOT NULL,
Idioma VARCHAR(20) NOT NULL,
NVersion VARCHAR(30) NOT NULL,
Testamento VARCHAR(20),
Libro VARCHAR(20),
Usuario  VARCHAR(100) NOT NULL,
FechaBusqueda DATETIME,

	FOREIGN KEY (Filtro) REFERENCES Filtro(IdFiltro),
	FOREIGN KEY(Usuario)REFERENCES Usuario(Email)
);

CREATE TABLE Favorito(

IdFavorito INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
NomFavorito VARCHAR(50) NOT NULL,
NVersion VARCHAR(30) NOT NULL,
Testamento VARCHAR(20) NOT NULL,
Libro VARCHAR(20) NOT NULL,
NumeroCap TINYINT NOT NULL,
EsCapitulo INT DEFAULT 0, --0 No es Cap, 1 Si es cap
Versiculo TINYINT,
Texto TEXT,
Usuario  VARCHAR(100) NOT NULL,
FechaAgregado SMALLDATETIME,

FOREIGN KEY(Usuario)REFERENCES Usuario(Email)
);

CREATE TABLE MetodoRecuperacion(
IdMetodo INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Pregunta VARCHAR(100)NOT NULL,
Respuesta VARCHAR(30)NOT NULL,
Usuario  VARCHAR(100) NOT NULL,

FOREIGN KEY(Usuario)REFERENCES Usuario(Email)

);
