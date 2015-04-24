CREATE PROCEDURE dbo.ConsultarCompraItens
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
END