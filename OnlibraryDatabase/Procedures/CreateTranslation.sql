CREATE PROCEDURE [dbo].[CreateTranslation]
	@bookId int,
	@languageId int
AS
	INSERT INTO [Translations](BookId, LanguageId)
	VALUES (@bookId, @languageId)
RETURN
