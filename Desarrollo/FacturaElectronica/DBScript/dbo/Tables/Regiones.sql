CREATE TABLE [dbo].[Regiones] (
    [Id]            INT          NOT NULL,
    [Nombre]        VARCHAR (50) NOT NULL,
    [RegionOrdinal] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Regiones] PRIMARY KEY CLUSTERED ([Id] ASC)
);

