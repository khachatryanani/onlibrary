CREATE PROCEDURE [dbo].[GetOrders]
@userId NVARCHAR(50)
AS
	SELECT * FROM Orders WHERE UserId = @userId
RETURN 0
