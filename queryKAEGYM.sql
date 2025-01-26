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
	numUsuariosApuntados INT, 
	precio_actividad float,
    FOREIGN KEY (email_monitor) REFERENCES Monitores(email) ON DELETE SET NULL
);


-- Tabla Valoraciones actualizada
CREATE TABLE Valoraciones (
    id_valoracion INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_actividad INT NOT NULL,
    valoracion INT NOT NULL CHECK (valoracion BETWEEN 1 AND 5),
    fecha_valoracion DATE, -- Nueva columna para almacenar la fecha de valoración
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario) ON DELETE CASCADE,
    FOREIGN KEY (id_actividad) REFERENCES Actividades(id_actividad) ON DELETE CASCADE
);

-- Tabla Usuarios_Actividades
CREATE TABLE Usuarios_Actividades (
    id_ActividadUsuario INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_actividad INT NOT NULL,
	valoracion int,
	cantidad_servicios int,
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario) ON DELETE CASCADE,
    FOREIGN KEY (id_actividad) REFERENCES Actividades(id_actividad) ON DELETE CASCADE
);



INSERT INTO Usuarios VALUES ('Sin Monitor', '','','','','SinMonitor@sinmonitor.com','Sin Monitor','Monitor');
INSERT INTO Monitores VALUES ('SinMonitor@sinmonitor.com');



haz que las valoraciones sean mas variadas -- Inserción de datos en la tabla Usuarios
INSERT INTO Usuarios (nombre, apellidos, telefono, dni, direccion, email, password, tipo_usuario) VALUES
('Juan', 'García', '123456789', '12345678A', 'Calle Falsa 123', 'juan@gmail.com', 'password1', 'Cliente'),
('María', 'López', '987654321', '87654321B', 'Avenida Siempreviva 456', 'maria@gmail.com', 'password2', 'Cliente'),
('Carlos', 'Martínez', '456789123', '45678912C', 'Plaza Mayor 7', 'carlos@gmail.com', 'password3', 'Cliente'),
('Ana', 'Gómez', '789123456', '78912345D', 'Calle Luna 9', 'ana@gmail.com', 'password4', 'Cliente'),
('Luis', 'Pérez', '321654987', '32165498E', 'Calle Sol 11', 'luis@gmail.com', 'password5', 'Cliente'),
('Laura', 'Hernández', '654987321', '65498732F', 'Calle Estrella 13', 'laura@gmail.com', 'password6', 'Cliente'),
('David', 'Sánchez', '147258369', '14725836G', 'Calle Nube 15', 'david@gmail.com', 'password7', 'Monitor'),
('Sara', 'Ramírez', '369852147', '36985214H', 'Calle Rayo 17', 'sara@gmail.com', 'password8', 'Monitor'),
('Pablo', 'Fernández', '258369147', '25836914I', 'Calle Trueno 19', 'pablo@gmail.com', 'password9', 'Monitor'),
('Sofía', 'Ruiz', '741852963', '74185296J', 'Calle Relámpago 21', 'sofia@gmail.com', 'password10', 'Monitor'),
('Andrés', 'Torres', '963258741', '96325874K', 'Calle Brisa 23', 'andres@gmail.com', 'password11', 'Monitor'),
('Carmen', 'Molina', '159753456', '15975345L', 'Calle Viento 25', 'carmen@gmail.com', 'password12', 'Monitor'),
('Pedro', 'Castro', '753159456', '75315945M', 'Calle Horizonte 27', 'pedro@gmail.com', 'password13', 'Administrador'),
('Elena', 'Ortiz', '456123789', '45612378N', 'Calle Amanecer 29', 'elena@gmail.com', 'password14', 'Administrador'),
('Jorge', 'Morales', '789456123', '78945612O', 'Calle Atardecer 31', 'jorge@gmail.com', 'password15', 'Administrador'),
('Marta', 'Jiménez', '123789456', '12378945P', 'Calle Oscuro 33', 'marta@gmail.com', 'password16', 'Administrador'),
('Víctor', 'Vega', '321987654', '32198765Q', 'Calle Claro 35', 'victor@gmail.com', 'password17', 'Cliente'),
('Isabel', 'Soler', '654321987', '65432198R', 'Calle Primavera 37', 'isabel@gmail.com', 'password18', 'Cliente'),
('Óscar', 'Domínguez', '789123654', '78912365S', 'Calle Invierno 39', 'oscar@gmail.com', 'password19', 'Cliente'),
('Julia', 'Navarro', '321654123', '32165412T', 'Calle Verano 41', 'julia@gmail.com', 'password20', 'Cliente');

