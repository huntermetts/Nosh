using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nosh.Migrations
{
    public partial class fifth_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    isVendor = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SnackType",
                columns: table => new
                {
                    SnackTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    snackTypeName = table.Column<string>(nullable: true),
                    imageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnackType", x => x.SnackTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VendingMachine",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vendingMachineName = table.Column<string>(maxLength: 50, nullable: false),
                    vendingMachineLocation = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendingMachine", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Snack",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    snackName = table.Column<string>(maxLength: 50, nullable: false),
                    snackPrice = table.Column<double>(nullable: false),
                    snackCalories = table.Column<int>(maxLength: 4, nullable: false),
                    vendingMachineId = table.Column<int>(nullable: false),
                    snackTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snack", x => x.id);
                    table.ForeignKey(
                        name: "FK_Snack_SnackType_snackTypeId",
                        column: x => x.snackTypeId,
                        principalTable: "SnackType",
                        principalColumn: "SnackTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSnack",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userId = table.Column<int>(nullable: false),
                    userId1 = table.Column<string>(nullable: true),
                    snackId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSnack", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserSnack_Snack_snackId",
                        column: x => x.snackId,
                        principalTable: "Snack",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSnack_AspNetUsers_userId1",
                        column: x => x.userId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendingMachineSnack",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    snackId = table.Column<int>(nullable: false),
                    vendingMachineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendingMachineSnack", x => x.id);
                    table.ForeignKey(
                        name: "FK_VendingMachineSnack_Snack_snackId",
                        column: x => x.snackId,
                        principalTable: "Snack",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendingMachineSnack_VendingMachine_vendingMachineId",
                        column: x => x.vendingMachineId,
                        principalTable: "VendingMachine",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "firstName", "isVendor", "lastName" },
                values: new object[,]
                {
                    { "a8a940e5-5dcf-42dc-b68a-485f6b914841", 0, "93020749-2386-4988-a763-8f722abbf8dd", "User", "hmetts@gmail.com", true, false, null, "HMETTS@GMAIL.COM", "HMETTS@GMAIL.COM", "AQAAAAEAACcQAAAAEEU/0MYJMWTLzpF4gqEOGJLjzXPdbI6mIjSwA8onRorwmviMYlgnWJA957htyDL+cQ==", null, false, "99c36618-257e-4055-917b-b47bb1ca3cc9", false, "hmetts@gmail.com", "Hunter", false, "Metts" },
                    { "ee2d76f0-9beb-48c8-a54a-40fc06098c4a", 0, "161c752b-9b72-4c97-8e85-7a9d8f4e37c9", "User", "jrosas@gmail.com", true, false, null, "JROSAS@GMAIL.COM", "JROSAS@GMAIL.COM", "AQAAAAEAACcQAAAAEBZf0k+3IhPxcVO4JIVksRCSMH1ENPmBBbEWRYNYdyTacmbKbn8Q2qUYMw3amNIKvA==", null, false, "f5d00216-ff0c-43be-9353-9252fe64a3d1", false, "jrosas@gmail.com", "Jordan", false, "Rosas" },
                    { "4c95101a-02f4-4789-a018-4bef0d02c376", 0, "1107393d-3bbc-45ec-9c30-1f04f30de3fa", "User", "acarter@gmail.com", true, false, null, "ACARTER@GMAIL.COM", "ACARTER@GMAIL.COM", "AQAAAAEAACcQAAAAEFitclZes1d9/8OTmIsN+3+ktJA08S0SMbuDFF+SSEQbT9etL4fk7LUjkhK8Fbfn9A==", null, false, "226766a3-4e64-44a0-8118-94edd76b08ce", false, "acarter@gmail.com", "Asia", false, "Carter" },
                    { "742d3388-1d67-429c-82ac-e90d30646d9f", 0, "d9ce4cb0-427c-454d-8ea6-30c5d86d1869", "User", "sbrader@gmail.com", true, false, null, "SBRADER@GMAIL.COM", "SBRADER@GMAIL.COM", "AQAAAAEAACcQAAAAECKvtyh+8aPoOY39mcZMwftc4MxA/veapLmVvvSGicWIcTFGvPS6hDRDnmykiTaDog==", null, false, "95afeab1-dc2c-4aba-a43f-a7946296335e", false, "sbrader@gmail.com", "Steven", true, "Brader" }
                });

            migrationBuilder.InsertData(
                table: "SnackType",
                columns: new[] { "SnackTypeId", "imageURL", "snackTypeName" },
                values: new object[,]
                {
                    { 1, "~/images/milk-bottle.png", "Drink" },
                    { 2, "~/images/snack.png", "Chip" },
                    { 3, "~/images/chocolate-bar.png", "Candy" }
                });

            migrationBuilder.InsertData(
                table: "VendingMachine",
                columns: new[] { "id", "vendingMachineLocation", "vendingMachineName" },
                values: new object[,]
                {
                    { 2, "Closest to the coffee pot", "Loud and Cold" },
                    { 1, "Across from the microwaves", "The Mothership" }
                });

            migrationBuilder.InsertData(
                table: "Snack",
                columns: new[] { "id", "snackCalories", "snackName", "snackPrice", "snackTypeId", "vendingMachineId" },
                values: new object[,]
                {
                    { 2, 140, "Coke", 1.0, 1, 1 },
                    { 4, 240, "Iced Coffee", 3.0, 1, 1 },
                    { 7, 150, "Dr. Pepper", 1.0, 1, 1 },
                    { 9, 168, "Red Bull", 2.5, 1, 2 },
                    { 3, 160, "Lays Original", 0.75, 2, 1 },
                    { 5, 160, "Lays BBQ", 0.75, 2, 1 },
                    { 8, 150, "Doritos Salsa Verde", 1.0, 2, 1 },
                    { 1, 210, "REECE's Peanut Butter Cups", 1.0, 3, 1 },
                    { 6, 215, "Snickers", 1.0, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserSnack",
                columns: new[] { "id", "snackId", "userId", "userId1" },
                values: new object[,]
                {
                    { 2, 7, 1, null },
                    { 5, 7, 3, null },
                    { 3, 9, 2, null },
                    { 1, 8, 1, null },
                    { 4, 1, 3, null }
                });

            migrationBuilder.InsertData(
                table: "VendingMachineSnack",
                columns: new[] { "id", "snackId", "vendingMachineId" },
                values: new object[,]
                {
                    { 2, 2, 1 },
                    { 4, 4, 1 },
                    { 7, 7, 1 },
                    { 9, 9, 2 },
                    { 3, 3, 1 },
                    { 5, 5, 1 },
                    { 8, 8, 1 },
                    { 1, 1, 1 },
                    { 6, 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Snack_snackTypeId",
                table: "Snack",
                column: "snackTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSnack_snackId",
                table: "UserSnack",
                column: "snackId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSnack_userId1",
                table: "UserSnack",
                column: "userId1");

            migrationBuilder.CreateIndex(
                name: "IX_VendingMachineSnack_snackId",
                table: "VendingMachineSnack",
                column: "snackId");

            migrationBuilder.CreateIndex(
                name: "IX_VendingMachineSnack_vendingMachineId",
                table: "VendingMachineSnack",
                column: "vendingMachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserSnack");

            migrationBuilder.DropTable(
                name: "VendingMachineSnack");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Snack");

            migrationBuilder.DropTable(
                name: "VendingMachine");

            migrationBuilder.DropTable(
                name: "SnackType");
        }
    }
}
