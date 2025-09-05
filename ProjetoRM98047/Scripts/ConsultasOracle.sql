-- Script SQL para verificar os dados no banco Oracle
-- Execute estes comandos no Oracle SQL Developer ou similar

-- Verificar tabelas criadas
SELECT table_name FROM user_tables WHERE table_name LIKE 'RM98047%';

-- Contar registros em cada tabela
SELECT 'RM98047_FORNECEDORES' as tabela, COUNT(*) as total_registros FROM "RM98047_Fornecedores"
UNION ALL
SELECT 'RM98047_PRODUTOS' as tabela, COUNT(*) as total_registros FROM "RM98047_Produtos"  
UNION ALL
SELECT 'RM98047_PEDIDOS' as tabela, COUNT(*) as total_registros FROM "RM98047_Pedidos";

-- Consultar todos os fornecedores
SELECT * FROM "RM98047_Fornecedores" ORDER BY "idFornecedor";

-- Consultar todos os produtos
SELECT * FROM "RM98047_Produtos" ORDER BY "idProduto";

-- Consultar todos os pedidos
SELECT * FROM "RM98047_Pedidos" ORDER BY "idPedido";

-- Consultas com formatação
SELECT 
    "idFornecedor" as ID,
    "Cidade" || ', ' || "Estado" as Localização,
    "nrCEP" as CEP
FROM "RM98047_Fornecedores" 
ORDER BY "Estado", "Cidade";

SELECT 
    "idProduto" as ID,
    "nmProduto" as Produto,
    TO_CHAR("preco", 'L999G999D99') as Preço
FROM "RM98047_Produtos" 
ORDER BY "preco" DESC;

SELECT 
    "idPedido" as ID,
    TO_CHAR("dataPedido", 'DD/MM/YYYY') as Data,
    TO_CHAR("valorTotal", 'L999G999D99') as "Valor Total"
FROM "RM98047_Pedidos" 
ORDER BY "dataPedido";
