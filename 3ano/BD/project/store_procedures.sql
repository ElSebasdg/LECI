DROP PROCEDURE IF EXISTS CHINSELL.AdicionarProduto;
DROP PROCEDURE IF EXISTS CHINSELL.EditarProduto;
DROP PROCEDURE IF EXISTS CHINSELL.EliminarProduto;
GO
CREATE PROCEDURE CHINSELL.AdicionarProduto(@produto_id int, @Preço float, @Marca varchar(20), @Título varchar(50), @imagem_url varchar(MAX), @categoria_id int, @subcategoria_id int, @vendedor_id int)
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100)
		SET @count = (SELECT CHINSELL.VerificarTitulo(@Título))
		IF(@count>=1)
			RAISERROR ('O Produto introduzido já existe!', 16,1);
		ELSE 
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO CHINSELL.PRODUTO(produto_id, Preço, Marca, Título, imagem_url, categoria_id, subcategoria_id, vendedor_id) VALUES (@produto_id, @Preço, @Marca, @Título, @imagem_url, @categoria_id, @subcategoria_id, @vendedor_id)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O Produto não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO


CREATE PROCEDURE CHINSELL.EditarProduto(@produto_id int, @Preço float, @Marca varchar(20), @Título varchar(50), @imagem_url varchar(MAX), @categoria_id int, @subcategoria_id int, @vendedor_id int)
AS
	BEGIN
		DECLARE @erro VARCHAR(100)
		BEGIN TRY
			UPDATE CHINSELL.PRODUTO
					SET
					Preço=@Preço,
					Marca=@Marca,
					Título=@Título,
					imagem_url=@imagem_url,
					categoria_id=@categoria_id,
					subcategoria_id=@subcategoria_id,
					vendedor_id=@vendedor_id

					WHERE produto_id=@produto_id
			END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SELECT @erro = ERROR_MESSAGE();
			SET @erro = 'O produto não foi editado, algo inserido incorretamente'
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