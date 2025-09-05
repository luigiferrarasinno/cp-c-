using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoRM98047.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RM98047_Fornecedores",
                columns: table => new
                {
                    idFornecedor = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nrCEP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dsEndereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM98047_Fornecedores", x => x.idFornecedor);
                });

            migrationBuilder.CreateTable(
                name: "RM98047_Pedidos",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    dataPedido = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    valorTotal = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM98047_Pedidos", x => x.idPedido);
                });

            migrationBuilder.CreateTable(
                name: "RM98047_Produtos",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nmProduto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    preco = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM98047_Produtos", x => x.idProduto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RM98047_Fornecedores");

            migrationBuilder.DropTable(
                name: "RM98047_Pedidos");

            migrationBuilder.DropTable(
                name: "RM98047_Produtos");
        }
    }
}
