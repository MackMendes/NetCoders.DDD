CREATE PROCEDURE dbo.AtualizarCompraItemPorIdCompraItem
(
	@IdCompraItem INT,
	@IdProduto INT,
	@Quantidade INT,
	@Valor DECIMAL
)
AS
BEGIN
	UPDATE
		dbo.CompraItem
	SET	
		IdProduto = @IdProduto,
		Quantidade = @Quantidade,
		Valor = @Valor
	WHERE
		IdCompraItem = @IdCompraItem
END