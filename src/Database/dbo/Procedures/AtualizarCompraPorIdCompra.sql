CREATE PROCEDURE dbo.AtualizarCompraPorIdCompra
(
	@IdCompra INT,
	@IdFornecedor INT
)
AS	
BEGIN
	UPDATE
		dbo.Compra
	SET
		IdFornecedor = @IdFornecedor
	WHERE
		IdCompra = @IdCompra
END