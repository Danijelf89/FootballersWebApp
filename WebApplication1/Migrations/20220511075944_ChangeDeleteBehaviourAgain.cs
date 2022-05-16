using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ChangeDeleteBehaviourAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
    //        migrationBuilder.DropForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer");

    //        migrationBuilder.AddForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer",
    //            column: "ClubId",
    //            principalTable: "Club",
    //            principalColumn: "Id",
    //            onDelete: ReferentialAction.SetNull);
       }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
    //        migrationBuilder.DropForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer");

    //        migrationBuilder.AddForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer",
    //            column: "ClubId",
    //            principalTable: "Club",
    //            principalColumn: "Id");
        }
    }
}
