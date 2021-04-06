
pasword para la  DB sera: 1234

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
    contraseña VARCHAR(20) NOT NULL
);


CREATE TABLE cars
(
    id_car BIGINT PRIMARY KEY,
    id_user BIGINT,
    plate VARCHAR(50) NOT NULL,
    brand VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    color VARCHAR(50) NOT NULL,

    FOREIGN KEY (id_user) REFERENCES users(id_user)
);

CREATE TABLE parkings
(
    id_parking BIGINT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    address VARCHAR(50) NOT NULL,
    size BIGINT
);



CREATE TABLE tickets
(
    id_ticket BIGINT PRIMARY KEY,
    id_user BIGINT NOT NULL,
    id_parking BIGINT NOT NULL,
	
    date_in DATETIME NOT NULL,
    date_out DATETIME 

);

