--CREATE SCHEMA CHINSELL;
--GO


DROP TABLE IF EXISTS CHINSELL.PRODUTO;
DROP TABLE IF EXISTS CHINSELL.COMPRA;;
DROP TABLE IF EXISTS CHINSELL.SUBCATEGORIA;
DROP TABLE IF EXISTS CHINSELL.CATEGORIA;
DROP TABLE IF EXISTS CHINSELL.VENDEDOR;
DROP TABLE IF EXISTS CHINSELL.COMPRADOR
DROP TABLE IF EXISTS CHINSELL.UTILIZADOR;
GO

CREATE TABLE CHINSELL.UTILIZADOR (
	id						int	NOT NULL,
	Num_Telemovel			varchar(13)	NOT NULL,
	Email					varchar(30) NOT NULL,
	Pass					varchar(30) NOT NULL,

	PRIMARY KEY(id)

	);

CREATE TABLE CHINSELL.COMPRADOR (
	id_comprador int NOT NULL,

	PRIMARY KEY(id_comprador),
	FOREIGN KEY(id_comprador) REFERENCES CHINSELL.UTILIZADOR(id)

	);

CREATE TABLE CHINSELL.VENDEDOR (
	id_vendedor	int NOT NULL,

	FOREIGN KEY(id_vendedor) REFERENCES CHINSELL.UTILIZADOR(id),
	PRIMARY KEY(id_vendedor)
	);

CREATE TABLE CHINSELL.COMPRA (
	id				int NOT NULL,
	metodopagamento	varchar(30),
	morada			varchar(20),
	empresaenvio	varchar(15)
	);

CREATE TABLE CHINSELL.CATEGORIA (
	categoria_id				int NOT NULL,
	Nome						varchar(20),						

	PRIMARY KEY(categoria_id)
	);

CREATE TABLE CHINSELL.SUBCATEGORIA (						
	subcategoria_id				int NOT NULL,
	Nome						varchar(20),
	categoria_id				int NOT NULL,

	PRIMARY KEY(subcategoria_id),
	FOREIGN KEY(categoria_id) REFERENCES CHINSELL.CATEGORIA(categoria_id)
	);


	CREATE TABLE CHINSELL.PRODUTO (
	produto_id				int NOT NULL,
	Preço			float,
	Marca			varchar(20),
	Título			varchar(50),
	--imagem			image,
	imagem_url			varchar(MAX),
	categoria_id	int NOT NULL,
	subcategoria_id	int NOT NULL,
	vendedor_id     int NOT NULL,

	PRIMARY KEY(produto_id),
	FOREIGN KEY(categoria_id) REFERENCES CHINSELL.CATEGORIA(categoria_id),
	FOREIGN KEY(subcategoria_id) REFERENCES CHINSELL.SUBCATEGORIA(subcategoria_id),
	FOREIGN KEY(vendedor_id) REFERENCES CHINSELL.VENDEDOR(id_vendedor)

	);

	DROP INDEX IF EXISTS CHINSELL.PRODUTO.idx_categoria_id;
	CREATE INDEX idx_categoria_id ON CHINSELL.PRODUTO(categoria_id);
