CREATE PROCEDURE dbo.AdicionarCompra
(
 @IdFornecedor INT,
 @DataCadastro SMALLDATETIME
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT	INTO dbo.Compra
			(IdFornecedor, DataCadastro)
	VALUES
			(@IdFornecedor, -- IdFornecedor - int
			 @DataCadastro  -- DataCadastro - smalldatetime
			 )
	SELECT CONVERT(INT, SCOPE_IDENTITY()) AS IdCompra
END