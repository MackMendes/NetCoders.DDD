CREATE PROCEDURE [dbo].[ConsultarProdutos]
AS
BEGIN
	SELECT
		IdProduto,
		Nome
	FROM
		dbo.Produto
END