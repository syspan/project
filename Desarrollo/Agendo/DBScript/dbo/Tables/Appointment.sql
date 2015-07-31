CREATE TABLE [dbo].[Appointment] (
    [Id]           INT      NOT NULL,
    [DateTime]     DATETIME NOT NULL,
    [VisitorId]    INT      NOT NULL,
    [ServiceId]    INT      NOT NULL,
    [SpecialistId] INT      NOT NULL,
    [Status]       INT      NOT NULL,
    CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Appointment_Service] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([Id]),
    CONSTRAINT [FK_Appointment_Specialist] FOREIGN KEY ([SpecialistId]) REFERENCES [dbo].[Specialist] ([Id]),
    CONSTRAINT [FK_Appointment_Visitor] FOREIGN KEY ([VisitorId]) REFERENCES [dbo].[Visitor] ([Id])
);

