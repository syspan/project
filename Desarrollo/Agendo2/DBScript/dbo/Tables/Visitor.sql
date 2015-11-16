CREATE TABLE [dbo].[Visitor] (
    [Id]       INT           NOT NULL,
    [Nombre]   VARCHAR (100) NOT NULL,
    [Telefono] INT           NOT NULL,
    [Email]    VARCHAR (100) NULL,
    CONSTRAINT [PK_Visitor] PRIMARY KEY CLUSTERED ([Id] ASC)
);

