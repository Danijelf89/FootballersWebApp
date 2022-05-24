using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class CreatedAtAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Footballer_Club_ClubId",
                table: "Footballer");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Footballer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Club",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Footballer_Club_ClubId",
                table: "Footballer",
                column: "ClubId",
                principalTable: "Club",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Footballer_Club_ClubId",
                table: "Footballer");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Footballer");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Club");

            migrationBuilder.AddForeignKey(
                name: "FK_Footballer_Club_ClubId",
                table: "Footballer",
                column: "ClubId",
                principalTable: "Club",
                principalColumn: "Id");
        }
    }
}
