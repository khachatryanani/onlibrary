CREATE TABLE [dbo].[Countries]
(
	[CountryId] INT IDENTITY (1,1),
	[Country] NVARCHAR(20) UNIQUE,
	CONSTRAINT PK_CountryId PRIMARY KEY ([CountryId])
)
