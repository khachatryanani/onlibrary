CREATE PROCEDURE [dbo].[GetTranslationByBookId]
	@id int = 0
AS
	SELECT Translations.BookId, Languages.LanguageId, Languages.[Language] FROM Translations JOIn Languages on Translations.LanguageId = Languages.LanguageId WHERE BookId = @id;
RETURN 0
