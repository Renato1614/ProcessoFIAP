CREATE TABLE [dbo].[Aluno_Turma]
(
	[Id] INT  IDENTITY (1, 1) NOT NULL , 
    [TurmaId] INT NOT NULL, 
    [AlunoId] INT NOT NULL, 
    PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_AlunoTurma_Alunos] FOREIGN KEY ([AlunoId]) REFERENCES [Alunos]([Id]), 
    CONSTRAINT [FK_AlunoTurma_Turmas] FOREIGN KEY ([TurmaId]) REFERENCES [Turmas]([Id]), 
)
