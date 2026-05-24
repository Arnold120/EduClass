USE master
GO

CREATE DATABASE BDEduClass
GO

USE BDEduClass
GO

CREATE TABLE Usuario(
	NombreUsuario VARCHAR(100) UNIQUE,
	Contrasena VARCHAR(100),
	Salt VARBINARY(64),
	FechaRegistro DATETIME,
	Genero VARCHAR(20),
	Telefono VARCHAR(20),
    Direccion VARCHAR(200),
	UltimaActividad DATETIME,
	EnSesion BIT DEFAULT 0
);

CREATE TABLE Roles(
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    NombreRol VARCHAR(100),
	Descripcion VARCHAR(100),
	Activo BIT DEFAULT 1,
	FechaRegistro DATETIME
);

CREATE TABLE UsuarioRol(
    IdUsuarioRol INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT NOT NULL,
    IdRol INT NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdRol) REFERENCES Roles(IdRol)
);

CREATE TABLE Colegio (
    IdColegio INT PRIMARY KEY IDENTITY(1,1),
    NombreColegio VARCHAR(150),
    Direccion VARCHAR(200),
    Telefono VARCHAR(20),
    Correo VARCHAR(150),
    Logo VARCHAR(255)
);

CREATE TABLE Director_Colegio(
    IdDirector INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT NOT NULL,
    IdColegio INT NOT NULL,
    FechaInicio DATE DEFAULT GETDATE(),
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdColegio) REFERENCES Colegio(IdColegio)
);

CREATE TABLE Grado( 
    IdGrado INT IDENTITY(1,1) PRIMARY KEY,
	NombreSeccion VARCHAR(100),
    Grado NVARCHAR(10) UNIQUE, -- 1ro, 2do, 3ro, 4to, 5to, 6to
	AnioEscolar INT
);

CREATE TABLE Asignatura( 
    IdAsignatura INT IDENTITY(1,1) PRIMARY KEY,
	IdGrado INT,
    NombreAsignatura NVARCHAR(50),
	FecahaRegistro DATETIME,
	FOREIGN KEY (IdGrado) REFERENCES Grado(IdGrado)
);
CREATE TABLE Docente (
    IdDocente INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT,
    IdColegio INT,
	IdGrado INT,
	IdAsignatura INT,
	NombreDocente VARCHAR(250),
	ApellidoDocente VARCHAR(250),
    Especialidad VARCHAR(100),
    FechaRegistro DATE,
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdColegio) REFERENCES Colegio(IdColegio),
	FOREIGN KEY (IdGrado) REFERENCES Grado(IdGrado),
	FOREIGN KEY (IdAsignatura ) REFERENCES Asignatura(IdAsignatura)
);


CREATE TABLE Estudiante (
    IdEstudiante INT PRIMARY KEY IDENTITY(1,1),
	IdDocente INT,
	IdGrado INT,
    IdUsuario INT,
	NombreEstudiante VARCHAR(250),
	ApellidoEstudiante VARCHAR(250),
    FechaIngreso DATE,
    Nivel VARCHAR(50) DEFAULT 'Primaria',
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
	FOREIGN KEY (IdDocente ) REFERENCES Docente(IdDocente),
	FOREIGN KEY (IdGrado) REFERENCES Grado(IdGrado)
);

CREATE TABLE Tutor_Estudiante (
    IdTutor INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT,
	IdDocente INT,
    IdEstudiante INT,
	NombreTutor VARCHAR(250),
	ApellidoTutor VARCHAR(250),
    Parentesco VARCHAR(50), -- Padre, Madre, Abuelo, etc
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante),
	FOREIGN KEY (IdDocente ) REFERENCES Docente(IdDocente),
);

CREATE TABLE Actividades (
    IdActividad INT PRIMARY KEY IDENTITY(1,1),
    IdGrado INT,
	IdDocente INT,
	IdAsignatura INT,
	IdEstudiante INT,
    Titulo VARCHAR(150) NOT NULL,
    Descripcion VARCHAR(300),
    FechaPublicacion DATETIME DEFAULT GETDATE(),
    FechaEntrega DATE,
    PuntosMaximos INT DEFAULT 100,
    FOREIGN KEY (IdGrado) REFERENCES Grado(IdGrado),
	FOREIGN KEY (IdDocente ) REFERENCES Docente(IdDocente),
	FOREIGN KEY (IdAsignatura) REFERENCES Asignatura(IdAsignatura),
	FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante),
);

CREATE TABLE Logros (
    IdLogro INT PRIMARY KEY IDENTITY(1,1),
    NombreLogro VARCHAR(100),
    Descripcion VARCHAR(300),
    PuntosRequeridos INT,
);

CREATE TABLE Logros_Obtenidos (
    IdLogroObtenido INT PRIMARY KEY IDENTITY(1,1),
    IdLogro INT,
    IdEstudiante INT,
    FechaObtencion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdLogro) REFERENCES Logros(IdLogro),
    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante)
);

CREATE TABLE Entregas (
    IdEntrega INT PRIMARY KEY IDENTITY(1,1),
    IdActividad INT,
    IdEstudiante INT,
    ArchivoEntrega VARCHAR(355),
    Comentario VARCHAR(400),
    FechaEntrega DATETIME DEFAULT GETDATE(),
    EstadoEntrega VARCHAR(50) DEFAULT 'Pendiente',
    FOREIGN KEY (IdActividad) REFERENCES Actividades(IdActividad),
    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante)
);

CREATE TABLE Puntaje (
    IdPuntaje INT PRIMARY KEY IDENTITY(1,1),
    IdEntrega INT,
    PuntosObtenidos INT,
    Observacion VARCHAR(400),
    FOREIGN KEY (IdEntrega) REFERENCES Entregas(IdEntrega)
);

CREATE TABLE Perfil (
    IdPerfil INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT,
    FotoPerfil VARCHAR(455),
    Descripcion VARCHAR(300),
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);

CREATE TABLE Mensaje (
    IdMensaje INT PRIMARY KEY IDENTITY(1,1),
    IdUsuarioEmisor INT,
    IdUsuarioReceptor INT,
    Mensaje VARCHAR(MAX),
    FechaEnvio DATETIME DEFAULT GETDATE(),
    Leido BIT DEFAULT 0,
    FOREIGN KEY (IdUsuarioEmisor) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdUsuarioReceptor) REFERENCES Usuario(IdUsuario)
);

CREATE TABLE Mascota (
    IdMascota INT PRIMARY KEY IDENTITY(1,1),
    IdEstudiante INT,
	IdPerfil INT,
    NombreMascota VARCHAR(100),
    TipoMascota VARCHAR(50), -- Perro, Gato, Dragón, etc
    NivelMascota INT DEFAULT 1,
    Experiencia INT DEFAULT 0,
    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante),
	FOREIGN KEY (IdPerfil) REFERENCES Perfil(IdPerfil)
);