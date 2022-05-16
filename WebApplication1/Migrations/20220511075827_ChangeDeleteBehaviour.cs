using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ChangeDeleteBehaviour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
    //        migrationBuilder.DropForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer");

    //        migrationBuilder.AlterColumn<int>(
    //            name: "ClubId",
    //            table: "Footballer",
    //            nullable: false,
    //            oldClrType: typeof(int),
    //            oldType: "int",
    //            oldNullable: true);

    //        migrationBuilder.AlterColumn<int>(
    //            name: "Id",
    //            table: "Club",
    //            nullable: false,
    //            oldClrType: typeof(int),
    //            oldType: "int")
    //            .OldAnnotation("SqlServer:Identity", "1, 1");

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
    //            name: "ClubId",
    //            table: "Footballer",
    //            type: "int",
    //            nullable: true,
    //            oldClrType: typeof(int));

    //        migrationBuilder.AlterColumn<int>(
    //            name: "Id",
    //            table: "Club",
    //            type: "int",
    //            nullable: false,
    //            oldClrType: typeof(int))
    //            .Annotation("SqlServer:Identity", "1, 1");

    //        migrationBuilder.AddForeignKey(
    //            name: "FK_Footballer_Club_ClubId",
    //            table: "Footballer",
    //            column: "ClubId",
    //            principalTable: "Club",
    //            principalColumn: "Id",
    //            onDelete: ReferentialAction.Restrict);
        }
    }
}
