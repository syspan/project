CREATE TABLE [dbo].[Provincias] (
    [Id]       INT          NOT NULL,
    [Nombre]   VARCHAR (50) NOT NULL,
    [RegionId] INT          NOT NULL,
    CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Provincias_Regiones] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Regiones] ([Id])
);

