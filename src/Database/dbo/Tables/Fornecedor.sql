CREATE TABLE [dbo].[Fornecedor]
(
	IdFornecedor INT NOT NULL IDENTITY,
	Nome VARCHAR(200) NOT NULL,
	DataCadastro SMALLDATETIME NOT NULL,
	CONSTRAINT PK_Fornecedor
		PRIMARY KEY (IdFornecedor)
)

GO

ALTER TABLE dbo.Fornecedor
	ADD CONSTRAINT DF_FornecedorDataCadastro
		DEFAULT (GETDATE()) FOR DataCadastro
