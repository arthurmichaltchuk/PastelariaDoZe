﻿CREATE TABLE [dbo].[TBFuncionarios] (
    [Id]             INT NOT NULL IDENTITY,
    [Nome]           VARCHAR (50) NOT NULL,
    [Salario]        FLOAT (53)   NOT NULL,
    [DataEntrada]    DATE         NOT NULL,
    [CpfFuncionario] VARCHAR (50) NOT NULL,
    [Usuario]        VARCHAR (50) NOT NULL,
    [Senha]          VARCHAR (64) NOT NULL,
    CONSTRAINT [PK_TBFuncionarios] PRIMARY KEY CLUSTERED ([Id] ASC)
);

