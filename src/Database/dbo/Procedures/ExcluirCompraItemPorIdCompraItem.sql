CREATE PROCEDURE dbo.ExcluirCompraItemPorIdCompraItem
(
	@IdCompraItem INT
)
AS	
BEGIN
	DELETE
		dbo.CompraItem
	WHERE	
		IdCompraItem = @IdCompraItem
END