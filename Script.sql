CREATE TABLE IF NOT EXISTS `servicedbdistribuidos`.`marca` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(50) NULL DEFAULT NULL,
  `descripcionMarca` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `servicedbdistribuidos`.`computo` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(100) NULL DEFAULT NULL,
  `observaciones` VARCHAR(150) NULL DEFAULT NULL,
  `numeroSerie` VARCHAR(20) NULL DEFAULT NULL,
  `color` VARCHAR(50) NULL DEFAULT NULL,
  `idMarca` INT(11) NULL DEFAULT NULL,
  `procesador` VARCHAR(50) NULL DEFAULT NULL,
  `numeroMac` VARCHAR(50) NULL DEFAULT NULL,
  `display` VARCHAR(50) NULL DEFAULT NULL,
  `nombreComercial` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `idMarca_idx` (`idMarca` ASC),
  CONSTRAINT `idMarca`
    FOREIGN KEY (`idMarca`)
    REFERENCES `servicedbdistribuidos`.`marca` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


CREATE PROCEDURE CREATE DEFINER=`root`@`localhost` PROCEDURE `st_RegistrarComputo`(
_descripcion varchar(100),
_observaciones varchar(150), 
_numeroSerie varchar(20),
_color varchar(50), 
_procesador varchar(50), 
_numeroMac varchar(50), 
_display varchar(50), 
_nombreComercial varchar(50),
_nombre varchar(50), 
_descripcionMarca varchar(50)
)
BEGIN
declare _idtempMarca int;
  INSERT INTO marca(nombre,descripcionMarca) 
  VALUES(_nombre,_descripcionMarca);
  
  set _idtempMarca =(SELECT max(id) from marca);
  select _idtempMarca;
  
  insert into computo(descripcion,observaciones,numeroSerie,color,idMarca,procesador,numeroMac,display,nombreComercial)
  values(_descripcion,_observaciones,_numeroSerie,_color,_idtempMarca,_procesador,_numeroMac,_display,_nombreComercial);
END

