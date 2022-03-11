using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle.Data.Migrations
{
    public partial class DeleteEnumsAndAddTableWithFaceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FaceType",
                table: "Cars",
                newName: "FaceTypeId");

            migrationBuilder.CreateTable(
                name: "Faces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faces", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FaceTypeId",
                table: "Cars",
                column: "FaceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Faces_FaceTypeId",
                table: "Cars",
                column: "FaceTypeId",
                principalTable: "Faces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Faces_FaceTypeId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Faces");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FaceTypeId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "FaceTypeId",
                table: "Cars",
                newName: "FaceType");
        }
    }
}
