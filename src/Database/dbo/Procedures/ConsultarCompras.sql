CREATE PROCEDURE dbo.ConsultarCompras
AS
BEGIN
    SELECT
        IdCompra,
        IdFornecedor,
        DataCadastro
    FROM
        dbo.Compra
END