CREATE TABLE [dbo].[Proveedor] (
    [Rut]            VARCHAR (10)  NOT NULL,
    [RazonSocial]    VARCHAR (200) NOT NULL,
    [NombreContacto] VARCHAR (100) NULL,
    [Cargo]          VARCHAR (80)  NULL,
    [NombreFantasia] VARCHAR (200) NULL,
    [Giro]           VARCHAR (200) NOT NULL,
    [Telefono]       INT           NULL,
    [Correo]         VARCHAR (200) NULL,
    [Fax]            INT           NULL,
    [ComunaId]       INT           NOT NULL,
    [Observacion]    VARCHAR (500) NULL,
    [Url]            VARCHAR (100) NULL,
    [Estado]         INT           NOT NULL,
    CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED ([Rut] ASC)
);

