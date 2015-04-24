CREATE PROCEDURE dbo.ConsultarCompraItemPorIdCompraItem (@IdCompraItem INT)
AS
BEGIN
	SELECT
		IdCompraItem,
		IdCompra,
		IdProduto,
		Quantidade,
		Valor
	FROM
		dbo.CompraItem
	WHERE
		IdCompraItem = @IdCompraItem
END