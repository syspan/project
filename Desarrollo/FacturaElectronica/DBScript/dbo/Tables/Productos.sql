CREATE TABLE [dbo].[Productos] (
    [CodProducto]            VARCHAR (35)     NOT NULL,
    [Descripcion]            VARCHAR (80)     NOT NULL,
	[CodBarra]				 VARCHAR(100)	  NOT NULL,
    [ActivarPrecioMayorista] BIT              NOT NULL,
    [UnidadMedida]           INT              NULL,
    [Observacion]            VARCHAR (500)    NULL,
    [CategoriaId]			 INT     NOT NULL,
	[PrecioVentaNeto]		 INT NOT NULL,
    [StockAlerta] INT NULL, 
    [StockDeseado] INT NULL, 
    CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED ([CodProducto] ASC)
);

