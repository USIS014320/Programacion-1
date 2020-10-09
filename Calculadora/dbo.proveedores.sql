CREATE TABLE [dbo].[proveedores] (
    [idProveedor]       INT        IDENTITY (1, 1) NOT NULL,
	[codigo] CHAR (5) NOT NULL,
    [nombreempresa]     CHAR (10)  NOT NULL,
    [nombrepropietario] CHAR (65)  NOT NULL,
    [direccion]         CHAR (100) NOT NULL,
    [telefono]          CHAR (15)  NULL,
    [email]             CHAR (50)  NULL,
    [webSite]           CHAR (200) NULL,
    [fechaproveedor]    DATETIME   NOT NULL,
    [pais]              CHAR (10)  NOT NULL,
    [departamento]      CHAR (50)  NOT NULL,
    [municipio]         CHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([idProveedor] ASC)
);

