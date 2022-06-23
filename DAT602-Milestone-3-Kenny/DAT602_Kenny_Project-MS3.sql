-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Database Setup
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP DATABASE IF EXISTS DAT602_Kenny_Project;
CREATE DATABASE DAT602_Kenny_Project;
USE DAT602_Kenny_Project;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- DDL | Tables | Drop Procedures first
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
DROP PROCEDURE IF EXISTS createTables;
DROP PROCEDURE IF EXISTS dataInsert;
DROP PROCEDURE IF EXISTS Login;
DROP PROCEDURE IF EXISTS Logout;
DROP PROCEDURE IF EXISTS Register;
DROP PROCEDURE IF EXISTS deleteAccount;
DROP PROCEDURE IF EXISTS GetAllPlayers;
DROP PROCEDURE IF EXISTS GetPlayerInfo;
DROP PROCEDURE IF EXISTS GetAllUsers;
DROP PROCEDURE IF EXISTS genMap;
DROP PROCEDURE IF EXISTS createSession;
DROP PROCEDURE IF EXISTS getAllSession;
DROP PROCEDURE IF EXISTS getAllSession;
DROP PROCEDURE IF EXISTS joinGame;
DROP PROCEDURE IF EXISTS updatePlayerHighScore;
DROP PROCEDURE IF EXISTS playerMovement;
DROP PROCEDURE IF EXISTS chat;
DROP PROCEDURE IF EXISTS finishGame;
DROP PROCEDURE IF EXISTS deleteSession;
DROP PROCEDURE IF EXISTS adminUpdatePlayerInfo;
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- DDL | Tables | Procedure
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS `createTables`;
DELIMITER //
CREATE PROCEDURE `createTables`()
BEGIN
	DROP TABLE IF EXISTS `tblPlayer`, `tblTile`,`tblPlayerTile`,`tblChat`, `tblSession`, `tblGameSession`;

	CREATE TABLE `tblPlayer` (
		`email` VARCHAR(100) NOT NULL PRIMARY KEY,
		`username` VARCHAR(50) NOT NULL,
		`password` VARCHAR(50) NOT NULL,
		`highScore` INTEGER(10) DEFAULT 0,
        `currentScore`INTEGER(10) DEFAULT 0,
		`isAdmin` BOOL NOT NULL DEFAULT FALSE,
		`loginCount` INT NOT NULL DEFAULT 0,
		`lockOut` BOOL NOT NULL DEFAULT FALSE,
		`activeStatus` INTEGER(2) DEFAULT 0
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
		`playerEmail` VARCHAR(100) NOT NULL UNIQUE,
		`tileID` INTEGER(10) NOT NULL,
		FOREIGN KEY (`playerEmail`)REFERENCES `tblPlayer` (`email`),
		FOREIGN KEY (`tileID`)REFERENCES `tblTile` (`tileID`)
  );
  
  CREATE TABLE `tblChat` (
		`chatID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
		`message` VARCHAR(500),
		`fromEmail` VARCHAR(100) NOT NULL,
		FOREIGN KEY (`fromEmail`) REFERENCES `tblPlayer` (`email`) ON DELETE CASCADE
  );
  
  CREATE TABLE `tblSession` (
		`ID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY
  );
  
  CREATE TABLE `tblGameSession` (
		`sessionID` INTEGER(10) NOT NULL,
		`playerEmail` VARCHAR(100) NOT NULL,
		FOREIGN KEY (`sessionID`)REFERENCES `tblSession` (`ID`) ON DELETE CASCADE, 
        FOREIGN KEY (`playerEmail`)REFERENCES `tblPlayer` (`email`) ON DELETE CASCADE
  );
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- DML Inserting into tables
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS `dataInsert`;
DELIMITER //
CREATE PROCEDURE `dataInsert`(
)
BEGIN
-- account
	-- admin
		-- Create admins
	INSERT INTO `tblPlayer` (`email`, `username`, `password`, `isAdmin`)
	VALUES ('admin@mail.com', 'Admin', 'P@ssword1', 1),
	-- regular user
          ('player@mail.com', 'Player', 'P@ssword2', 0),
          ('player2@mail.com', 'Player2', 'P@ssword2', 0);

END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Call Create Tables, Insert Test Data
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

