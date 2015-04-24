CREATE PROCEDURE dbo.ExcluirCompraItensPorIdCompra
(
	@IdCompra INT
)
AS	
BEGIN
	DELETE
		dbo.CompraItem
	WHERE	
		IdCompra = @IdCompra
END