CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT IDENTITY (1,1),
	[UserId] NVARCHAR(50) NOT NULL,
	[BookId] INT NOT NULL,
	[BookLanguage] INT NOT NULL REFERENCES Languages(LanguageId),
	[OrderDate] DATETIME2 NOT NULL,
	[Address] NVARCHAR(30),
	[Country] INT NOT NULL REFERENCES Countries(CountryId),
	CONSTRAINT PK_OrderID PRIMARY KEY (OrderId)

)
