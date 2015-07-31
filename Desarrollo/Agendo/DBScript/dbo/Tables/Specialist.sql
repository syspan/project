CREATE TABLE [dbo].[Specialist] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Identifier] VARCHAR (10)  NULL,
    [Name]       VARCHAR (100) NOT NULL,
    [LastName]   VARCHAR (100) NULL,
    [HireDate]   DATETIME      NULL,
    [Percentaje] FLOAT (53)    NULL,
    [ServiceId]  INT           NULL,
    [TypeId]     INT           NULL,
    [ImageUrl]   VARCHAR (100) NULL,
    CONSTRAINT [PK_Specialist_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Specialist_Service] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([Id]),
    CONSTRAINT [FK_Specialist_SpecialistType] FOREIGN KEY ([TypeId]) REFERENCES [dbo].[SpecialistType] ([Id])
);

