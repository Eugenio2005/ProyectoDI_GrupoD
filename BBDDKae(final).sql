USE equipod;
CREATE TABLE users (
    dni VARCHAR(20) PRIMARY KEY,
	 CHECK (LEN(dni) = 9 AND ISNUMERIC(LEFT(dni, 8)) = 1 AND RIGHT(dni, 1) BETWEEN 'A' AND 'Z'),
    names VARCHAR(50) NOT NULL,
    lastname VARCHAR(50) NOT NULL,
    phoneN INT,
    addres VARCHAR(100),
    ccc VARCHAR(22) NOT NULL,
    pass VARCHAR(50) NOT NULL 
	CHECK(pass LIKE '%[A-Z]%'),
    CHECK (pass LIKE '%[a-z]%'),
    CHECK (pass LIKE '%[%&$/*]%'),
    CHECK(pass LIKE '%[0-9]%' ),
    CHECK( LEN(pass) >= 8),
    user_type VARCHAR(20) NOT NULL CHECK (user_type IN ('client', 'monitor', 'admin'))
);

CREATE TABLE activities (
    names VARCHAR(250) PRIMARY KEY,
    val INT CHECK (val BETWEEN 1 AND 5)
);


CREATE TABLE user_activities (
    user_dni VARCHAR(20) FOREIGN KEY REFERENCES users(dni) ON DELETE CASCADE ON UPDATE CASCADE,
    activity_name VARCHAR(250) FOREIGN KEY REFERENCES activities(names) ON DELETE CASCADE ON UPDATE CASCADE,
    PRIMARY KEY (user_dni, activity_name),
    CHECK (LEN(user_dni) = 9 AND ISNUMERIC(LEFT(user_dni, 8)) = 1 AND RIGHT(user_dni, 1) BETWEEN 'A' AND 'Z')
);

CREATE TABLE monitor_activities (
    monitor_dni VARCHAR(20) FOREIGN KEY REFERENCES users(dni) ON DELETE CASCADE ON UPDATE CASCADE,
    activity_name VARCHAR(250) FOREIGN KEY REFERENCES activities(names) ON DELETE CASCADE ON UPDATE CASCADE,
    PRIMARY KEY (monitor_dni, activity_name),
    CHECK (LEN(monitor_dni) = 9 AND ISNUMERIC(LEFT(monitor_dni, 8)) = 1 AND RIGHT(monitor_dni, 1) BETWEEN 'A' AND 'Z')
);

CREATE TABLE monitores (
    dni VARCHAR(20) PRIMARY KEY FOREIGN KEY REFERENCES users(dni) ON DELETE CASCADE,
	 CHECK (LEN(dni) = 9 AND ISNUMERIC(LEFT(dni, 8)) = 1 AND RIGHT(dni, 1) BETWEEN 'A' AND 'Z'),
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL
);

CREATE TABLE administradores (
    dni VARCHAR(20) PRIMARY KEY FOREIGN KEY REFERENCES users(dni) ON DELETE CASCADE,
	CHECK (LEN(dni) = 9 AND ISNUMERIC(LEFT(dni, 8)) = 1 AND RIGHT(dni, 1) BETWEEN 'A' AND 'Z'),
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL
);

CREATE TABLE clientes (
    dni VARCHAR(20) PRIMARY KEY FOREIGN KEY REFERENCES users(dni) ON DELETE CASCADE,
	CHECK (LEN(dni) = 9 AND ISNUMERIC(LEFT(dni, 8)) = 1 AND RIGHT(dni, 1) BETWEEN 'A' AND 'Z'),
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL
);


INSERT INTO users VALUES('12345678A','Kevin','Villarreal',123456789,'Luis de Ulloa','0','P@ssW0rd*','admin');
INSERT INTO users VALUES('12345678B','Andoni','Pastrana',123456789,'Luis de Ulloa','0','P@ssW0rd*','admin');
INSERT INTO users VALUES('12345678C','Eugenio','Lorente',123456789,'Luis de Ulloa','0','P@ssW0rd*','admin');
select * from users;
