CREATE TABLE [dbo].[Producto] (
    [CodProducto]            VARCHAR (35)     NOT NULL,
    [Descripcion]            VARCHAR (80)     NOT NULL,
    [PrecioVentaNeto]        INT              NOT NULL,
    [ActivarPrecioMayorista] BIT              NOT NULL,
    [Exento]                 BIT              NOT NULL,
    [Inventariable]          BIT              NOT NULL,
    [Descontinuado]          BIT              NOT NULL,
    [UnidadMedida]           INT              NULL,
    [Observacion]            VARCHAR (500)    NULL,
    [DescripcionLarga]       VARCHAR (500)    NULL,
    [CentroCostoId]          UNIQUEIDENTIFIER NULL,
    [CodAlternativo]         VARCHAR (35)     NULL,
    CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED ([CodProducto] ASC)
);

