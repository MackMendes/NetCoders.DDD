CREATE PROCEDURE dbo.ConsultarCompraItensPorIdCompra (@IdCompra INT)
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
		IdCompra = @IdCompra
END