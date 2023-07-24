using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.ByteBank.Dados.Migrations
{
    public partial class PopularBancoByteBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO `agencia` VALUES (null, 123, 'Agencia Central', 'Rua Pedro Alvares Cabral, 63', '48656740-8c54-4f04-a05f-1f43462bf7ee')");
			migrationBuilder.Sql("INSERT INTO `agencia` VALUES (null, 321, 'Agencia Flores', 'Rua Odete Roitman, 84', '58a737fd-2c54-48d7-998f-0c9de1f089bb')");

			migrationBuilder.Sql("INSERT INTO `cliente` VALUES (null, '315.992.020-85', 'André Silva', 'Developer', '3d9ea3c5-b521-498c-8584-77417ffa1063')");
			migrationBuilder.Sql("INSERT INTO `cliente` VALUES (null, '734.091.390-44', 'João Pedro', 'Developer', '759dc15b-eb62-4a03-ad88-f16277f77fe5')");
			migrationBuilder.Sql("INSERT INTO `cliente` VALUES (null, '728.704.860-49', 'José Neves', 'Atleta de Poker', '1046b625-f82a-4ba4-aa12-6425e858a787')");

			migrationBuilder.Sql("INSERT INTO `conta_corrente` VALUES (null, 4159, 1, 1, 300, 'be60572f-804c-47d3-994b-c9fc17cfb443', '00000000-0000-0000-0000-000000000000')");
			migrationBuilder.Sql("INSERT INTO `conta_corrente` VALUES (null, 1789, 2, 2, 400, '20eaba3d-b2be-4e6c-974f-b2b692a2d2ba', '00000000-0000-0000-0000-000000000000')");
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
