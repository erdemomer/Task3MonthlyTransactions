using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task3.MT.DataAccess.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Icon",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
