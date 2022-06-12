CREATE PROCEDURE [dbo].[CreateAuthor]
	@firstName NVARCHAR(50),
	@lastName NVARCHAR(50),
	@nationality NVARCHAR(20),
	@country NVARCHAR(20)
AS
	INSERT INTO [Authors] (AuthorFirstName, AuthorLastName, Nationality, Country)
	VALUES (@firstName, @lastName, @nationality, @country)
RETURN
