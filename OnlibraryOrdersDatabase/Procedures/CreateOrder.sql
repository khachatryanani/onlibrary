CREATE PROCEDURE [dbo].[CreateOrder]
	@userId NVARCHAR(50),
	@bookId int,
	@bookLanguage int,
	@orderDate datetime2,
	@address NVARCHAR(20),
	@country int,
	@orderId INT OUTPUT
AS
	
	INSERT INTO Orders (UserId, BookId, BookLanguage, OrderDate, [Address], Country)
	VALUES (@userId, @bookId, @bookLanguage, @orderDate, @address, @country)

	SET @orderId = @@IDENTITY
RETURN 
