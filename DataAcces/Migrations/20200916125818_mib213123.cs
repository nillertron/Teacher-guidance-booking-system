using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class mib213123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Persons_StudentId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_StoredCookies_Persons_PersonId",
                table: "StoredCookies");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslots_Calenders_CalendarId",
                table: "Timeslots");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslots_Persons_TeacherId",
                table: "Timeslots");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Timeslots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.DropColumn("RowVersion", "Timeslots");

            migrationBuilder.AlterColumn<int>(
                name: "CalendarId",
                table: "Timeslots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "StoredCookies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Persons_StudentId",
                table: "Bookings",
                column: "StudentId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoredCookies_Persons_PersonId",
                table: "StoredCookies",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslots_Calenders_CalendarId",
                table: "Timeslots",
                column: "CalendarId",
                principalTable: "Calenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslots_Persons_TeacherId",
                table: "Timeslots",
                column: "TeacherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Persons_StudentId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_StoredCookies_Persons_PersonId",
                table: "StoredCookies");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslots_Calenders_CalendarId",
                table: "Timeslots");

            migrationBuilder.DropForeignKey(
                name: "FK_Timeslots_Persons_TeacherId",
                table: "Timeslots");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Timeslots",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Timeslots",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CalendarId",
                table: "Timeslots",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "StoredCookies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Persons_StudentId",
                table: "Bookings",
                column: "StudentId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StoredCookies_Persons_PersonId",
                table: "StoredCookies",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslots_Calenders_CalendarId",
                table: "Timeslots",
                column: "CalendarId",
                principalTable: "Calenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Timeslots_Persons_TeacherId",
                table: "Timeslots",
                column: "TeacherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
