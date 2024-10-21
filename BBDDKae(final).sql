USE equipod;
CREATE TABLE users (
    dni VARCHAR(20) PRIMARY KEY,
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
    user_dni VARCHAR(20) FOREIGN KEY REFERENCES users(dni),
    activity_name VARCHAR(250) FOREIGN KEY REFERENCES activities(names),
    rating INT CHECK (rating BETWEEN 1 AND 5),
    PRIMARY KEY (user_dni, activity_name)
);

CREATE TABLE monitor_activities (
    monitor_dni VARCHAR(20) FOREIGN KEY REFERENCES users(dni),
    activity_name VARCHAR(250) FOREIGN KEY REFERENCES activities(names),
    PRIMARY KEY (monitor_dni, activity_name)
);