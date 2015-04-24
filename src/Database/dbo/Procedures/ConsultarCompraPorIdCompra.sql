CREATE PROCEDURE dbo.ConsultarCompraPorIdCompra (@IdCompra INT)
AS
BEGIN
    SELECT
        IdCompra,
        IdFornecedor,
        DataCadastro
    FROM
        dbo.Compra
    WHERE
        IdCompra = @IdCompra
END