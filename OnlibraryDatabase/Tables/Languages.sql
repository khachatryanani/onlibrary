CREATE TABLE [dbo].[Languages]
(
	[LanguageId] INT IDENTITY (1,1),
	[Language] NVARCHAR(20) UNIQUE,
	CONSTRAINT PK_LanguageId PRIMARY KEY (LanguageId)
)
