using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classRooms",
                columns: table => new
                {
                    ClassRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeLevel = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classRooms", x => x.ClassRoomId);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    ClassRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_students_classRooms_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "classRooms",
                        principalColumn: "ClassRoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_teachers_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MaxGrade = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_subjects_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enrollments", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_enrollments_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_enrollments_subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "classRooms",
                columns: new[] { "ClassRoomId", "Capacity", "GradeLevel", "Name" },
                values: new object[,]
                {
                    { 1, 30, 10, "Software 1A" },
                    { 2, 25, 10, "Electronics 1A" }
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Software and programming department", "Computer Science" },
                    { 2, "Electronics and embedded systems department", "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "StudentId", "ClassRoomId", "DateOfBirth", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(2010, 5, 12), "ali@student.com", "Ali", "Mohamed", "01011111111" },
                    { 2, 1, new DateOnly(2010, 8, 20), "omar@student.com", "Omar", "Ahmed", "01022222222" },
                    { 3, 1, new DateOnly(2010, 3, 15), "youssef@student.com", "Youssef", "Hany", "01033333333" },
                    { 4, 2, new DateOnly(2010, 7, 10), "mariam@student.com", "Mariam", "Ali", "01044444444" },
                    { 5, 2, new DateOnly(2009, 12, 22), "salma@student.com", "Salma", "Mostafa", "01055555555" },
                    { 6, 2, new DateOnly(2010, 11, 5), "karim@student.com", "Karim", "Tarek", "01066666666" }
                });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "TeacherId", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "ahmed@school.com", "Ahmed", "Hassan", "01012345678", 15000m },
                    { 2, 1, "mona@school.com", "Mona", "Ali", "01123456789", 14000m },
                    { 3, 2, "omar@school.com", "Omar", "Mahmoud", "01234567890", 15500m }
                });

            migrationBuilder.InsertData(
                table: "subjects",
                columns: new[] { "SubjectId", "Description", "MaxGrade", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Programming fundamentals and OOP", 100, "C++ Programming", 1 },
                    { 2, "Database and SQL", 100, "Database Systems", 2 },
                    { 3, "Web development fundamentals", 100, "Web Development", 1 },
                    { 4, "Microcontrollers and embedded programming", 100, "Embedded Systems", 3 }
                });

            migrationBuilder.InsertData(
                table: "enrollments",
                columns: new[] { "EnrollmentId", "EnrollmentDate", "Grade", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90m, 1, 1 },
                    { 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85m, 1, 2 },
                    { 3, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78m, 2, 1 },
                    { 4, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88m, 2, 3 },
                    { 5, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95m, 3, 1 },
                    { 6, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 82m, 4, 4 },
                    { 7, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 91m, 5, 4 },
                    { 8, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 76m, 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_enrollments_StudentId_SubjectId",
                table: "enrollments",
                columns: new[] { "StudentId", "SubjectId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_enrollments_SubjectId",
                table: "enrollments",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_students_ClassRoomId",
                table: "students",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_students_Email",
                table: "students",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_subjects_TeacherId",
                table: "subjects",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_DepartmentId",
                table: "teachers",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enrollments");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "classRooms");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
