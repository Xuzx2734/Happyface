using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "t_class",
            //    columns: table => new
            //    {
            //        classid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        pid_ = table.Column<int>(nullable: false),
            //        name_ = table.Column<string>(maxLength: 30, nullable: false),
            //        sort_ = table.Column<int>(nullable: false),
            //        idate_ = table.Column<DateTime>(nullable: false),
            //        udate_ = table.Column<DateTime>(nullable: false),
            //        delflag_ = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_class", x => x.classid_);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "t_groups",
            //    columns: table => new
            //    {
            //        groupid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        name_ = table.Column<string>(maxLength: 30, nullable: false),
            //        comment_ = table.Column<string>(maxLength: 100, nullable: true),
            //        idate_ = table.Column<DateTime>(nullable: false),
            //        udate_ = table.Column<DateTime>(nullable: false),
            //        delflag_ = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_groups", x => x.groupid_);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "t_project",
            //    columns: table => new
            //    {
            //        projectid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        name_ = table.Column<string>(maxLength: 20, nullable: false),
            //        state_ = table.Column<int>(nullable: false),
            //        userid_ = table.Column<int>(nullable: false),
            //        comment_ = table.Column<string>(maxLength: 100, nullable: true),
            //        idate_ = table.Column<DateTime>(nullable: false),
            //        udate_ = table.Column<DateTime>(nullable: false),
            //        delflag_ = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_project", x => x.projectid_);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "t_users",
            //    columns: table => new
            //    {
            //        userid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        code_ = table.Column<string>(maxLength: 20, nullable: false),
            //        pass_ = table.Column<string>(maxLength: 20, nullable: false),
            //        email_ = table.Column<string>(maxLength: 20, nullable: true),
            //        name_ = table.Column<string>(maxLength: 50, nullable: true),
            //        idate_ = table.Column<DateTime>(nullable: false),
            //        udate_ = table.Column<DateTime>(nullable: false),
            //        delflag_ = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_users", x => x.userid_);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "t_projectgroup",
            //    columns: table => new
            //    {
            //        projectgroupid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        projectid_ = table.Column<int>(nullable: false),
            //        groupid_ = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_projectgroup", x => x.projectgroupid_);
            //        table.ForeignKey(
            //            name: "FK_t_projectgroup_t_groups_groupid_",
            //            column: x => x.groupid_,
            //            principalTable: "t_groups",
            //            principalColumn: "groupid_",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_t_projectgroup_t_project_projectid_",
            //            column: x => x.projectid_,
            //            principalTable: "t_project",
            //            principalColumn: "projectid_",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "t_doc",
            //    columns: table => new
            //    {
            //        docid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        name_ = table.Column<int>(nullable: false),
            //        userid_ = table.Column<int>(nullable: false),
            //        class_ = table.Column<int>(nullable: false),
            //        title_ = table.Column<string>(maxLength: 100, nullable: false),
            //        type_ = table.Column<int>(nullable: false),
            //        content_ = table.Column<string>(nullable: true),
            //        function_ = table.Column<string>(maxLength: 10, nullable: false),
            //        delflag_ = table.Column<DateTime>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_doc", x => x.docid_);
            //        table.ForeignKey(
            //            name: "FK_t_doc_t_class_class_",
            //            column: x => x.class_,
            //            principalTable: "t_class",
            //            principalColumn: "classid_",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_t_doc_t_project_name_",
            //            column: x => x.name_,
            //            principalTable: "t_project",
            //            principalColumn: "projectid_",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_t_doc_t_users_userid_",
            //            column: x => x.userid_,
            //            principalTable: "t_users",
            //            principalColumn: "userid_",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "t_usergroup",
            //    columns: table => new
            //    {
            //        usergroupid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        userid_ = table.Column<int>(nullable: false),
            //        groupid_ = table.Column<int>(nullable: false),
            //        idate_ = table.Column<DateTime>(nullable: false),
            //        udate_ = table.Column<DateTime>(nullable: false),
            //        delflag_ = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_usergroup", x => x.usergroupid_);
            //        table.ForeignKey(
            //            name: "FK_t_usergroup_t_groups_groupid_",
            //            column: x => x.groupid_,
            //            principalTable: "t_groups",
            //            principalColumn: "groupid_",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_t_usergroup_t_users_userid_",
            //            column: x => x.userid_,
            //            principalTable: "t_users",
            //            principalColumn: "userid_",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "t_parameter",
            //    columns: table => new
            //    {
            //        parameterid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        docid_ = table.Column<int>(nullable: false),
            //        parameter_ = table.Column<string>(maxLength: 30, nullable: false),
            //        type_ = table.Column<int>(nullable: false),
            //        comment_ = table.Column<string>(maxLength: 100, nullable: true),
            //        idate_ = table.Column<DateTime>(nullable: false),
            //        udate_ = table.Column<DateTime>(nullable: false),
            //        delflag_ = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_parameter", x => x.parameterid_);
            //        table.ForeignKey(
            //            name: "FK_t_parameter_t_doc_docid_",
            //            column: x => x.docid_,
            //            principalTable: "t_doc",
            //            principalColumn: "docid_",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "t_values",
            //    columns: table => new
            //    {
            //        valuesid_ = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        docid_ = table.Column<int>(nullable: false),
            //        type_ = table.Column<int>(nullable: false),
            //        link_ = table.Column<int>(nullable: false),
            //        content_ = table.Column<string>(nullable: true),
            //        idate_ = table.Column<DateTime>(nullable: false),
            //        udate_ = table.Column<DateTime>(nullable: false),
            //        delflag_ = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_t_values", x => x.valuesid_);
            //        table.ForeignKey(
            //            name: "FK_t_values_t_doc_docid_",
            //            column: x => x.docid_,
            //            principalTable: "t_doc",
            //            principalColumn: "docid_",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_doc_class_",
            //    table: "t_doc",
            //    column: "class_");

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_doc_name_",
            //    table: "t_doc",
            //    column: "name_");

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_doc_userid_",
            //    table: "t_doc",
            //    column: "userid_");

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_parameter_docid_",
            //    table: "t_parameter",
            //    column: "docid_");

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_projectgroup_groupid_",
            //    table: "t_projectgroup",
            //    column: "groupid_");

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_projectgroup_projectid_",
            //    table: "t_projectgroup",
            //    column: "projectid_");

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_usergroup_groupid_",
            //    table: "t_usergroup",
            //    column: "groupid_");

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_usergroup_userid_",
            //    table: "t_usergroup",
            //    column: "userid_");

            //migrationBuilder.CreateIndex(
            //    name: "IX_t_values_docid_",
            //    table: "t_values",
            //    column: "docid_");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "t_parameter");

            //migrationBuilder.DropTable(
            //    name: "t_projectgroup");

            //migrationBuilder.DropTable(
            //    name: "t_usergroup");

            //migrationBuilder.DropTable(
            //    name: "t_values");

            //migrationBuilder.DropTable(
            //    name: "t_groups");

            //migrationBuilder.DropTable(
            //    name: "t_doc");

            //migrationBuilder.DropTable(
            //    name: "t_class");

            //migrationBuilder.DropTable(
            //    name: "t_project");

            //migrationBuilder.DropTable(
            //    name: "t_users");
        }
    }
}
