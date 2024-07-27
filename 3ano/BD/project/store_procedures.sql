DROP PROCEDURE IF EXISTS CHINSELL.AdicionarProduto;
DROP PROCEDURE IF EXISTS CHINSELL.EditarProduto;
DROP PROCEDURE IF EXISTS CHINSELL.EliminarProduto;
GO
CREATE PROCEDURE CHINSELL.AdicionarProduto(@produto_id int, @Pre�o float, @Marca varchar(20), @T�tulo varchar(50), @imagem_url varchar(MAX), @categoria_id int, @subcategoria_id int, @vendedor_id int)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100)
		SET @count = (SELECT CHINSELL.VerificarTitulo(@T�tulo))
		IF(@count>=1)
			RAISERROR ('O Produto introduzido j� existe!', 16,1);
		ELSE 
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO CHINSELL.PRODUTO(produto_id, Pre�o, Marca, T�tulo, imagem_url, categoria_id, subcategoria_id, vendedor_id) VALUES (@produto_id, @Pre�o, @Marca, @T�tulo, @imagem_url, @categoria_id, @subcategoria_id, @vendedor_id)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O Produto n�o foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO


CREATE PROCEDURE CHINSELL.EditarProduto(@produto_id int, @Pre�o float, @Marca varchar(20), @T�tulo varchar(50), @imagem_url varchar(MAX), @categoria_id int, @subcategoria_id int, @vendedor_id int)
AS
	BEGIN
		DECLARE @erro VARCHAR(100)
		BEGIN TRY
			UPDATE CHINSELL.PRODUTO
					SET
					Pre�o=@Pre�o,
					Marca=@Marca,
					T�tulo=@T�tulo,
					imagem_url=@imagem_url,
					categoria_id=@categoria_id,
					subcategoria_id=@subcategoria_id,
					vendedor_id=@vendedor_id

					WHERE produto_id=@produto_id
			END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SELECT @erro = ERROR_MESSAGE();
			SET @erro = 'O produto n�o foi editado, algo inserido incorretamente'
			RAISERROR (@erro, 16,1);
		END CATCH
	END
GO

CREATE PROCEDURE CHINSELL.EliminarProduto(@produto_id int)
AS
	BEGIN
		DECLARE @erro VARCHAR(100)
			DELETE FROM CHINSELL.PRODUTO
			WHERE produto_id=@produto_id
	END
GO