-- Create tables
CALL createTables();
-- Test data
CALL dataInsert();

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Create Procedures
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
/* Included procedures
------------
login - Done
logout - Done
registerPlayer - Done
	player - Done
	admin - Done
deleteAccount - Done
getAllPlayers - Done
generateMap - Done
	setHomeTile - Done
    setObstacles - Done
    setCoins - Done
joinGame - Done
movePlayer -Done
	checkTile - Done
	obstacleCollision - Done
	onCoinCollect - Done
	addCoinScore - Done
highScore - Done
chat - Done
finishGame - Done
adminUpdatePlayerInfo - Done
------------
*/

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- login 
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS Login;
DELIMITER $$
CREATE PROCEDURE Login( IN pEmail VARCHAR(50), IN pPassword  VARCHAR(50))
COMMENT 'Check login'
BEGIN
    DECLARE numAttempts INT DEFAULT 0;
    SET SQL_SAFE_UPDATES = 0;
	-- 'Check for valid login', 
    -- if valid then select message "Logged in" and reset Attempts to 0, 
    IF EXISTS ( SELECT * 
                FROM tblPlayer
                WHERE 
                  `email` = pEmail AND
                  `Password` = pPassword 
                  ) 
	THEN
		UPDATE tblPlayer 
        SET `loginCount` = 0, `activeStatus` = 1
        WHERE
          `email` = pEmail;
           
		SELECT 'Logged In' as Message;
    
    ELSE 
    -- else add to Attempts ,
        IF EXISTS(SELECT * FROM tblPlayer WHERE `email` = pEmail) THEN 
        
			SELECT `loginCount` 
			INTO numAttempts
			FROM tblPlayer
			WHERE 
			   `email`= pEmail;
			
			SET numAttempts = numAttempts + 1;
			
			IF numAttempts > 5 THEN 
			-- if Attempts > 5 then set lockout  to true and select message 'locked out' 
				UPDATE tblPlayer 
				SET `lockOut` = True
				WHERE 
					 `email` = pEmail ;
					 
				 SELECT 'Locked Out. Please contact administrator.' AS Message;
				 
			ELSE
			-- else select message 'Bad  password'
                 UPDATE tblPlayer
                 SET `loginCount` = numAttempts
                 WHERE 
                    `email` = pEmail;
                    
				 SELECT 'Invalid user name and password' AS Message;
			END IF;
      ELSE 
		SELECT 'Invalid user name and password' AS Message;
      END IF;
    END IF;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- logout
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS Logout;
DELIMITER //
CREATE PROCEDURE Logout(IN pEmail VARCHAR(50))
BEGIN
	SET SQL_SAFE_UPDATES = 0;
    IF EXISTS (SELECT * 
		FROM `tblPlayer`
		WHERE `email` = pEmail)
	THEN 
		UPDATE `tblPlayer`
		SET `activeStatus` = 0
		WHERE `email` = pEmail;
        
		SELECT CONCAT('LOGGED OUT') AS message;
	END IF;
	SET SQL_SAFE_UPDATES = 1;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- User registration 
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS Register;
DELIMITER $$
CREATE PROCEDURE Register(
	IN pEmail VARCHAR(50),
	IN pUserName VARCHAR(50),
	IN pPassword VARCHAR(50)

)
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	IF EXISTS (SELECT * 
		FROM `tblPlayer`
		WHERE `email` = pEmail) 
		
	THEN
		SELECT 'USER ALREADY EXISTS' AS message;
	ELSE 
		INSERT INTO `tblPlayer`(`email`, `username`, `password`)
		VALUE (pEmail, pUserName, pPassword); -- Takes in userinputs
        UPDATE tblPlayer 
        SET `activeStatus` = 1
        WHERE
          `username` = pUserName;
		
		SELECT CONCAT('USER ADDED') AS message;
	END IF;
    SET SQL_SAFE_UPDATES = 1;
END $$
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- delete account
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS deleteAccount;
DELIMITER //
CREATE PROCEDURE deleteAccount(
	IN pUsername VARCHAR(50)
    )
BEGIN
	SET SQL_SAFE_UPDATES = 0;
	SET FOREIGN_KEY_CHECKS=0;
    IF (
		SELECT `username` 
        FROM `tblPlayer` 
        WHERE `username` = pUsername) = pUsername
    THEN
		DELETE FROM `tblPlayer`
		WHERE Username = pUsername;
			
		SELECT CONCAT("Account deleted: ", pUsername) AS message;
	ELSE
		SELECT CONCAT("ERROR: '", pUsername, "' does not exist") AS message;
	END IF;
    SET FOREIGN_KEY_CHECKS=1;
    SET SQL_SAFE_UPDATES = 1;
