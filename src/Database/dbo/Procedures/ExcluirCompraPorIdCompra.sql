CREATE PROCEDURE dbo.ExcluirCompraPorIdCompra
(
	@IdCompra INT
)
AS	
BEGIN
	DELETE
		dbo.Compra
	WHERE
		IdCompra = @IdCompra
END