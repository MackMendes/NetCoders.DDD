CREATE PROCEDURE [dbo].[ConsultarFornecedores]
AS
BEGIN
	SELECT
		IdFornecedor,
		Nome,
		DataCadastro
	FROM
		dbo.Fornecedor
END