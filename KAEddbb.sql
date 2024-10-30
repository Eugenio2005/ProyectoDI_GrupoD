/* ===================== TABLA USUARIOS ======================*/

CREATE TABLE client (
    names VARCHAR(50) NOT NULL,
    lastname VARCHAR(50) NOT NULL,
    phoneN INT,
    dni VARCHAR(20),
    addres VARCHAR(100),
    ccc VARCHAR(22) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    pass VARCHAR(50) NOT NULL
    CHECK (pass LIKE '%[A-Z]%' ), -- Al menos una mayúscula
    CHECK (pass LIKE '%[a-z]%'), -- Al menos una minúscula
    CHECK (pass LIKE '%[0-9]%'), -- Al menos un número
    CHECK (pass LIKE '%[%&$/*]%'), -- Al menos un carácter especial
    CHECK (LEN(pass) >= 8) -- Longitud mínima de 8 caracteres
);

CREATE TABLE admins (
    names VARCHAR(50) NOT NULL,
    lastname VARCHAR(50) NOT NULL,
    phoneN INT,
    dni VARCHAR(20),
    addres VARCHAR(100),
    ccc VARCHAR(22) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    pass VARCHAR(50) NOT NULL
    CHECK (pass LIKE '%[A-Z]%' ), -- Al menos una mayúscula
    CHECK (pass LIKE '%[a-z]%'), -- Al menos una minúscula
    CHECK (pass LIKE '%[0-9]%'), -- Al menos un número
    CHECK (pass LIKE '%[%&$/*]%'), -- Al menos un carácter especial
    CHECK (LEN(pass) >= 8) -- Longitud mínima de 8 caracteres
);

CREATE TABLE monitor (
    names VARCHAR(50) NOT NULL,
    lastname VARCHAR(50) NOT NULL,
    phoneN INT,
    dni VARCHAR(20),
    addres VARCHAR(100),
    ccc VARCHAR(22) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    pass VARCHAR(50) NOT NULL
    CHECK (pass LIKE '%[A-Z]%' ), -- Al menos una mayúscula
    CHECK (pass LIKE '%[a-z]%'), -- Al menos una minúscula
    CHECK (pass LIKE '%[0-9]%'), -- Al menos un número
	CHECK (pass LIKE '%[%&$/*]%'),
	CHECK (LEN(pass) >= 8) -- Longitud mínima de 8 caracteres
);


/* ===================== TABLA ACTIVIDADES ======================*/
create table activities(names varchar(MAX) unique, 
val int check(val >0 and val < 6));

