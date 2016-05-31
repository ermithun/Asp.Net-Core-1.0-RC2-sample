using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using mvccorerc2.Models;

namespace mvccorerc2.Migrations
{
    public partial class usermanagerupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IsApproved",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: RowStatus.New);

            migrationBuilder.AddColumn<int>(
                name: "ModuleID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "TranNo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModuleID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TranNo",
                table: "AspNetUsers");
        }
    }
}
