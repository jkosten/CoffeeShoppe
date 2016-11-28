CREATE TABLE [dbo].[MenuItems]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Category] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(210) NOT NULL, 
    [Price] SMALLMONEY NOT NULL, 
    [Availability] BIT NOT NULL, 
    [Detailed Description] NVARCHAR(500) NULL
)
