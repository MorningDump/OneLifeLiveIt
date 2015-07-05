CREATE TABLE [dbo].[Questionaire]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [YearOfBirth] INT NOT NULL, 
    [Sex] VARCHAR(10) NOT NULL, 
    [Occupation] VARCHAR(250) NOT NULL, 
    [Height] VARCHAR(50) NOT NULL, 
    [Weight] VARCHAR(50) NOT NULL, 
    [ActivityLevel] VARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_Questionaire_User] FOREIGN KEY (UserId) REFERENCES [User]([Id])
)
