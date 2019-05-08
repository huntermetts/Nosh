using Microsoft.EntityFrameworkCore.Migrations;

namespace Nosh.Migrations
{
    public partial class NoshMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44450521-c8ba-4a08-9700-0bb092c54d3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95a0e8fa-cd84-4f0b-9f2d-b02d16763df4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c825360f-b2ae-4aee-8ec4-22a48e2bee9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e17cdf4b-25c2-4a3f-8254-7f7227c8c317");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "firstName", "isVendor", "lastName" },
                values: new object[,]
                {
                    { "ec255e6d-84f2-422a-a483-b577cd2e8298", 0, "44fbd1ff-2bdc-43a3-aafe-6ccb1453e9ec", "User", "hmetts@gmail.com", true, false, null, "HMETTS@GMAIL.COM", "HMETTS@GMAIL.COM", "AQAAAAEAACcQAAAAEBiohN0v+yZ74JZe3YiqJyL1C3HSlyhbYJr7PCYzD5RGbmwkqYL907/Gwb1jrM/Lig==", null, false, "814a78fc-de85-42e0-948a-d1eb078382fb", false, "hmetts@gmail.com", "Hunter", false, "Metts" },
                    { "5df331d2-d794-4370-a88f-ed2abe6e43fb", 0, "40872b0f-0a72-4711-ab97-d200f895a8f9", "User", "jrosas@gmail.com", true, false, null, "JROSAS@GMAIL.COM", "JROSAS@GMAIL.COM", "AQAAAAEAACcQAAAAELP1J4IOPA6RVt3c3Ov+tXJB/97cqvG2MJZTBcychUeIFpbxVIDXX9tvnK80oRybuQ==", null, false, "e2efd3c4-c7ec-4abd-893b-db793279e58e", false, "jrosas@gmail.com", "Jordan", false, "Rosas" },
                    { "9d5ee710-a38a-4f9e-a9dd-4838705922a2", 0, "eab510da-877e-47f4-8e5c-8c9fbdf41948", "User", "acarter@gmail.com", true, false, null, "ACARTER@GMAIL.COM", "ACARTER@GMAIL.COM", "AQAAAAEAACcQAAAAEKimWlYPGZAXRHYo4HvlnI8LvFI1Bpw4oWIb2GfSijD2EbnPxxVEi5lbFQhDUzsx/g==", null, false, "647d88cc-cfb8-4721-80de-4099bccdb06c", false, "acarter@gmail.com", "Asia", false, "Carter" },
                    { "937e5e51-8e25-404a-b0e7-4b82170d7bc3", 0, "05b34245-8c90-4869-918c-fdfe9e58704f", "User", "sbrader@gmail.com", true, false, null, "SBRADER@GMAIL.COM", "SBRADER@GMAIL.COM", "AQAAAAEAACcQAAAAEKBfCtj/yEEZGRZwq5kX+Dzj1XN4UeN7t1iqkClwNCevp5i25Ky1ghsAL2zK+imjqA==", null, false, "e55019f0-b1eb-4f09-9291-906a353db20e", false, "sbrader@gmail.com", "Steven", true, "Brader" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5df331d2-d794-4370-a88f-ed2abe6e43fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "937e5e51-8e25-404a-b0e7-4b82170d7bc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d5ee710-a38a-4f9e-a9dd-4838705922a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec255e6d-84f2-422a-a483-b577cd2e8298");

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
        }
    }
}
