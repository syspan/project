CREATE TABLE [dbo].[ClienteProveedor] (
    [Rut]                 VARCHAR (10)     NOT NULL,
    [RazonSocial]         VARCHAR (200)    NOT NULL,
    [Tipo]                INT              NOT NULL,
    [NombreFantasia]      VARCHAR (200)    NULL,
    [Giro]                VARCHAR (200)    NOT NULL,
    [CodigoCliente]       VARCHAR (50)     NULL,
    [Telefono]            INT              NULL,
    [Correo]              VARCHAR (200)    NULL,
    [Fax]                 INT              NULL,
    [VendedorId]          UNIQUEIDENTIFIER NULL,
    [PermiteFacturar]     BIT              NOT NULL,
    [NoEsAgenteRetenedor] BIT              NOT NULL,
    [EsRolPrivado]        BIT              NOT NULL,
    [ComunaId]            INT              NOT NULL,
    [Observacion]         VARCHAR (500)    NULL,
    CONSTRAINT [PK_ClienteProveedor] PRIMARY KEY CLUSTERED ([Rut] ASC)
);

