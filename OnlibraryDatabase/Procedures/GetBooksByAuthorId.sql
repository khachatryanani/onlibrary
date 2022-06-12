CREATE PROCEDURE [dbo].[GetBooksByAuthorId]
	@id int
AS
	SELECT * FROM Books WHERE Books.AuthorId = @id;
RETURN 0
