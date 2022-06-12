CREATE PROCEDURE [dbo].[CreateBook]
	@title NVARCHAR(30),
	@year int,
	@pages int, 
	@authorId int
AS
	INSERT INTO [Books] (Title, Year, Pages, AuthorId)
	VALUES (@title, @year, @pages, @authorId)
RETURN
