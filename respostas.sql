CREATE TABLE [dbo].[Respostas] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (100) NOT NULL,
    [Email]    VARCHAR (50)  NOT NULL,
    [Telefone] VARCHAR (20)  NOT NULL,
    [Presenca] BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);