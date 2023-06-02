CREATE TABLE [dbo].[Alunos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY , 
    [Nome] VARCHAR(50) NULL, 
    [Usuario] NCHAR(255) NULL, 
    [Senha] CHAR(60) NULL, 
    [Status] BIT NULL
)
