CREATE PROCEDURE [dbo].[ConsultarProdutoPorIdProduto] (@IdProduto INT)
AS
BEGIN
	SELECT
		IdProduto,
		Nome
	FROM
		dbo.Produto
	WHERE
		IdProduto = @IdProduto
END