END //
DELIMITER ;
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Get all current players 
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS GetAllPlayers;
DELIMITER $$
CREATE PROCEDURE GetAllPlayers()
BEGIN
	SELECT `Username`, `Email`, `highScore`, `isAdmin`,`password`, `loginCount`, `lockOut`
	FROM `tblPlayer`
    WHERE `activeStatus` = 1;
END $$
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Get current player information
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS GetPlayerInfo;
DELIMITER $$
CREATE PROCEDURE GetPlayerInfo(
	IN pEmail VARCHAR(50)
)
BEGIN
	SELECT *
	FROM `tblPlayer`
    WHERE `email` = pEmail;
END $$
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Get all users 
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS GetAllUsers;
DELIMITER $$
CREATE PROCEDURE GetAllUsers()
BEGIN
	SELECT *
	FROM `tblPlayer`;
END $$
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Generate map 10x10 grid
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS genMap;
DELIMITER $$
CREATE procedure genMap()
BEGIN
	-- Loop declare for tiles
	DECLARE pRow INT;
	DECLARE pCol INT;
	DECLARE maxRow INT;
	DECLARE maxCol INT;
	-- Loop declare for obstacles 
	DECLARE pGridMax INT;
	DECLARE numOfObstacles INT;
	DECLARE loopCounter INT;
	DECLARE randTile INT;
	-- Loop declare for coins
	DECLARE isObstacle INT;
	DECLARE numOfCoins INT;

	SET pRow = 0;
	SET maxRow =11;
	WHILE pRow < maxRow DO
		SET pCol = 0;
		SET maxCol = 11;
		WHILE pCol < maxCol DO
			INSERT INTO `tblTile` (`row`, `column`)
			VALUE (pRow, pCol);
			SET pCol = pCol +1;
		END WHILE ;
		SET pRow = pRow +1;
	END WHILE ;

	-- Set hometile for players
	UPDATE `tblTile`
	SET `homeTile` = 1
	WHERE `tileID` = 61;
    
	-- Set obstacles
	SET pGridMax = 121;
	SET numOfObstacles = 40;
	SET loopCounter = 0;

	obstacle: WHILE loopCounter < numOfObstacles  DO
		SET randTile = FLOOR((RAND() * pGridMax) + 1);
		IF randTile = 61 
		THEN ITERATE obstacle;
		END IF;
		UPDATE `tblTile`
		SET `obstacle` = 1
		WHERE `tileID` = randTile;
		SET loopCounter = loopCounter + 1; 
	END WHILE;

	-- set coins 
	SET pGridMax = 121;
	SET numOfCoins = 150;
	SET loopCounter = 0;

	coins: WHILE loopCounter < numOfCoins  DO
		SET isObstacle = 0;
		SET randTile = FLOOR((RAND() * pGridMax) + 1);
		SET isObstacle =  (
			SELECT `obstacle`
			FROM `tblTile`
			WHERE `tileID` = randTile
		);
		IF randTile = 61 OR isObstacle = 1
		THEN ITERATE coins;
		END IF;
		UPDATE `tblTile`
		SET `coin` = `coin` + 1
		WHERE `tileID` = randTile;
		SET loopCounter = loopCounter + 1; 
	END WHILE;
    SELECT "Map Generated, Hometile set, Obstacles and coins placed. Ready to play!" as message;
END $$
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Create a session
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS createSession;
DELIMITER //
CREATE PROCEDURE createSession(
	 IN pEmail VARCHAR(50)
    )
BEGIN
	SET SQL_SAFE_UPDATES = 0;
    IF EXISTS ( SELECT *
                FROM `tblGameSession`
                WHERE 
                  `playerEmail` = pEmail )
	THEN 
		SELECT concat(pEmail, " is already hosting a session") as message;
	ELSE 
		INSERT INTO `tblSession`()
		VALUE();
		SELECT `ID`,
		MAX(`ID`) into  @sessionID,@most_recent_id
		FROM `tblSession`;
		INSERT INTO `tblGameSession`(`sessionID`, `playerEmail`)
		VALUE( @most_recent_id, pEmail);
		INSERT INTO `tblPlayerTile` (`playerEmail`, `tileID`)
		VALUES (pEmail, 61);
			SELECT concat("New game session host by: ",pEmail) as message;
	SET SQL_SAFE_UPDATES = 1;
    END IF;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Get all session
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS getAllSession;
DELIMITER //
CREATE PROCEDURE getAllSession(
    )
