CREATE TABLE [dbo].[Template]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(250) NOT NULL, 
    [Subject] NVARCHAR(250) NOT NULL, 
    [Body] TEXT NOT NULL
)
