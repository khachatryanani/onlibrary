CREATE PROCEDURE [dbo].[GetAuthorByName]
	@firstName NVARCHAR(50),
	@lastName NVARCHAR(50)

AS
	SELECT * FROM Authors WHERE Authors.AuthorFirstName LIKE @firstName AND Authors.AuthorLastName LIKE @lastName
RETURN 0
