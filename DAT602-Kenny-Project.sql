DROP DATABASE IF EXISTS DAT602_Kenny_Project;
CREATE DATABASE DAT602_Kenny_Project;
USE DAT602_Kenny_Project;

-- ----------------------------------------------- DDL -----------------------------------------------
DROP PROCEDURE IF EXISTS `createTables`;
DELIMITER //
CREATE PROCEDURE `createTables`()
BEGIN
	DROP TABLE IF EXISTS `tblPlayer`, `tblTile`,`tblPlayerTile`,`tblChat`;

	CREATE TABLE `tblPlayer` (
		`email` VARCHAR(100) NOT NULL PRIMARY KEY,
		`username` VARCHAR(50) NOT NULL,
		`password` VARCHAR(50) NOT NULL,
		`highScore` INTEGER(10) DEFAULT 0,
		`isAdmin` BOOL NOT NULL DEFAULT FALSE,
		`loginCount` INT NOT NULL DEFAULT 0,
    `lockOut` BOOL NOT NULL DEFAULT FALSE,
		`activeStatus` INTEGER(2) DEFAULT 1
	);
  
  CREATE TABLE `tblTile` (
    `tileID` INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
		`row` INTEGER(10) NOT NULL,
		`column` INTEGER(10) NOT NULL,
		`obstacle` BOOL NOT NULL DEFAULT 0,
		`coin` INTEGER(10) DEFAULT 0,
    `homeTile` BOOL NOT NULL DEFAULT 0
	);

  CREATE TABLE `tblPlayerTile` (
    `playerEmail` VARCHAR(100) NOT NULL,
    `tileID` INTEGER(10),
    FOREIGN KEY (`playerEmail`)REFERENCES `tblPlayer` (`email`),
    FOREIGN KEY (`tileID`)REFERENCES `tblTile` (`tileID`)
  );
  
  CREATE TABLE `tblChat` (
		`chatID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `message` VARCHAR(500),
    `fromEmail` VARCHAR(100) NOT NULL,
    `toEmail` VARCHAR(100) NOT NULL,
    FOREIGN KEY (`fromEmail`) REFERENCES `tblPlayer` (`email`),
	FOREIGN KEY (`toEmail`) REFERENCES `tblPlayer` (`email`)
  );
END //
DELIMITER ;

-- ----------------------------------------------- DML -----------------------------------------------
-- --------------------------- INSERT
DROP PROCEDURE IF EXISTS `dataInsert`;
DELIMITER //
CREATE PROCEDURE `dataInsert`(
)
BEGIN

-- tile
INSERT INTO `tblTile` (`row`, `column`)
VALUES  (0, 0),
        (0, 1),
        (0, 2),
        (0, 3),
        (0, 4),
        (0, 5),
        (0, 6),
        (0, 7),
        (0, 8),
        (0, 9),
        (0, 10),
        (1, 0),
        (1, 1),
        (1, 2),
        (1, 3),
        (1, 4),
        (1, 5),
        (1, 6),
        (1, 7),
        (1, 8),
        (1, 9),
        (1, 10),
        (2, 0),
        (2, 1),
        (2, 2),
        (2, 3),
        (2, 4),
        (2, 5),
        (2, 6),
        (2, 7),
        (2, 8),
        (2, 9),
        (2, 10),
        (3, 0),
        (3, 1),
        (3, 2),
        (3, 3),
        (3, 4),
        (3, 5),
        (3, 6),
        (3, 7),
        (3, 8),
        (3, 9),
        (3, 10),
        (4, 0),
        (4, 1),
        (4, 2),
        (4, 3),
        (4, 4),
        (4, 5),
        (4, 6),
        (4, 7),
        (4, 8),
        (4, 9),
        (4, 10),
        (5, 0),
        (5, 1),
        (5, 2),
        (5, 3),
        (5, 4),
        (5, 5),
        (5, 6),
        (5, 7),
        (5, 8),
        (5, 9),
        (5, 10),
        (6, 0),
        (6, 1),
        (6, 2),
        (6, 3),
        (6, 4),
        (6, 5),
        (6, 6),
        (6, 7),
        (6, 8),
        (6, 9),
        (6, 10),
        (7, 0),
        (7, 1),
        (7, 2),
        (7, 3),
        (7, 4),
        (7, 5),
        (7, 6),
        (7, 7),
        (7, 8),
        (7, 9),
        (7, 10),
        (8, 0),
        (8, 1),
        (8, 2),
        (8, 3),
        (8, 4),
        (8, 5),
        (8, 6),
        (8, 7),
        (8, 8),
        (8, 9),
        (8, 10),
        (9, 0),
        (9, 1),
        (9, 2),
        (9, 3),
        (9, 4),
        (9, 5),
        (9, 6),
        (9, 7),
        (9, 8),
        (9, 9),
        (9, 10),
        (10, 0),
        (10, 1),
        (10, 2),
        (10, 3),
        (10, 4),
        (10, 5),
        (10, 6),
        (10, 7),
        (10, 8),
        (10, 9),
        (10, 10);

	-- account
		-- admin
	-- Create admins
	INSERT INTO `tblPlayer` (`email`, `username`, `password`, `highscore`, `isAdmin`, `loginCount`, `lockOut`, `activeStatus`)
	VALUES ('admin@mail.com', 'Admin', 'P@ssword1', 0, 1, 0, 0, 1),
        -- regular user
          ('player@mail.com', 'Player', 'P@ssword2', 0, 0, 0, 0, 1);

    -- Player tile
    -- Creating the player at the hometile location
	INSERT INTO `tblPlayerTile` (`playerEmail`, `tileId`)
	VALUES ('admin@mail.com', 55);

-- chat
	INSERT INTO `tblChat` (`chatID`, `message`, `fromEmail`, `toEmail`)
	VALUES (0, 'Hello World!', 'admin@mail.com', 'player@mail.com');

END //
DELIMITER ;

-- --------------------------- UPDATE
DROP PROCEDURE IF EXISTS `dataUpdate`;
DELIMITER //
CREATE PROCEDURE `dataUpdate`()
BEGIN
	-- account
	UPDATE `tblPlayer`
	SET
		`username` = 'Player1'
	WHERE
		`email` = 'player@mail.com';

    -- Tile
  UPDATE `tblTile`
	SET
		`homeTile` = 1
	WHERE
		`tileID` = 55;
  
    -- Player tile
    -- move the player example
    UPDATE `tblPlayerTile`
    SET
		`tileID` = 54
	WHERE
		`playerEmail` = 'admin@mail.com';
  
    -- Chat
    UPDATE `tblChat`
    SET
		`message` = 'Hello World Big World!'
	WHERE
		`chatID` = 1;
END //
DELIMITER ;

-- --------------------------- SELECT
DROP PROCEDURE IF EXISTS `dataSelect`;
DELIMITER //
CREATE PROCEDURE `dataSelect`()
BEGIN
	-- player
    SELECT `username`, `email`, `highScore`
    FROM `tblPlayer`;
  
    -- player tile
    SELECT `playerEmail`, `tileID`
    FROM `tblPlayerTile`;
  
    -- chat
    SELECT `message`
    FROM `tblChat`;
  
END //
DELIMITER ;

-- --------------------------- DELETE
DROP PROCEDURE IF EXISTS `dataDelete`;
DELIMITER //
CREATE PROCEDURE `dataDelete`()
BEGIN
	
    -- playerTile
    DELETE FROM `tblPlayertile`
    WHERE `playerEmail` = 'admin@mail.com';
  
    -- chat
    DELETE FROM `tblChat`
    WHERE `chatID` = 1;
    
    -- player
    DELETE FROM `tblPlayer`
    WHERE `email` = 'player@mail.com';

END //
DELIMITER ;

-- Create tables
CALL createTables();

-- Test data
CALL dataInsert();
CALL dataUpdate();
CALL dataSelect();

-- Delete tables
CALL dataDelete();



-- Remove stored procedures used in database creation - To secure access to the database later
-- DROP PROCEDURE IF EXISTS `createTables`;
-- DROP PROCEDURE IF EXISTS `dataInsert`;
-- DROP PROCEDURE IF EXISTS `dataUpdate`;
-- DROP PROCEDURE IF EXISTS `dataSelect`;
-- DROP PROCEDURE IF EXISTS `dataDelete`;