DROP VIEW IF EXISTS list_catalog;
GO

CREATE VIEW list_catalog AS
SELECT produto_id, Pre�o, Marca, T�tulo, imagem_url
FROM CHINSELL.PRODUTO