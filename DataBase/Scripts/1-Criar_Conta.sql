GO
CREATE TABLE [dbo].[Conta] (
    [IdConta] INT  IDENTITY (1, 1) NOT NULL,
    [Login]   TEXT NOT NULL,
    [Senha]   TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdConta] ASC)
);

GO
CREATE TABLE [dbo].[Contato] (
    [IdContato] INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      NVARCHAR (50) NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    [Telefone]  NVARCHAR (20) NOT NULL,
    [IdConta]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([IdContato] ASC),
	FOREIGN KEY (IdConta) references [dbo].Conta(IdConta)
);
