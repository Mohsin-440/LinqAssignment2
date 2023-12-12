using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linq_Assignment_2.Migrations
{
    /// <inheritdoc />
    public partial class UPdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Faculties_FacultyFid",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Classes_ClassCid",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentSid",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_ClassCid",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentSid",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Classes_FacultyFid",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassCid",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "StudentSid",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "FacultyFid",
                table: "Classes");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_Cid",
                table: "Enrollments",
                column: "Cid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_Sid",
                table: "Enrollments",
                column: "Sid");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Fid",
                table: "Classes",
                column: "Fid");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Faculties_Fid",
                table: "Classes",
                column: "Fid",
                principalTable: "Faculties",
                principalColumn: "Fid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Classes_Cid",
                table: "Enrollments",
                column: "Cid",
                principalTable: "Classes",
                principalColumn: "Cid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_Sid",
                table: "Enrollments",
                column: "Sid",
                principalTable: "Students",
                principalColumn: "Sid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Faculties_Fid",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Classes_Cid",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_Sid",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_Cid",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_Sid",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Classes_Fid",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ClassCid",
                table: "Enrollments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentSid",
                table: "Enrollments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacultyFid",
                table: "Classes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ClassCid",
                table: "Enrollments",
                column: "ClassCid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentSid",
                table: "Enrollments",
                column: "StudentSid");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_FacultyFid",
                table: "Classes",
                column: "FacultyFid");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Faculties_FacultyFid",
                table: "Classes",
                column: "FacultyFid",
                principalTable: "Faculties",
                principalColumn: "Fid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Classes_ClassCid",
                table: "Enrollments",
                column: "ClassCid",
                principalTable: "Classes",
                principalColumn: "Cid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentSid",
                table: "Enrollments",
                column: "StudentSid",
                principalTable: "Students",
                principalColumn: "Sid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
