CREATE TABLE [dbo].[Books]
(
	[BookId] INT IDENTITY (1000, 1),
	[Title] NVARCHAR(100) NOT NULL,
	[Year] INT NOT NULL,
	[Rating] INT DEFAULT 0,
	[Pages] INT DEFAULT 17,
	[DocumentURL] VARCHAR(2048) NULL,
	[AuthorId] INT REFERENCES Authors(AuthorId),
	CONSTRAINT CHD_Pages CHECK ([Pages] >= 17),
	CONSTRAINT PK_BookID PRIMARY KEy (BookId)

)
