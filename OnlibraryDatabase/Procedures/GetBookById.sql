CREATE PROCEDURE [dbo].[GetBookById]
	@id int
AS
	SELECT * From Books WHERE Books.BookId = @id;
RETURN 0
