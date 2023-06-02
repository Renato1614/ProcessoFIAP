CREATE TABLE [dbo].[Turmas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CursoId] INT NULL, 
    [TurmaNome] VARCHAR(45) NULL, 
    [Ano] INT NULL, 
    [Status] BIT NULL
)
