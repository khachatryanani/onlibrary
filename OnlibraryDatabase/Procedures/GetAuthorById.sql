CREATE PROCEDURE [dbo].[GetAuthorById]
	@id int
AS
	SELECT * From Authors WHERE Authors.AuthorId = @id;
RETURN 0
