
insert CHINSELL.UTILIZADOR values(896, '987654321', 'sebas@outlook.com', 'pass2')
insert CHINSELL.UTILIZADOR values(321, '926586558', 'ruizao@live.com.pt', 'pass3')
insert CHINSELL.UTILIZADOR values(698, '945675565', 'betaogamer@gmail.com', 'betao123456')
insert CHINSELL.UTILIZADOR values(759, '987654321', 'sebascon@outlook.com', 'pass5')
insert CHINSELL.UTILIZADOR values(345, '926586558', 'ruizaojoga@live.com.pt', 'pass6')
insert CHINSELL.UTILIZADOR values(111, '123456789', 'admin', 'admin')

select * from CHINSELL.UTILIZADOR

GO

insert CHINSELL.COMPRADOR values(896)
insert CHINSELL.COMPRADOR values(321)
insert CHINSELL.COMPRADOR values(759)
insert CHINSELL.COMPRADOR values(345)
insert CHINSELL.COMPRADOR values(111)
insert CHINSELL.COMPRADOR values(698)

select * from CHINSELL.COMPRADOR

GO

-- id de user vai de 100 até 999
insert CHINSELL.VENDEDOR values(896)
insert CHINSELL.VENDEDOR values(321)
insert CHINSELL.VENDEDOR values(759)
insert CHINSELL.VENDEDOR values(345)
insert CHINSELL.VENDEDOR values(111)
insert CHINSELL.VENDEDOR values(698)

select * from CHINSELL.VENDEDOR

GO

insert CHINSELL.COMPRA values(1, 'Cartão de crédito', 'Rua A, nº 3A', 'Correos Express')
insert CHINSELL.COMPRA values(2, 'Paypal', 'Rua B, nº 58', 'Correio Normal')
insert CHINSELL.COMPRA values(3, 'MB WAY', 'Rua C, nº 72', 'FedEx')


select * from CHINSELL.COMPRA

GO

-- categoria id 1 até 99
insert CHINSELL.CATEGORIA values(1, 'Homem')
insert CHINSELL.CATEGORIA values(2, 'Mulher')
insert CHINSELL.CATEGORIA values(3, 'Criança')
insert CHINSELL.CATEGORIA values(4, 'Outros')

select * from CHINSELL.CATEGORIA

GO
-- subcategoria id 1000 até 99999
insert CHINSELL.SUBCATEGORIA values(12565, 'Roupa Mulher', 2)
insert CHINSELL.SUBCATEGORIA values(36894, 'Calçado Mulher', 2)
insert CHINSELL.SUBCATEGORIA values(13335, 'acessórios Mulher', 2)

insert CHINSELL.SUBCATEGORIA values(13565, 'Roupa Homem', 1)
insert CHINSELL.SUBCATEGORIA values(66794, 'Calçado Homem', 1)
insert CHINSELL.SUBCATEGORIA values(22345, 'acessórios Homem', 1)

insert CHINSELL.SUBCATEGORIA values(42344, 'Brinquedos', 3)
insert CHINSELL.SUBCATEGORIA values(89565, 'Roupa Criança', 3)
insert CHINSELL.SUBCATEGORIA values(67794, 'Calçado Criança', 3)
insert CHINSELL.SUBCATEGORIA values(90345, 'acessórios Criança', 3)

insert CHINSELL.SUBCATEGORIA values(52344, 'Objetos', 3)
insert CHINSELL.SUBCATEGORIA values(59565, 'Casa', 3)
insert CHINSELL.SUBCATEGORIA values(57794, 'Carros', 3)
insert CHINSELL.SUBCATEGORIA values(50345, 'Outros', 3)

select * from CHINSELL.SUBCATEGORIA

GO

--produto id 100000 até 999999
--insert CHINSELL.PRODUTO values(produto_id, Preço, Marca, Título, imagem_url,categoria_id, subcategoria_id, vendedor_id)
insert CHINSELL.PRODUTO values(203457, 45.89, 'Nkie', 'Chinelos','C:\Users\ASUS\OneDrive - Universidade de Aveiro\Desktop\PECI\amelia.jpg', 1, 66794, 111)
insert CHINSELL.PRODUTO values(164548, 12, 'Panda', 'Mala Panda','C:\Users\ASUS\OneDrive - Universidade de Aveiro\Desktop\PECI\jose.png', 2, 13335,111)
insert CHINSELL.PRODUTO values(165555, 299.99, 'Luís Vitãon', 'Mala de mão e, boas condições', 'C:\Users\ASUS\OneDrive - Universidade de Aveiro\Desktop\PECI\joao.png', 2, 13335, 111)
insert CHINSELL.PRODUTO values(165553, 30, 'Lego', 'Lego star wars 501st battlepack', 'C:\Users\ASUS\OneDrive - Universidade de Aveiro\Desktop\PECI\menu.jpg', 3, 42344, 698)
--insert CHINSELL.PRODUTO values(203457, 45.89, 'Nkie', 'Chinelos','C:\Users\sebas\Documents\GitHub\BD\ChinSell\imagens\chinelos_nike.jpg', 1, 66794, 111)
--insert CHINSELL.PRODUTO values(164548, 12, 'Panda', 'Mala Panda','C:\Users\sebas\Documents\GitHub\BD\ChinSell\imagens\panda.jpg', 2, 13335,111)
--insert CHINSELL.PRODUTO values(165555, 299.99, 'Louis Vuitton', 'Mala de mão e, boas condições', 'C:\Users\sebas\Documents\GitHub\BD\ChinSell\imagens\louis_vitton.jpg', 2, 13335, 111)
--insert CHINSELL.PRODUTO values(165553, 30, 'Lego', 'Lego star wars 501st battlepack', 'C:\Users\sebas\Documents\GitHub\BD\ChinSell\imagens\501st.jpeg', 3, 42344, 698)
--insert CHINSELL.PRODUTO values(165552, 20, 'Lego', 'Mandalorian Battlepack', 'C:\Users\sebas\Documents\GitHub\BD\ChinSell\imagens\mando.jpeg', 3, 42344, 698)
--insert CHINSELL.PRODUTO values(165550, 9.99, 'Lego', 'LEGO NARUTÃO', 'C:\Users\sebas\Documents\GitHub\BD\ChinSell\imagens\naruto_lego.jpeg', 3, 42344, 111)
--insert CHINSELL.PRODUTO values(164558, 3.99, 'Adibas', 'sweat','C:\Users\sebas\Documents\GitHub\BD\ChinSell\imagens\abidas.jpg', 1, 13565, 111)

select * from CHINSELL.PRODUTO

GO