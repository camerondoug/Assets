using Microsoft.EntityFrameworkCore.Migrations;

namespace CPRG214.Assets.Data.Migrations
{
    public partial class CreateAssets2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagNumber = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false),
                    AssetTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Computer" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Monitor" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Phone" });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "AssetTypeId", "Description", "Manufacturer", "Model", "SerialNumber", "TagNumber" },
                values: new object[,]
                {
                    { 1, 1, "Laptop 16gb ram", "Dell", "Inspiron", "K47839J999", "59T2V22" },
                    { 2, 1, "Desktop 16GB ram", "Acer", "Aspire", "NXMQLLAAA0054", "VN7591G" },
                    { 3, 2, "Full HD Gaming", "Acer", "Nitro", "ADLKNNE009AFD883-1", "GH7591G-23" },
                    { 4, 2, "UHD 4K", "LG", "UltraFine", "KJHEFNG0067-55", "GH7591G-23" },
                    { 5, 3, "High-Fidelity and Secure", "Cisco", "8845 VoIP", "ADFJ8AEEF000000JU88", "J7J7M28" },
                    { 6, 3, "Videoconference ready desktop", "Polycom", "VVX601 IP", "LKJEI00001", "7m3LKUE8890-1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "AssetType");
        }
    }
}
