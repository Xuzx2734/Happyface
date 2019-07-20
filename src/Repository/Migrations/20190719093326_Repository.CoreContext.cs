using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class RepositoryCoreContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "core_tb_user",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 36, nullable: true),
                    UserAccount = table.Column<string>(maxLength: 36, nullable: true),
                    Gender = table.Column<string>(maxLength: 4, nullable: true),
                    Mail = table.Column<string>(maxLength: 256, nullable: true),
                    Password = table.Column<string>(maxLength: 128, nullable: true),
                    OrgId = table.Column<Guid>(nullable: false),
                    OrgName = table.Column<string>(maxLength: 128, nullable: true),
                    CompanyId = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 128, nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    EmplyeeType = table.Column<int>(nullable: false),
                    DelFlag = table.Column<int>(nullable: false),
                    IsVaild = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    PassStandard = table.Column<string>(maxLength: 512, nullable: true),
                    LoginNum = table.Column<int>(nullable: false),
                    LastDate = table.Column<DateTime>(nullable: true),
                    CreateUser = table.Column<Guid>(nullable: true),
                    Code = table.Column<string>(maxLength: 36, nullable: true),
                    ShowType = table.Column<int>(nullable: true),
                    OaId = table.Column<string>(maxLength: 128, nullable: true),
                    OfficePhone = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core_tb_user", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "core_tb_user");
        }
    }
}
