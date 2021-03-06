/*
Deployment script for OnlibraryOrdersDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "OnlibraryOrdersDatabase"
:setvar DefaultFilePrefix "OnlibraryOrdersDatabase"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Altering Procedure [dbo].[CreateOrder]...';


GO
ALTER PROCEDURE [dbo].[CreateOrder]
	@userId int,
	@bookId int,
	@bookLanguage int,
	@orderDate datetime2,
	@address NVARCHAR(20),
	@country int,
	@orderId INT OUTPUT
AS
	
	INSERT INTO Orders (UserId, BookId, BookLanguage, OrderDate, [Address], Country)
	VALUES (@userId, @bookId, @bookLanguage, @orderDate, @address, @country)

	SET @orderId = @@IDENTITY
RETURN
GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [Languages] ([Language])
VALUES
('English'),
('Russian'),
('Armenian'),
('French'),
('Spanish'),
('German'),
('Italian')
INSERT INTO [Countries] (Country)
VALUES
('Armenia'),
('Russia'),
('France'),
('USE'),
('Germany')
GO

GO
PRINT N'Update complete.';


GO
