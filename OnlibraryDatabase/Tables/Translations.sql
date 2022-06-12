CREATE TABLE [dbo].[Translations]
(
	[TranslationId] INT IDENTITY (1,1),
	[BookId] INT REFERENCES Books(BookId) ON DELETE CASCADE,
	[LanguageId] INT REFERENCES Languages(LanguageId),
	CONSTRAINT PK_TranslationId PRIMARY KEY (TranslationId)
)
