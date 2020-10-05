﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TaskAspNetApp.Migrations
{
	public partial class V9 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<DateTime>(
				name: "DateEnd",
				table: "StageContracts",
				type: "date",
				nullable: false,
				oldClrType: typeof(DateTime),
				oldType: "datetime(6)");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<DateTime>(
				name: "DateEnd",
				table: "StageContracts",
				type: "datetime(6)",
				nullable: false,
				oldClrType: typeof(DateTime),
				oldType: "date");
		}
	}
}
