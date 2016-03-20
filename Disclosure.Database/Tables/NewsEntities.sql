CREATE TABLE [dbo].[NewsEntities]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Headline] NVARCHAR(MAX) NULL, 
    [Body] NVARCHAR(MAX) NULL, 
    [Summary] NVARCHAR(MAX) NULL, 
    [Author] NVARCHAR(MAX) NULL, 
    [PublicationDate] DATETIME NULL
)
