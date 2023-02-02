using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmBillingWebAPI.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClaimTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Navigation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    ParentNavigationId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navigation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Navigation_Navigation_ParentNavigationId",
                        column: x => x.ParentNavigationId,
                        principalTable: "Navigation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Navigation_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ReferenceTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                    table.ForeignKey(
                        name: "FK_References_ReferenceTypes_ReferenceTypeId",
                        column: x => x.ReferenceTypeId,
                        principalTable: "ReferenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceTypeCorrelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentReferenceId = table.Column<int>(type: "int", nullable: true),
                    ChildReferenceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceTypeCorrelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferenceTypeCorrelations_ReferenceTypes_ChildReferenceId",
                        column: x => x.ChildReferenceId,
                        principalTable: "ReferenceTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReferenceTypeCorrelations_ReferenceTypes_ParentReferenceId",
                        column: x => x.ParentReferenceId,
                        principalTable: "ReferenceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaimTypeId = table.Column<int>(type: "int", nullable: false),
                    AccessAttributeTypeId = table.Column<int>(type: "int", nullable: false),
                    AccesstypeLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_ClaimTypes_ClaimTypeId",
                        column: x => x.ClaimTypeId,
                        principalTable: "ClaimTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rules_ReferenceTypes_AccessAttributeTypeId",
                        column: x => x.AccessAttributeTypeId,
                        principalTable: "ReferenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceCorrelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentReferenceId = table.Column<int>(type: "int", nullable: true),
                    ChildReferenceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceCorrelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferenceCorrelations_References_ChildReferenceId",
                        column: x => x.ChildReferenceId,
                        principalTable: "References",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReferenceCorrelations_References_ParentReferenceId",
                        column: x => x.ParentReferenceId,
                        principalTable: "References",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoleAccess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    AccessAttributeId = table.Column<int>(type: "int", nullable: false),
                    AccessTypelevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoleAccess_References_AccessAttributeId",
                        column: x => x.AccessAttributeId,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleAccess_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleAccess_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    RuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyRules_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicyRules_Rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Navigation_ParentNavigationId",
                table: "Navigation",
                column: "ParentNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Navigation_PolicyId",
                table: "Navigation",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyRules_PolicyId",
                table: "PolicyRules",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyRules_RuleId",
                table: "PolicyRules",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceCorrelations_ChildReferenceId",
                table: "ReferenceCorrelations",
                column: "ChildReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceCorrelations_ParentReferenceId",
                table: "ReferenceCorrelations",
                column: "ParentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_References_ReferenceTypeId",
                table: "References",
                column: "ReferenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceTypeCorrelations_ChildReferenceId",
                table: "ReferenceTypeCorrelations",
                column: "ChildReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceTypeCorrelations_ParentReferenceId",
                table: "ReferenceTypeCorrelations",
                column: "ParentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_AccessAttributeTypeId",
                table: "Rules",
                column: "AccessAttributeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_ClaimTypeId",
                table: "Rules",
                column: "ClaimTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleAccess_AccessAttributeId",
                table: "UserRoleAccess",
                column: "AccessAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleAccess_RoleId",
                table: "UserRoleAccess",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleAccess_UserId",
                table: "UserRoleAccess",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Navigation");

            migrationBuilder.DropTable(
                name: "PolicyRules");

            migrationBuilder.DropTable(
                name: "ReferenceCorrelations");

            migrationBuilder.DropTable(
                name: "ReferenceTypeCorrelations");

            migrationBuilder.DropTable(
                name: "UserRoleAccess");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ClaimTypes");

            migrationBuilder.DropTable(
                name: "ReferenceTypes");
        }
    }
}
