SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `mydb` ;
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Clan`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Clan` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Clan` (
  `id_clan` INT NOT NULL AUTO_INCREMENT,
  `Ime` VARCHAR(45) NULL,
  `Prezime` VARCHAR(45) NULL,
  `Telefon` VARCHAR(15) NULL,
  `Adresa` VARCHAR(45) NULL,
  `status` INT NULL,
  PRIMARY KEY (`id_clan`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Clanarina`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Clanarina` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Clanarina` (
  `id_clanarina` INT NOT NULL AUTO_INCREMENT,
  `Od` DATE NULL,
  `Do` DATE NULL,
  `Clan_id_clan` INT NOT NULL,
  PRIMARY KEY (`id_clanarina`),
  INDEX `fk_Clanarina_Clan_idx` (`Clan_id_clan` ASC),
  CONSTRAINT `fk_Clanarina_Clan`
    FOREIGN KEY (`Clan_id_clan`)
    REFERENCES `mydb`.`Clan` (`id_clan`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Zanr`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Zanr` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Zanr` (
  `id_zanr` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(20) NULL,
  `Opis` VARCHAR(245) NULL,
  PRIMARY KEY (`id_zanr`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Glumac`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Glumac` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Glumac` (
  `id_glumac` INT NOT NULL AUTO_INCREMENT,
  `Ime` VARCHAR(45) NULL,
  `Prezime` VARCHAR(45) NULL,
  `Datum rodenja` DATE NULL,
  `Nacionalnost` VARCHAR(25) NULL,
  PRIMARY KEY (`id_glumac`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Redatelj`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Redatelj` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Redatelj` (
  `id_Redatelj` INT NOT NULL AUTO_INCREMENT,
  `Ime` VARCHAR(45) NULL,
  `Prezime` VARCHAR(45) NULL,
  `Datum rodenja` DATE NULL,
  `Nacionalnost` VARCHAR(25) NULL,
  PRIMARY KEY (`id_Redatelj`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Distributer`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Distributer` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Distributer` (
  `id_Distributer` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NULL,
  `Adresa` VARCHAR(45) NULL,
  `Telefon` VARCHAR(45) NULL,
  `Faks` VARCHAR(45) NULL,
  `Email` VARCHAR(45) NULL,
  `OIB` VARCHAR(45) NULL,
  PRIMARY KEY (`id_Distributer`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Filmovi`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Filmovi` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Filmovi` (
  `id_film` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(80) NULL,
  `Godina` DATE NULL,
  `Trajanje` VARCHAR(45) NULL,
  `Jezik` VARCHAR(45) NULL,
  `Zemlja` VARCHAR(45) NULL,
  `Status_filma` INT NULL,
  `Distributer_id_Distributer` INT NOT NULL,
  `Redatelj_id_Redatelj` INT NOT NULL,
  PRIMARY KEY (`id_film`, `Distributer_id_Distributer`),
  INDEX `fk_Filmovi_Distributer1_idx` (`Distributer_id_Distributer` ASC),
  INDEX `fk_Filmovi_Redatelj1_idx` (`Redatelj_id_Redatelj` ASC),
  CONSTRAINT `fk_Filmovi_Distributer1`
    FOREIGN KEY (`Distributer_id_Distributer`)
    REFERENCES `mydb`.`Distributer` (`id_Distributer`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Filmovi_Redatelj1`
    FOREIGN KEY (`Redatelj_id_Redatelj`)
    REFERENCES `mydb`.`Redatelj` (`id_Redatelj`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Filmovi_glumci`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Filmovi_glumci` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Filmovi_glumci` (
  `Filmovi_id_film` INT NOT NULL,
  `Glumac_id_glumac` INT NOT NULL,
  PRIMARY KEY (`Filmovi_id_film`, `Glumac_id_glumac`),
  INDEX `fk_Filmovi_has_Glumac_Glumac1_idx` (`Glumac_id_glumac` ASC),
  INDEX `fk_Filmovi_has_Glumac_Filmovi1_idx` (`Filmovi_id_film` ASC),
  CONSTRAINT `fk_Filmovi_has_Glumac_Filmovi1`
    FOREIGN KEY (`Filmovi_id_film`)
    REFERENCES `mydb`.`Filmovi` (`id_film`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Filmovi_has_Glumac_Glumac1`
    FOREIGN KEY (`Glumac_id_glumac`)
    REFERENCES `mydb`.`Glumac` (`id_glumac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Filmovi_zanr`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Filmovi_zanr` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Filmovi_zanr` (
  `Zanr_id_zanr` INT NOT NULL,
  `Filmovi_id_film` INT NOT NULL,
  PRIMARY KEY (`Zanr_id_zanr`, `Filmovi_id_film`),
  INDEX `fk_Zanr_has_Filmovi_Filmovi1_idx` (`Filmovi_id_film` ASC),
  INDEX `fk_Zanr_has_Filmovi_Zanr1_idx` (`Zanr_id_zanr` ASC),
  CONSTRAINT `fk_Zanr_has_Filmovi_Zanr1`
    FOREIGN KEY (`Zanr_id_zanr`)
    REFERENCES `mydb`.`Zanr` (`id_zanr`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Zanr_has_Filmovi_Filmovi1`
    FOREIGN KEY (`Filmovi_id_film`)
    REFERENCES `mydb`.`Filmovi` (`id_film`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Posudba`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Posudba` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Posudba` (
  `Filmovi_id_film` INT NOT NULL,
  `Clan_id_clan` INT NOT NULL,
  `Datum posudbe` DATE NULL,
  `Rok vracanja` DATE NULL,
  `Status posudbe` INT NULL DEFAULT 0,
  `Status kasnjenja` INT NULL,
  PRIMARY KEY (`Filmovi_id_film`, `Clan_id_clan`),
  INDEX `fk_Filmovi_has_Clan_Clan1_idx` (`Clan_id_clan` ASC),
  INDEX `fk_Filmovi_has_Clan_Filmovi1_idx` (`Filmovi_id_film` ASC),
  CONSTRAINT `fk_Filmovi_has_Clan_Filmovi1`
    FOREIGN KEY (`Filmovi_id_film`)
    REFERENCES `mydb`.`Filmovi` (`id_film`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Filmovi_has_Clan_Clan1`
    FOREIGN KEY (`Clan_id_clan`)
    REFERENCES `mydb`.`Clan` (`id_clan`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Kasnjenja`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Kasnjenja` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Kasnjenja` (
  `Posudba_Filmovi_id_film` INT NOT NULL,
  `Posudba_Clan_id_clan` INT NOT NULL,
  `Kasnjenje` INT NULL,
  `Cijena` FLOAT NULL,
  PRIMARY KEY (`Posudba_Filmovi_id_film`, `Posudba_Clan_id_clan`),
  CONSTRAINT `fk_Kasnjenja_Posudba1`
    FOREIGN KEY (`Posudba_Filmovi_id_film` , `Posudba_Clan_id_clan`)
    REFERENCES `mydb`.`Posudba` (`Filmovi_id_film` , `Clan_id_clan`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
