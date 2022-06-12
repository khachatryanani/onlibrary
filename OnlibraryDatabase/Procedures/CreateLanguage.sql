CREATE PROCEDURE [dbo].[CreateLanguage]
	@language NVARCHAR(20)
AS
	INSERT INTO [Languages] ([Language])
	VALUES (@language)
RETURN 
