/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [Authors] (AuthorFirstName, AuthorLastName, Nationality, Country, Rating)
VALUES
('Eric', 'Fromm', 'German', 'Germany', 9),
('Eric', 'Berne', 'Canadian', 'Canada', 7),
('William', 'Saroyan', 'Armenian', 'USA', 10),
('Michail', 'Bulgakov', 'Russian', 'Russia', 9),
('Yuval Noah', 'Harari', 'Israelian', 'Israel', 8)
INSERT INTO [Languages] ([Language])
VALUES
('English'),
('Russian'),
('Armenian'),
('French'),
('Spanish'),
('German'),
('Italian')
INSERT INTO [Books] (Title, Year, AuthorId, Pages, Rating)
VALUES
('The Art of Loving', 1956, 10, 230, 10),
('To Have or To Be', 1976, 10, 287, 9),
('Games People Play',1964,11,216,7),
('What Do You Say after You Say Hello',1972,11,342,8),
('The Human Comedy',1943,12,416,10),
('My Name Is Aram',1940,12,320,10),
('The Master and Margarita',1966,13,314,9),
('The Heart of Dog',1940,13,215,10),
('Sapiens: The Brief History of HumanKind',2011,14,528,8),
('Homo Deus: The Brief History of Tommorow',2015,14,642,9)
INSERT INTO [Translations] (BookId, LanguageId)
VALUES
(1000,1),
(1000,2),
(1000,3),
(1000,4),
(1001,1),
(1003,1),
(1003,2),
(1003,5),
(1002,1),
(1004,1),
(1004,5),
(1004,6),
(1004,1),
(1005,1),
(1006,1),
(1007,1),
(1007,2),
(1008,2),
(1008,1),
(1009,1),
(1009,3),
(1009,2)
GO
