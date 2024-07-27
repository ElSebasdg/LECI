CREATE TRIGGER CHINSELL.addproduct ON CHINSELL.PRODUTO
AFTER INSERT, UPDATE
AS 
       BEGIN
	      SET NOCOUNT ON;
	      DECLARE @Preço AS float;
	      DECLARE @Marca AS varchar(20);
	      DECLARE @Título AS varchar(50);
	      DECLARE @erro VARCHAR(100)

	      IF @Preço < 0.0
	          BEGIN
		          SELECT @erro = ERROR_MESSAGE();
		          SET @erro = 'Preço Inválido!'
		          ROLLBACK TRAN;
	           END

	       IF LEN(@Título) = 0
	           BEGIN
		           SELECT @erro = ERROR_MESSAGE();
		           SET @erro = 'Insira um título válido!'
		           ROLLBACK TRAN;
	           END

	        IF LEN(@Marca) = 0
	           BEGIN
		           SELECT @erro = ERROR_MESSAGE();
		           SET @erro = 'Insira uma marca válida!'
		           ROLLBACK TRAN;
	            END
            END
GO