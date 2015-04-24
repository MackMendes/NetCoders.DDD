CREATE TABLE dbo.CompraItem
(
	IdCompraItem INT NOT NULL IDENTITY,
	IdCompra INT NOT NULL,
	IdProduto INT NOT NULL,
	Quantidade INT NOT NULL,
	Valor DECIMAL NOT NULL,
	CONSTRAINT PK_CompraItem
		PRIMARY KEY (IdCompraItem)
)

GO

ALTER TABLE dbo.CompraItem
	ADD CONSTRAINT FK_CompraItemIdCompra
		FOREIGN KEY (IdCompra)
		REFERENCES dbo.Compra (IdCompra)

GO

ALTER TABLE dbo.CompraItem
	ADD CONSTRAINT FK_CompraItemIdProduto
		FOREIGN KEY (IdProduto)
		REFERENCES dbo.Produto (IdProduto)