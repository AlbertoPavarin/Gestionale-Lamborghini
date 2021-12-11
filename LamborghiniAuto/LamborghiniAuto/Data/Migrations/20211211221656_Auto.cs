﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace LamborghiniAuto.Data.Migrations
{
    public partial class Auto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modello = table.Column<string>(nullable: true),
                    prezzo = table.Column<double>(nullable: false),
                    info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");
        }
    }
}
