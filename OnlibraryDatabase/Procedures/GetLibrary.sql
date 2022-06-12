CREATE PROCEDURE [dbo].[GetLibrary]
AS
	SELECT Authors.AuthorId, AuthorFirstName, AuthorLastName,Nationality, Country, Authors.Rating as AuthorRating, Books.BookId, Title, Year, Books.Rating as BookRating, Pages, DocumentURl, Languages.[Language]
	FROM Authors 
		JOIN Books on Authors.AuthorId = Books.AuthorId 
		JOIN Translations on Books.BookId = Translations.BookId 
		JOIN Languages on Translations.[LanguageId] = Languages.LanguageId
RETURN 0
