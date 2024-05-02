using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Construccion.API.Migrations
{
    /// <inheritdoc />
    public partial class databsefinish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquiConss",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Especialidades = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Lista_Miembros = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquiConss", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectConstrs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Locate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectConstrs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentsTeamss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConstr = table.Column<int>(type: "int", nullable: false),
                    idTeams = table.Column<int>(type: "int", nullable: false),
                    ProjectConstrsid = table.Column<int>(type: "int", nullable: true),
                    EquiConssid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentsTeamss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignmentsTeamss_EquiConss_EquiConssid",
                        column: x => x.EquiConssid,
                        principalTable: "EquiConss",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_AssignmentsTeamss_ProjectConstrs_ProjectConstrsid",
                        column: x => x.ProjectConstrsid,
                        principalTable: "ProjectConstrs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Materialess",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectConstrId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materialess", x => x.id);
                    table.ForeignKey(
                        name: "FK_Materialess_ProjectConstrs_ProjectConstrId",
                        column: x => x.ProjectConstrId,
                        principalTable: "ProjectConstrs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presupuestos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManoObra = table.Column<double>(type: "float", nullable: false),
                    Material = table.Column<double>(type: "float", nullable: false),
                    Maquinaria = table.Column<double>(type: "float", nullable: false),
                    Otros = table.Column<double>(type: "float", nullable: false),
                    ProjectConstrId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presupuestos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Presupuestos_ProjectConstrs_ProjectConstrId",
                        column: x => x.ProjectConstrId,
                        principalTable: "ProjectConstrs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectConstrId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tareas_ProjectConstrs_ProjectConstrId",
                        column: x => x.ProjectConstrId,
                        principalTable: "ProjectConstrs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssigmentMatss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTasks = table.Column<int>(type: "int", nullable: false),
                    IdMats = table.Column<int>(type: "int", nullable: false),
                    TareasId = table.Column<int>(type: "int", nullable: true),
                    Materialessid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssigmentMatss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssigmentMatss_Materialess_Materialessid",
                        column: x => x.Materialessid,
                        principalTable: "Materialess",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_AssigmentMatss_Tareas_TareasId",
                        column: x => x.TareasId,
                        principalTable: "Tareas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Machineries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantReque = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Proveed = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaEntrga = table.Column<DateOnly>(type: "date", nullable: false),
                    tareasId = table.Column<int>(type: "int", nullable: true),
                    ProjectTareas = table.Column<int>(type: "int", nullable: false),
                    ProjectConstrId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machineries", x => x.id);
                    table.ForeignKey(
                        name: "FK_Machineries_ProjectConstrs_ProjectConstrId",
                        column: x => x.ProjectConstrId,
                        principalTable: "ProjectConstrs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Machineries_Tareas_tareasId",
                        column: x => x.tareasId,
                        principalTable: "Tareas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssigmentMatss_Materialessid",
                table: "AssigmentMatss",
                column: "Materialessid");

            migrationBuilder.CreateIndex(
                name: "IX_AssigmentMatss_TareasId",
                table: "AssigmentMatss",
                column: "TareasId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentsTeamss_EquiConssid",
                table: "AssignmentsTeamss",
                column: "EquiConssid");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentsTeamss_ProjectConstrsid",
                table: "AssignmentsTeamss",
                column: "ProjectConstrsid");

            migrationBuilder.CreateIndex(
                name: "IX_Machineries_ProjectConstrId",
                table: "Machineries",
                column: "ProjectConstrId");

            migrationBuilder.CreateIndex(
                name: "IX_Machineries_tareasId",
                table: "Machineries",
                column: "tareasId");

            migrationBuilder.CreateIndex(
                name: "IX_Materialess_ProjectConstrId",
                table: "Materialess",
                column: "ProjectConstrId");

            migrationBuilder.CreateIndex(
                name: "IX_Presupuestos_ProjectConstrId",
                table: "Presupuestos",
                column: "ProjectConstrId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectConstrs_id",
                table: "ProjectConstrs",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_ProjectConstrId",
                table: "Tareas",
                column: "ProjectConstrId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssigmentMatss");

            migrationBuilder.DropTable(
                name: "AssignmentsTeamss");

            migrationBuilder.DropTable(
                name: "Machineries");

            migrationBuilder.DropTable(
                name: "Presupuestos");

            migrationBuilder.DropTable(
                name: "Materialess");

            migrationBuilder.DropTable(
                name: "EquiConss");

            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "ProjectConstrs");
        }
    }
}
