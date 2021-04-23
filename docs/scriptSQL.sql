--pasword para la  DB sera: 1234


-- SCRIPT SQL v3.1 - parkDB
-- ACTUALIZADO: 06 ABRIL 2021
--------------------------------------------
CREATE DATABASE parkdb;

use parkdb;


CREATE TABLE users
(
    id_user BIGINT PRIMARY KEY,
    fname VARCHAR(50) NOT NULL,
    lname VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    passwd VARCHAR(64) NOT NULL
);


CREATE TABLE cars
(
    plate VARCHAR(10) PRIMARY KEY,
    id_user BIGINT,
    brand VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    color VARCHAR(50) NOT NULL,

    FOREIGN KEY (id_user) REFERENCES users(id_user)
);

CREATE TABLE parkings
(
    id_parking BIGINT PRIMARY KEY auto_increment,
    name VARCHAR(50) NOT NULL,
    address VARCHAR(50) NOT NULL,
    size BIGINT
);



CREATE TABLE tickets
(
    id_ticket BIGINT PRIMARY KEY auto_increment,
    id_user BIGINT NOT NULL,
    id_parking BIGINT NOT NULL,
	
    date_in DATETIME NOT NULL,
    date_out DATETIME 

);

insert into users (fname, lname, email, passwd) values ('admin', 'admin', 'admin@parkdb.com', sha2('admin', 256));
