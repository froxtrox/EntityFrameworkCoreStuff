using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyHomeWebsite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workExperiences",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Responsibility = table.Column<string>(nullable: true),
                    SkillGained = table.Column<string>(nullable: true),
                    experience = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workExperiences", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "workExperiences");
        }
    }
}
