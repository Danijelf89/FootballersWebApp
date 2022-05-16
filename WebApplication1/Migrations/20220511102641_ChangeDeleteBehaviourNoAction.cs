using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ChangeDeleteBehaviourNoAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
    //        migrationBuilder.DropForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer");

    //        migrationBuilder.AlterColumn<int>(
    //            name: "Id",
    //            table: "Club",
    //            nullable: false,
    //            oldClrType: typeof(int),
    //            oldType: "int")
    //            .Annotation("SqlServer:Identity", "1, 1");

    //        migrationBuilder.AddForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer",
    //            column: "ClubId",
    //            principalTable: "Club",
    //            principalColumn: "Id");
       }

        protected override void Down(MigrationBuilder migrationBuilder)
       {
    //        migrationBuilder.DropForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer");

    //        migrationBuilder.AlterColumn<int>(
    //            name: "Id",
    //            table: "Club",
    //            type: "int",
    //            nullable: false,
    //            oldClrType: typeof(int))
    //            .OldAnnotation("SqlServer:Identity", "1, 1");

    //        migrationBuilder.AddForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer",
    //            column: "ClubId",
    //            principalTable: "Club",
    //            principalColumn: "Id",
    //            onDelete: ReferentialAction.NoAction);
        }
    }
}
