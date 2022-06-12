CREATE PROCEDURE [dbo].[GetCollection]
AS
	SELECT Books.BookId, Books.Title, Books.Year, Books.Pages, Authors.AuthorFirstName + ' ' + AuthorLastName as AuthorName, Books.Rating, Languages.Language
	FROM Books 
		JOIN Translations on Books.BookId = Translations.BookId
		JOIN Authors on Books.AuthorId = Authors.AuthorId
		JOIN Languages on Translations.LanguageId = Languages.LanguageId
RETURN 0
