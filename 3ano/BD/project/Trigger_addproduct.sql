CREATE TRIGGER CHINSELL.addproduct ON CHINSELL.PRODUTO
AFTER INSERT, UPDATE
AS 
       BEGIN
	      SET NOCOUNT ON;
	      DECLARE @Pre�o AS float;
	      DECLARE @Marca AS varchar(20);
	      DECLARE @T�tulo AS varchar(50);
	      DECLARE @erro VARCHAR(100)

	      IF @Pre�o < 0.0
	          BEGIN
		          SELECT @erro = ERROR_MESSAGE();
		          SET @erro = 'Pre�o Inv�lido!'
		          ROLLBACK TRAN;
	           END

	       IF LEN(@T�tulo) = 0
	           BEGIN
		           SELECT @erro = ERROR_MESSAGE();
		           SET @erro = 'Insira um t�tulo v�lido!'
		           ROLLBACK TRAN;
	           END

	        IF LEN(@Marca) = 0
	           BEGIN
		           SELECT @erro = ERROR_MESSAGE();
		           SET @erro = 'Insira uma marca v�lida!'
		           ROLLBACK TRAN;
	            END
            END
GO