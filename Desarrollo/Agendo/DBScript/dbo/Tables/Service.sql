CREATE TABLE [dbo].[Service] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (100) NOT NULL,
    [AvgTime]    DATETIME      NULL,
    [Precio]     FLOAT (53)    NULL,
    [CategoryId] INT           NOT NULL,
    [Status]     INT           NOT NULL,
    CONSTRAINT [PK_Specialist] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Service_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id])
);



