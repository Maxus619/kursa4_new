CREATE DATABASE `kurs`;
USE `kurs`;

CREATE TABLE `kategorii_lekarstv` (
	`kod_gruppi` INT NOT NULL AUTO_INCREMENT,
	`naimenovanie_gruppi` VARCHAR(20),
	`recept` BOOLEAN,
	PRIMARY KEY (`kod_gruppi`)
);
CREATE TABLE `lekarstva` (
	`artikul_lekarstva` INT NOT NULL AUTO_INCREMENT,
	`kod_gruppi` INT,
	`naimenovanie_lekarstva` VARCHAR(20),
	`kolvo` INT,
	`price` INT,
	PRIMARY KEY (`artikul_lekarstva`),
	FOREIGN KEY (`kod_gruppi`) REFERENCES `kategorii_lekarstv`(`kod_gruppi`)
);
CREATE TABLE `rabotniki` (
	`tabelniy_nomer` INT NOT NULL AUTO_INCREMENT,
	`pswd` VARCHAR(20),
	`doljnost` VARCHAR(20),
	`familia_rabotnika` VARCHAR(20),
	`imya_rabotnika` VARCHAR(20),
	`otchestvo_rabotnika` VARCHAR(20),
	PRIMARY KEY (`tabelniy_nomer`)
);
CREATE TABLE `grafik` (
	`nomer_smeni` INT NOT NULL AUTO_INCREMENT,
	`data_grafika` DATE,
	`smena` INT,
	`tabelniy_nomer` INT,
	PRIMARY KEY (`nomer_smeni`),
	FOREIGN KEY (`tabelniy_nomer`) REFERENCES `rabotniki`(`tabelniy_nomer`)
);
CREATE TABLE `prodaja` (
	`nomer_checka` INT NOT NULL AUTO_INCREMENT,
	`nomer_smeni` INT,
	`data_vremya_prodaji` DATETIME,
	PRIMARY KEY (`nomer_checka`),
	FOREIGN KEY (`nomer_smeni`) REFERENCES `grafik`(`nomer_smeni`)
);
CREATE TABLE `chek` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`nomer_checka` INT,
	`artikul_lekarstva` INT,
	`kolvo_lekarstva` INT,
	`price` INT,
	PRIMARY KEY (`id`),
	FOREIGN KEY (`nomer_checka`) REFERENCES `prodaja`(`nomer_checka`),
	FOREIGN KEY (`artikul_lekarstva`) REFERENCES `lekarstva`(`artikul_lekarstva`)
);
