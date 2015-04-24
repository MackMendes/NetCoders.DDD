CREATE PROCEDURE RelatorioCompraPorIdFornecedor (@IdFornecedor INT)
AS
BEGIN
	SELECT
		f.Nome AS NomeFornecedor,
		COUNT(c.IdCompra) AS QtdeCompras,
		SUM(ci.Quantidade * ci.Valor) AS Total
	FROM
		dbo.Compra c
		JOIN dbo.Fornecedor f ON f.IdFornecedor = c.IdFornecedor
		JOIN dbo.CompraItem ci ON ci.IdCompra = c.IdCompra
	WHERE
		f.IdFornecedor = @IdFornecedor
	GROUP BY
		f.Nome
END