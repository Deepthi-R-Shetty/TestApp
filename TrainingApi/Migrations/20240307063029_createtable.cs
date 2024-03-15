using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingApi.Migrations
{
    /// <inheritdoc />
    public partial class createtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "EmployeesDetails",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        project = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EmployeesDetails", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "students",
            //    columns: table => new
            //    {
            //        EmployeeId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_students", x => x.EmployeeId);
            //    });
            migrationBuilder.AddColumn<string>(
                name: "section",
                table: "students",
                nullable: true

                );

            //migrationBuilder.CreateTable(
            //    name: "employeeprojectdetail",
            //    columns: table => new
            //    {
            //        EmployeeId = table.Column<int>(type: "int", nullable: false),
            //        project = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        manager = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_employeeprojectdetail", x => x.EmployeeId);
            //        table.ForeignKey(
            //            name: "FK_employeeprojectdetail_EmployeesDetails_EmployeeId",
            //            column: x => x.EmployeeId,
            //            principalTable: "EmployeesDetails",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "employeeprojectdetail");

           // migrationBuilder.DropTable(
               // name: "students");

            //migrationBuilder.DropTable(
            //    name: "EmployeesDetails");
        }
    }
}