BEGIN
	SELECT DISTINCT `sessionID`
	FROM `tblGameSession`;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Player joining the game
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS joinGame;
DELIMITER //
CREATE PROCEDURE joinGame(
	IN pEmail VARCHAR(50),
	IN pSelectedSession INT(50)
    )
BEGIN
	SET SQL_SAFE_UPDATES = 0;
    IF EXISTS ( SELECT *
                FROM `tblGameSession`
                WHERE 
                  `playerEmail` = pEmail )
	THEN 
		SELECT concat("You have already joined the session") as message;
	ELSE
		SELECT `tblgamesession`.`sessionID`
		FROM `tblgamesession`
        WHERE `sessionID` = pSelectedSession INTO @joinableSession;
		SELECT `email`
		FROM `tblplayer`
		WHERE `email` = pEmail INTO @playerJoin;
		INSERT IGNORE INTO `tblgamesession` (`sessionID`, `playerEmail`)
		VALUES (@joinableSession,@playerJoin);
		INSERT INTO `tblPlayerTile` (`playerEmail`, `tileID`)
		VALUES (@playerJoin, 61);

		SELECT CONCAT("Welcome to the game") AS message;
    SET SQL_SAFE_UPDATES = 1;
    END IF;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Player update HighScore
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS updatePlayerHighScore;
DELIMITER //
CREATE PROCEDURE updatePlayerHighScore(
	IN pUser VARCHAR(50)
    )
BEGIN
	UPDATE `tblPlayer`
	SET `highScore` = `currentScore`
	WHERE `email` = pUser AND `currentScore`> `highScore`;
	IF (row_count() > 0 ) THEN
		SELECT 'High score updated' as message;
	ELSE 
		SELECT 'High score not updated' as message;
	END IF;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Player movement
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS playerMovement;
DELIMITER //
CREATE PROCEDURE playerMovement(
	IN pEmail VARCHAR(50),
    IN pTileID INT
    )
BEGIN
	DECLARE currentTileRow INT;
	DECLARE currentTileColumn INT;
	DECLARE newTileRow INT;
	DECLARE newTileColumn INT;
    
	SET SQL_SAFE_UPDATES = 0;

	SELECT `row` -- The current player tile row     
	FROM `tblTile`
	JOIN `tblPlayerTile`  ON `tblTile`.`tileID` = `tblPlayerTile`.`tileID`
	WHERE `playerEmail` = pEmail
	INTO currentTileRow;

	SELECT `column` -- The current player tile column
	FROM `tblTile`
	JOIN `tblPlayerTile` ON `tblTile`.`tileID` = `tblPlayerTile`.`tileID`
	WHERE `playerEmail` = pEmail 
	INTO currentTileColumn;

	SELECT `row` -- The selected tile row
	FROM `tblTile`
	WHERE `tileID` = pTileID 
	INTO newTileRow;

	SELECT `column` -- The selected tile column
	FROM `tblTile`
	WHERE `tileID` = pTileID 
	INTO newTileColumn;

	IF ((newTileRow = currentTileRow OR newTileRow = currentTileRow + 1 OR newTileRow = currentTileRow - 1) 
		AND (newTileColumn = currentTileColumn OR newTileColumn = currentTileColumn + 1 OR newTileColumn = currentTileColumn - 1))
        
	THEN  	
		SELECT `tileID`, `obstacle`, `coin` -- Checks tile if empty, obstacle or coin
		INTO @id , @blocked, @coin
		FROM `tblTile`
		WHERE `tileID` = pTileID;
        
		IF @coin <> 0 THEN  -- Checks to see if there is a coin then move to that tile
			UPDATE `tblPlayerTile`
			SET `tileID` = pTileID
			WHERE 
			`playerEmail` = pEmail;

			UPDATE `tblPlayer` -- Upon moving to tile player takes all available coins on the tile  and add to the player current score
			SET `currentScore` = `currentScore` + @coin
			WHERE `email` = pEmail; 

			UPDATE `tblTile` -- Deletes all coins from the title that the player moved to
			SET `coin` = 0
			WHERE `tileID` = pTileID;

			SELECT 'Player has moved and collected coin(s)' AS message;
			CALL updatePlayerHighScore (pEmail);

		ELSEIF @blocked = 0 AND @coin = 0 THEN  -- checks to see if no obstacles or coin(s). If none then player can move to the empty tile.
			UPDATE `tblPlayerTile`
			SET `tileID` = pTileID
			WHERE 
			`playerEmail` = pEmail;

			SELECT 'Player has moved!!!' AS message;

		ELSEIF	@blocked = 1 THEN  -- Checks to see if obstacles, if so then don't move
			SELECT 'There is an obstacle in the way!!!' AS message;
		END IF;
	ELSE	
		SELECT 'Player cant move to this tile!!!' AS message;
	END IF;
	SET SQL_SAFE_UPDATES = 1;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Chat
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS chat;
DELIMITER //
CREATE PROCEDURE chat(
	IN pContent VARCHAR(500),
    IN pEmail  VARCHAR(50)
    )
