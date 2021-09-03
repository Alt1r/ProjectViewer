CREATE DATABASE TechProjects;
GO

USE TechProjects;
CREATE TABLE Projects
(
    Id INT PRIMARY KEY IDENTITY,
	Cipher NVARCHAR(20) NOT NULL UNIQUE,
    Name NVARCHAR(50) NOT NULL,
	CreationTimestamp DATETIME2(2) NOT NULL,
	LastModifyTimestamp DATETIME2(2) NOT NULL
);

CREATE TABLE Objects1
(
    Id INT PRIMARY KEY IDENTITY,
	Code NVARCHAR(20) NOT NULL UNIQUE,
    Name NVARCHAR(50) NOT NULL,
	CreationTimestamp DATETIME2(2) NOT NULL,
	LastModifyTimestamp DATETIME2(2) NOT NULL
);

CREATE TABLE Objects2
(
    Id INT PRIMARY KEY IDENTITY,
	Code NVARCHAR(20) NOT NULL UNIQUE,
    Name NVARCHAR(50) NOT NULL,
	CreationTimestamp DATETIME2(2) NOT NULL,
	LastModifyTimestamp DATETIME2(2) NOT NULL
);

CREATE TABLE ProjectsObjects1Hierarchy
(
    Id INT IDENTITY,
	ProjectId INT,
	ObjectId INT,
	FOREIGN KEY (ProjectId) REFERENCES Projects (Id) ON DELETE CASCADE,
	FOREIGN KEY (ObjectId) REFERENCES Objects1 (Id) ON DELETE CASCADE,
	PRIMARY KEY(ProjectId, ObjectId)
);


CREATE TABLE Objects1Objects2Hierarchy
(
    Id INT IDENTITY UNIQUE,
	ParentObjectId INT,
	ChildObjectId INT,
	FOREIGN KEY (ParentObjectId) REFERENCES Objects1 (Id) ON DELETE CASCADE,
	FOREIGN KEY (ChildObjectId) REFERENCES Object2lvl (Id) ON DELETE CASCADE,
	PRIMARY KEY(ParentObjectId, ChildObjectId)
);

GO
CREATE PROCEDURE CreateProjects 
	@count INT
AS
BEGIN
	DECLARE @inc INT
	SET @inc = 1
	WHILE @inc < 101
	BEGIN
		INSERT Projects VALUES ('Project#' + CAST(@inc as nvarchar(20)), 'NameProject#'+ CAST(@inc as nvarchar(20)), CONVERT (DATETIME2(2),CURRENT_TIMESTAMP), CONVERT (DATETIME2(2),CURRENT_TIMESTAMP))
		SET @inc = @inc+1;
	END
END;

GO
CREATE PROCEDURE CreateObjects1 
	@count INT
AS
BEGIN
	DECLARE @inc INT
	SET @inc = 1
	WHILE @inc < @count + 1
	BEGIN
		INSERT Objects1 VALUES ('Object1#' + CAST(@inc as nvarchar(20)), 'NameObject1#'+ CAST(@inc as nvarchar(20)), CONVERT (DATETIME2(2),CURRENT_TIMESTAMP), CONVERT (DATETIME2(2),CURRENT_TIMESTAMP))
		SET @inc = @inc+1;
	END
END;

GO
CREATE PROCEDURE CreateObjects2 
	@count INT
AS
	BEGIN
		DECLARE @inc INT
		SET @inc = 1
		WHILE @inc < @count + 1
		BEGIN
			INSERT Objects2 VALUES ('Object2#' + CAST(@inc as nvarchar(20)), 'NameObject2#'+ CAST(@inc as nvarchar(20)), CONVERT (DATETIME2(2),CURRENT_TIMESTAMP), CONVERT (DATETIME2(2),CURRENT_TIMESTAMP))
			SET @inc = @inc+1;
		END
	END;

GO
CREATE PROCEDURE CreateProjectObject1Hierarchy
	@parentObject INT, 
	@childObject INT
AS
BEGIN
	DECLARE @parentCount INT, @childCount INT
	SET @parentCount = 1
	set @childCount = 1
	WHILE @parentCount < @parentObject * @childObject + 1
	BEGIN
		INSERT ProjectsObjects1Hierarchy VALUES ((SELECT id FROM Projects WHERE Id = @parentCount), (SELECT id FROM Objects1 WHERE Id = @childCount))
		IF @childCount < 11 
			SET @childCount = @childCount +1;
		ELSE
		BEGIN
			SET @childCount = 1
			SET @parentCount = @parentCount + 1;
		END	
	END
END;

GO
CREATE PROCEDURE CreateObject1Object2Hierarchy
	@parentObject INT, 
	@childObject INT
 AS
BEGIN
	DECLARE @parentCount INT, @childCount INT
	SET @parentCount = 1
	set @childCount = 1
	WHILE @parentCount < @parentObject * @childObject + 1
	BEGIN
		INSERT Objects1Objects2Hierarchy VALUES ((SELECT id FROM Objects1 WHERE Id = @parentCount), (SELECT id FROM Objects2 WHERE Id = @childCount))
		IF @childCount < 11 
			SET @childCount = @childCount +1;
		ELSE
		BEGIN
			SET @childCount = 1
			SET @parentCount = @parentCount + 1;
		END	
	END
END;

GO
DECLARE @projCount INT, @object1Count INT, @object2Count INT
SET @projCount = 10
SET @object1Count = 10
SET @object2Count = 10

EXEC CreateProjects @projCount
EXEC CreateObjects1 @object1Count
EXEC CreateObjects2 @object2Count
EXEC CreateProjectObject1Hierarchy @projCount, @object1Count
EXEC CreateObject1Object2Hierarchy @object1Count, @object2Count
