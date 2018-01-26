using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPIdentityTest1.Data.Migrations
{
    public partial class Code4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecurityQuestion1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityQuestion2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityQuestion3",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecurityQuestion1",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityQuestion2",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityQuestion3",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
