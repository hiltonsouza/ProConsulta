using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProConsulta.Migrations
{
    /// <inheritdoc />
    public partial class initialapp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6be31a9c-6ebe-4049-8890-be35a44fe534", "AQAAAAIAAYagAAAAEJX7NsKcvjIG2Xe1WlkHzcMix5tBmWEJuq8nMxYa1nJKkjs1zxetbZ9yyefA6TMsKQ==", "ceb1c851-503a-41e4-ad02-2ec1c4590735" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3c0a013-dba9-4e0c-a03b-8bceda5e9a35", "AQAAAAIAAYagAAAAECUfDNuvouPcvwu0mEUdWaMIgqky2xFc8dF7EAm19koR/wlqS+VDuRtdsCwI91GaIg==", "456a3d3c-c407-4c02-a5ef-d26581a91582" });
        }
    }
}
