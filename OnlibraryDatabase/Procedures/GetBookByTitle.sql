CREATE PROCEDURE [dbo].[GetBookByTitle]
	@title NVARCHAR(50)
AS
	SELECT * FROM Books WHERE Books.Title = @title
RETURN 0
