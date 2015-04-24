CREATE PROCEDURE dbo.AdicionarCompraItem
(
	@IdCompra INT,
	@IdProduto INT,
	@Quantidade INT,
	@Valor DECIMAL
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.CompraItem
			(
			 IdCompra,
			 IdProduto,
			 Quantidade,
			 Valor
			)
	VALUES
			(
			 @IdCompra, -- IdCompra - int
			 @IdProduto, -- IdProduto - int
			 @Quantidade, -- Quantidade - int
			 @Valor  -- Valor - decimal
			)
	SELECT CONVERT(INT, SCOPE_IDENTITY()) AS IdCompraItem
END