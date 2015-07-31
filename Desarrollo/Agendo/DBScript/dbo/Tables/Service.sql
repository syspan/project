CREATE TABLE [dbo].[Service] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (100) NOT NULL,
    [AvgTime] DATETIME      NULL,
    [Status]  INT           NOT NULL,
    CONSTRAINT [PK_Specialist] PRIMARY KEY CLUSTERED ([Id] ASC)
);

