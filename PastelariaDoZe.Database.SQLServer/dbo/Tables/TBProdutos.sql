CREATE TABLE [dbo].[TBProdutos] (
    [Id]             INT NOT NULL IDENTITY,
    [Nome]           VARCHAR (50) NOT NULL,
    [ValorUnitario]        FLOAT (53)   NOT NULL,
    [DataValidade]    DATE   NOT NULL,
    [Quantidade] INT NOT NULL,
    [Foto] IMAGE NOT NULL,
    CONSTRAINT [PK_TBProdutos] PRIMARY KEY CLUSTERED ([Id] ASC)
);