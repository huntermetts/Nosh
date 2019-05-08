using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nosh.Migrations
{
    public partial class NoshMigration : Migration
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
                        name: "FK_UserSnack_AspNetUsers_userId1",
                        column: x => x.userId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SnackType",
                columns: table => new
                {
                    SnackTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    snackTypeName = table.Column<string>(nullable: true),
                    imageURL = table.Column<string>(nullable: true),
                    Snackid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnackType", x => x.SnackTypeId);
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
                    SnackTypeId = table.Column<int>(nullable: false),
                    vendingMachineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snack", x => x.id);
                    table.ForeignKey(
                        name: "FK_Snack_SnackType_SnackTypeId",
                        column: x => x.SnackTypeId,
                        principalTable: "SnackType",
                        principalColumn: "SnackTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Snack_VendingMachine_vendingMachineId",
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
                    { "44450521-c8ba-4a08-9700-0bb092c54d3f", 0, "c26790b9-c258-4551-a57d-e08908476922", "User", "hmetts@gmail.com", true, false, null, "HMETTS@GMAIL.COM", "HMETTS@GMAIL.COM", "AQAAAAEAACcQAAAAEFYTc1UX6b2tPXKrJfWf6Ra5LRCXizf8FPhVV7Lt/U6xU3fEPrLbfGnAmUsfTrdw9w==", null, false, "01f36f76-b5fe-4103-a319-a4b6adf0b2b5", false, "hmetts@gmail.com", "Hunter", false, "Metts" },
                    { "e17cdf4b-25c2-4a3f-8254-7f7227c8c317", 0, "fa251e76-16a7-466b-a489-ab7510bccb58", "User", "jrosas@gmail.com", true, false, null, "JROSAS@GMAIL.COM", "JROSAS@GMAIL.COM", "AQAAAAEAACcQAAAAEGPBqeybWfdCxHZJWGlb09X1ZF9+VzQvGp66QmebOAlrUw+JilOjn6DRFbKNvm/CeA==", null, false, "b54cea3f-8604-43f5-9809-3dc6c69a990f", false, "jrosas@gmail.com", "Jordan", false, "Rosas" },
                    { "95a0e8fa-cd84-4f0b-9f2d-b02d16763df4", 0, "ffba7256-3ac9-4172-9bec-41b32da15c20", "User", "acarter@gmail.com", true, false, null, "ACARTER@GMAIL.COM", "ACARTER@GMAIL.COM", "AQAAAAEAACcQAAAAEKSZGdrcHytPKudzZbnYg03KtLTVcbUdxcuYmXySfx7YAoOsjsiXm0Zwve1bSwK+Fw==", null, false, "4e74e2af-3d6b-4364-8210-1ae7c7bdad32", false, "acarter@gmail.com", "Asia", false, "Carter" },
                    { "c825360f-b2ae-4aee-8ec4-22a48e2bee9c", 0, "d0b5b8d1-7c0d-4cac-bf8b-b8bb8fc47a21", "User", "sbrader@gmail.com", true, false, null, "SBRADER@GMAIL.COM", "SBRADER@GMAIL.COM", "AQAAAAEAACcQAAAAECzygvnfKnt3hReXHbiaQ/dmnCEncTQIOL+POja/sA54PX33+hO9DpKBQBZ4iug6Ww==", null, false, "00cfe3ef-b473-45b3-b92e-c2f8c69ebbd6", false, "sbrader@gmail.com", "Steven", true, "Brader" }
                });

            migrationBuilder.InsertData(
                table: "SnackType",
                columns: new[] { "SnackTypeId", "Snackid", "imageURL", "snackTypeName" },
                values: new object[,]
                {
                    { 1, null, "/images/milk-bottle.png", "Drink" },
                    { 2, null, "/images/snack.png", "Chip" },
                    { 3, null, "/images/chocolate-bar.png", "Candy" }
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
                columns: new[] { "id", "SnackTypeId", "snackCalories", "snackName", "snackPrice", "vendingMachineId" },
                values: new object[,]
                {
                    { 9, 1, 168, "Red Bull", 2.5, 2 },
                    { 1, 3, 210, "Reese's Peanut Butter Cups", 1.0, 1 },
                    { 2, 1, 140, "Coke", 1.0, 1 },
                    { 3, 2, 160, "Lays Original", 0.75, 1 },
                    { 4, 1, 240, "Iced Coffee", 3.0, 1 },
                    { 5, 2, 160, "Lays BBQ", 0.75, 1 },
                    { 6, 3, 215, "Snickers", 1.0, 1 },
                    { 7, 1, 150, "Dr. Pepper", 1.0, 1 },
                    { 8, 2, 150, "Doritos Salsa Verde", 1.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserSnack",
                columns: new[] { "id", "snackId", "userId", "userId1" },
                values: new object[,]
                {
                    { 3, 9, 2, null },
                    { 4, 1, 3, null },
                    { 2, 7, 1, null },
                    { 5, 7, 3, null },
                    { 1, 8, 1, null }
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
                name: "IX_Snack_SnackTypeId",
                table: "Snack",
                column: "SnackTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Snack_vendingMachineId",
                table: "Snack",
                column: "vendingMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_SnackType_Snackid",
                table: "SnackType",
                column: "Snackid");

            migrationBuilder.CreateIndex(
                name: "IX_UserSnack_snackId",
                table: "UserSnack",
                column: "snackId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSnack_userId1",
                table: "UserSnack",
                column: "userId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSnack_Snack_snackId",
                table: "UserSnack",
                column: "snackId",
                principalTable: "Snack",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SnackType_Snack_Snackid",
                table: "SnackType",
                column: "Snackid",
                principalTable: "Snack",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Snack_SnackType_SnackTypeId",
                table: "Snack");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SnackType");

            migrationBuilder.DropTable(
                name: "Snack");

            migrationBuilder.DropTable(
                name: "VendingMachine");
        }
    }
}
