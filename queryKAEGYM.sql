USE equipod;

-- Tabla Usuarios
CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY, -- IDENTITY(1,1) es igual que el auto_increment
    nombre VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    telefono VARCHAR(15),
    dni VARCHAR(9) NOT NULL UNIQUE,
    direccion VARCHAR(255),
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    tipo_usuario VARCHAR(20) NOT NULL CHECK (tipo_usuario IN ('Cliente', 'Monitor', 'Administrador'))
);

INSERT INTO Usuarios VALUES ('Andoni','Pastrana','','11111111R','','andoniAD@gmail.com','45b17ecb20','Administrador');
INSERT INTO Usuarios VALUES ('Kevin','Villarreal','','22222222R','','kevinAD@gmail.com','45b17ecb20','Administrador');
INSERT INTO Usuarios VALUES ('Eugenio','Lorente','','33333333R','','eugenioAD@gmail.com','45b17ecb20','Administrador');

-- Tabla Clientes 
CREATE TABLE Clientes (
    email VARCHAR(100) PRIMARY KEY,
    ccc VARCHAR(24) NOT NULL,
    FOREIGN KEY (email) REFERENCES Usuarios(email) ON DELETE CASCADE
);

-- Tabla Monitores 
CREATE TABLE Monitores (
    email VARCHAR(100) PRIMARY KEY,
    FOREIGN KEY (email) REFERENCES Usuarios(email) ON DELETE CASCADE
);

-- Tabla Administradores
CREATE TABLE Administradores (
    email VARCHAR(100) PRIMARY KEY,
    FOREIGN KEY (email) REFERENCES Usuarios(email) ON DELETE CASCADE
);

INSERT INTO Administradores VALUES ('andoniAD@gmail.com');
INSERT INTO Administradores VALUES ('kevinAD@gmail.com');
INSERT INTO Administradores VALUES ('eugenioAD@gmail.com');



-- Tabla Actividades 
CREATE TABLE Actividades (
    id_actividad INT IDENTITY(1,1) PRIMARY KEY,
    nombre_actividad VARCHAR(100) NOT NULL UNIQUE,
    descripcion VARCHAR(100) NOT NULL,
    email_monitor VARCHAR(100),
	valoracion_media float,
    FOREIGN KEY (email_monitor) REFERENCES Monitores(email) ON DELETE SET NULL
);

-- Tabla Valoraciones
CREATE TABLE Valoraciones (
    id_valoracion INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_actividad INT NOT NULL,
    valoracion INT NOT NULL CHECK (valoracion BETWEEN 1 AND 5),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario) ON DELETE CASCADE,
    FOREIGN KEY (id_actividad) REFERENCES Actividades(id_actividad) ON DELETE CASCADE
);

-- Tabla Usuarios_Actividades
CREATE TABLE Usuarios_Actividades (
    id_ActividadUsuario INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_actividad INT NOT NULL,
	valoracion int,
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario) ON DELETE CASCADE,
    FOREIGN KEY (id_actividad) REFERENCES Actividades(id_actividad) ON DELETE CASCADE
);



INSERT INTO Usuarios VALUES ('Sin Monitor', '','','','','SinMonitor@sinmonitor.com','Sin Monitor','Monitor');
INSERT INTO Monitores VALUES ('SinMonitor@sinmonitor.com');
