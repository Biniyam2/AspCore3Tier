CREATE TABLE [dbo].[PeopleDb]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(50) NULL, 
    [LastName] NCHAR(50) NULL, 
    [Email] NCHAR(100) NULL, 
    [PhoneNumber] NCHAR(20) NULL, 
    [UserName] NCHAR(50) NULL, 
    [Password] NCHAR(100) NULL
)