BEGIN
	INSERT INTO `tblChat` (`message`,`fromEmail`)
		VALUE(pContent,pEmail);
        SELECT * FROM `tblChat`;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Get all Chat
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS GetAllchat;
DELIMITER //
CREATE PROCEDURE GetAllchat(
    )
BEGIN
	SELECT `chatID`,`fromEmail`,`message`
    FROM `tblChat`;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Finish Game
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS finishGame;
DELIMITER //
CREATE PROCEDURE finishGame()
BEGIN
	SET SQL_SAFE_UPDATES = 0;
    
	SELECT `username`,`currentScore` INTO @username, @score -- check player with the highest score
	FROM `tblPlayer`
	WHERE `currentScore` = ( 		
							SELECT MAX(`currentScore`)
							FROM `tblPlayer`);
                            
	SELECT concat(@username, " is the winner") as message;

	UPDATE `tblPlayer`
	SET `currentScore` = 0;

	UPDATE `tblPlayerTile`
	SET `tileID` = 61;

	SET SQL_SAFE_UPDATES = 1;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Admin Player update
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

DROP PROCEDURE IF EXISTS adminUpdatePlayerInfo;
DELIMITER //
CREATE PROCEDURE adminUpdatePlayerInfo(
	IN pUser VARCHAR(50),
	IN pUserName VARCHAR(50),
	IN pPassword VARCHAR(50),
    IN pHighscore INT(10),
    IN ploginCount INT(10),
    IN pLockout BOOL
    )
BEGIN
	IF EXISTS (SELECT `email`
		FROM `tblPlayer`
		WHERE `email` = pUser)
	THEN
		UPDATE `tblPlayer`
		SET `username`= pUserName, `password`= pPassword, `highScore`= pHighscore, `loginCount`= ploginCount, `lockOut`= pLockout
		WHERE tblPlayer.email = pUser;
	END IF;
		SELECT CONCAT("Updated ", pUser, ", Success!") as message;
END //
DELIMITER ;

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
-- Call Procedures
-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

-- Register
CALL Register('player3@mail.com','Player3', 'P@ssword2');
-- Login (player 1 and 2)
CALL Login('Player@mail.com', 'P@ssword2');
CALL Login('Player2@mail.com', 'P@ssword2');
-- Logout
CALL Logout('Player3@mail.com');
-- Get all current players 
CALL GetAllPlayers();
-- Get players current info
CALL GetPlayerInfo('player@mail.com');
-- Get all users 
CALL GetAllUsers();
-- delete account
CALL deleteAccount('Player3');
-- Generate map 10x10 grid
CALL genMap(); 
-- Create session
CALL createSession('player@mail.com');
-- Get all sessions
CALL getAllSession();
-- Player joining the game
CALL joinGame('player2@mail.com',1);
-- Player update HighScore | Need a player record with current score greater than the player's high score before execution
	-- CALL updatePlayerHighScore ("player2@mail.com");
-- Player movement
CALL playerMovement("player2@mail.com", 61);
-- Chat
CALL chat("Hello World!","player2@mail.com");
-- Get all messages from chat to display
CALL GetAllchat();
-- Finish Game | Need a player record with current score before execution
CALL finishGame();
-- Admin Player update
CALL adminUpdatePlayerInfo("player2@mail.com", "Player4", "P@ssword2", 2, 1, 1);
