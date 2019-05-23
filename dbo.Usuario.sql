CREATE TABLE [dbo].[Usuario] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [NombreUsuario] VARCHAR (50) NULL,
    [Edad]          INT          NULL,
    [Tipo]          INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

