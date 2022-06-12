CREATE TABLE [dbo].[Authors]
(
	[AuthorId] INT IDENTITY (10,1),
	[AuthorFirstName] NVARCHAR(50) NOT NULL,
	[AuthorLastName] NVARCHAR(50) NOT NULL,
	[Nationality] NVARCHAR(30),
	[Country] NVARCHAR(30),
	[Rating] INT DEFAULT 0,
	CONSTRAINT PK_AuthorID PRIMARY KEY (AuthorID)

)
