CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] NVARCHAR(MAX) NOT NULL, 
    [Name] NVARCHAR(100) NOT NULL, 
    [PasswordHash] NVARCHAR(MAX) NOT NULL, 
    [CompanyName] NVARCHAR(250) NULL, 
    [EmailConfirmed] BIT NOT NULL, 
    [UID] UNIQUEIDENTIFIER NOT NULL, 
    [FirstLogin] BIT NOT NULL
)
