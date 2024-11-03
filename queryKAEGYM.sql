-- Crear base de datos

USE equipod;

-- Tabla Usuarios
CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY, --IDENTITY(1,1) funciona igual que el AUTO_INCREMENT
    nombre VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    telefono VARCHAR(15),
    dni VARCHAR(9) NOT NULL,
    direccion VARCHAR(255),
    ccc VARCHAR(24) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    tipo_usuario VARCHAR(50) NOT NULL
);

-- Tabla Actividades
CREATE TABLE Actividades (
    id_actividad INT IDENTITY(1,1) PRIMARY KEY,
    nombre_actividad VARCHAR(100) NOT NULL UNIQUE
);

-- Tabla Valoraciones
CREATE TABLE Valoraciones (
    id_valoracion INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_actividad INT NOT NULL,
    valoracion INT NOT NULL,
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_actividad) REFERENCES Actividades(id_actividad)
);

-- Tabla Monitores_Actividades
CREATE TABLE Monitores_Actividades (
    id_monitor INT NOT NULL,
    id_actividad INT NOT NULL,
    PRIMARY KEY (id_monitor, id_actividad),
    FOREIGN KEY (id_monitor) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_actividad) REFERENCES Actividades(id_actividad)
);

-- Tabla Usuarios_Actividades
CREATE TABLE Usuarios_Actividades (
    id_usuario INT NOT NULL,
    id_actividad INT NOT NULL,
    PRIMARY KEY (id_usuario, id_actividad),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_actividad) REFERENCES Actividades(id_actividad)
);
