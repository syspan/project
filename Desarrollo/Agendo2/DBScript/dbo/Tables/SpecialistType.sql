CREATE TABLE [dbo].[SpecialistType] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Name]   VARCHAR (100) NOT NULL,
    [Status] INT           NOT NULL,
    CONSTRAINT [PK_SpecialistType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

