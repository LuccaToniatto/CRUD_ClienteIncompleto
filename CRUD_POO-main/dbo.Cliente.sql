CREATE TABLE [dbo].[Cliente] (
    [Id]      INT        IDENTITY (1, 1) NOT NULL,
    [nome]    NCHAR (85) NULL,
    [cidade]  NCHAR (65) NULL,
    [email]   NCHAR (85) NULL,
    [celular] NCHAR (30) NULL,
    [date]    DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

