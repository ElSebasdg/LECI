DROP VIEW IF EXISTS list_catalog;
GO

CREATE VIEW list_catalog AS
SELECT produto_id, Preço, Marca, Título, imagem_url
FROM CHINSELL.PRODUTO