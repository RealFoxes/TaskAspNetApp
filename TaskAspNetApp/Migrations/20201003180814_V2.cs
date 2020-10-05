using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAspNetApp.Migrations
{
	public partial class V2 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<int>(
				name: "contractId",
				table: "StageContracts",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.CreateIndex(
				name: "IX_StageContracts_contractId",
				table: "StageContracts",
				column: "contractId");

			migrationBuilder.AddForeignKey(
				name: "FK_StageContracts_Contracts_contractId",
				table: "StageContracts",
				column: "contractId",
				principalTable: "Contracts",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_StageContracts_Contracts_contractId",
				table: "StageContracts");

			migrationBuilder.DropIndex(
				name: "IX_StageContracts_contractId",
				table: "StageContracts");

			migrationBuilder.DropColumn(
				name: "contractId",
				table: "StageContracts");
		}
	}
}
