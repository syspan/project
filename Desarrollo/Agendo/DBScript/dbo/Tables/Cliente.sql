CREATE TABLE [dbo].[Cliente] (
    [Rut]            VARCHAR (10)  NOT NULL,
    [RazonSocial]    VARCHAR (200) NOT NULL,
    [NombreFantasia] VARCHAR (200) NULL,
    [Giro]           VARCHAR (200) NOT NULL,
    [Telefono]       INT           NULL,
    [Correo]         VARCHAR (200) NULL,
    [Fax]            INT           NULL,
    [ComunaId]       INT           NOT NULL,
    [Observacion]    VARCHAR (500) NULL,
    [Estado]         INT           NOT NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([Rut] ASC)
);

