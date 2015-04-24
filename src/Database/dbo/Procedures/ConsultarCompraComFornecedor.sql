CREATE PROCEDURE dbo.ConsultarCompraComFornecedor
AS
BEGIN
	SELECT
		c.IdCompra,
		c.IdFornecedor,
		c.DataCadastro,
		f.Nome AS NomeFornecedor,
		f.DataCadastro AS DataCadastroFornecedor
	FROM
		dbo.Compra c
		JOIN dbo.Fornecedor f ON f.IdFornecedor = c.IdFornecedor

END