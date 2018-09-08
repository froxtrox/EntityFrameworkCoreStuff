using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyHomeWebsite.Migrations
{
    public partial class SecondIntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "timePeriodID",
                table: "workExperiences",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TimePeriod",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimePeriod", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_workExperiences_timePeriodID",
                table: "workExperiences",
                column: "timePeriodID");

            migrationBuilder.AddForeignKey(
                name: "FK_workExperiences_TimePeriod_timePeriodID",
                table: "workExperiences",
                column: "timePeriodID",
                principalTable: "TimePeriod",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_workExperiences_TimePeriod_timePeriodID",
                table: "workExperiences");

            migrationBuilder.DropTable(
                name: "TimePeriod");

            migrationBuilder.DropIndex(
                name: "IX_workExperiences_timePeriodID",
                table: "workExperiences");

            migrationBuilder.DropColumn(
                name: "timePeriodID",
                table: "workExperiences");
        }
    }
}
