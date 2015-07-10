CREATE TABLE [dbo].[Comunas] (
    [Id]          INT          NOT NULL,
    [Nombre]      VARCHAR (50) NOT NULL,
    [ProvinciaId] INT          NOT NULL,
    CONSTRAINT [PK_Comunas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comunas_Provincias] FOREIGN KEY ([ProvinciaId]) REFERENCES [dbo].[Provincias] ([Id])
);

