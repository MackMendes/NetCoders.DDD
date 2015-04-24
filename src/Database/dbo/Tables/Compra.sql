CREATE TABLE dbo.Compra
(
	IdCompra INT NOT NULL IDENTITY,
	IdFornecedor INT NOT NULL,
	DataCadastro SMALLDATETIME NOT NULL,
	CONSTRAINT PK_IdCompra
		PRIMARY KEY (IdCompra)
)

GO

ALTER TABLE dbo.Compra
	ADD CONSTRAINT FK_CompraIdFornecedor
		FOREIGN KEY (IdFornecedor)
		REFERENCES dbo.Fornecedor (IdFornecedor)
	