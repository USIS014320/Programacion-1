CREATE TABLE [dbo].[proveedores] (
    [idProveedor]       INT NOT NULL IDENTITY,
    [codigo]            CHAR (5)   NOT NULL,
    [nombreempresa]     CHAR (10)  NOT NULL,
    [nombrepropietario] CHAR (65)  NOT NULL,
    [telefono]          CHAR (15)  NULL,
    [email]             CHAR (50)  NULL,
    [website]           CHAR (200) NULL,
    [fechaproveedor]    CHAR (20)  NOT NULL,
    [pais]              CHAR (10)  NOT NULL,
    [departamento]      CHAR (50)  NULL,
    [municipio]         CHAR (50)  NULL,
    [canton]            CHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([idProveedor] ASC)
);