-- Inserción de datos en la tabla Clientes
INSERT INTO Clientes (email, ccc) VALUES
('juan@gmail.com', 'ES1234567890123456789012'),
('maria@gmail.com', 'ES2345678901234567890123'),
('carlos@gmail.com', 'ES3456789012345678901234'),
('ana@gmail.com', 'ES4567890123456789012345'),
('luis@gmail.com', 'ES5678901234567890123456'),
('laura@gmail.com', 'ES6789012345678901234567'),
('victor@gmail.com', 'ES7890123456789012345678'),
('isabel@gmail.com', 'ES8901234567890123456789'),
('oscar@gmail.com', 'ES9012345678901234567890'),
('julia@gmail.com', 'ES0123456789012345678901');

-- Inserción de datos en la tabla Monitores
INSERT INTO Monitores (email) VALUES
('david@gmail.com'),
('sara@gmail.com'),
('pablo@gmail.com'),
('sofia@gmail.com'),
('andres@gmail.com'),
('carmen@gmail.com');

-- Inserción de datos en la tabla Administradores
INSERT INTO Administradores (email) VALUES
('pedro@gmail.com'),
('elena@gmail.com'),
('jorge@gmail.com'),
('marta@gmail.com');

-- Inserción de datos en la tabla Actividades
INSERT INTO Actividades (nombre_actividad, descripcion, email_monitor, valoracion_media, numUsuariosApuntados, precio_actividad) VALUES
('Yoga', 'Clase de yoga para principiantes', 'david@gmail.com', 4.8, 15, 20.00),
('Pilates', 'Ejercicios de pilates', 'sara@gmail.com', 4.6, 10, 25.00),
('Spinning', 'Clase de spinning avanzada', 'pablo@gmail.com', 4.9, 12, 18.00),
('Zumba', 'Baile y ejercicio aeróbico', 'sofia@gmail.com', 4.7, 20, 22.00),
('CrossFit', 'Entrenamiento de alta intensidad', 'andres@gmail.com', 4.5, 8, 30.00),
('Boxeo', 'Técnicas de boxeo para principiantes', 'carmen@gmail.com', 4.8, 14, 28.00),
('Natación', 'Clases de natación para adultos', NULL, 4.3, 18, 15.00),
('Cardio', 'Entrenamiento de resistencia cardiovascular', 'david@gmail.com', 4.4, 10, 12.00),
('Aeróbicos', 'Ejercicios aeróbicos grupales', 'sara@gmail.com', 4.2, 7, 20.00),
('HIIT', 'Intervalos de alta intensidad', 'pablo@gmail.com', 4.6, 9, 25.00);

-- Inserción de datos en la tabla Valoraciones con valoraciones más variadas
INSERT INTO Valoraciones (id_usuario, id_actividad, valoracion, fecha_valoracion) VALUES
(1, 1, 5, '2025-01-10'),
(2, 2, 3, '2025-01-11'),
(3, 3, 4, '2025-01-12'),
(4, 4, 2, '2025-01-13'),
(5, 5, 5, '2025-01-14'),
(6, 6, 4, '2025-01-15'),
(7, 7, 3, '2025-01-16'),
(8, 8, 1, '2025-01-17'),
(9, 9, 4, '2025-01-18'),
(10, 10, 2, '2025-01-19'),
(11, 1, 3, '2025-02-01'),
(12, 2, 5, '2025-02-02'),
(13, 3, 2, '2025-02-03'),
(14, 4, 4, '2025-02-04'),
(15, 5, 3, '2025-02-05'),
(16, 6, 5, '2025-02-06'),
(17, 7, 4, '2025-02-07'),
(18, 8, 5, '2025-02-08'),
(19, 9, 1, '2025-02-09'),
(20, 10, 4, '2025-02-10'),
(1, 1, 4, '2025-03-01'),
(2, 2, 2, '2025-03-02'),
(3, 3, 5, '2025-03-03'),
(4, 4, 3, '2025-03-04'),
(5, 5, 5, '2025-03-05'),
(6, 6, 2, '2025-03-06'),
(7, 7, 4, '2025-03-07'),
(8, 8, 3, '2025-03-08'),
(9, 9, 5, '2025-03-09'),
(10, 10, 3, '2025-03-10');


-- Inserción de datos en la tabla Usuarios_Actividades
INSERT INTO Usuarios_Actividades (id_usuario, id_actividad, valoracion, cantidad_servicios) VALUES
(1, 1, 5, 3),
(2, 2, 4, 2),
(3, 3, 5, 4),
(4, 4, 4, 5),
(5, 5, 5, 1),
(6, 6, 5, 3),
(7, 7, 3, 2),
(8, 8, 4, 4),
(9, 9, 5, 5),
(10, 10, 4, 1);
