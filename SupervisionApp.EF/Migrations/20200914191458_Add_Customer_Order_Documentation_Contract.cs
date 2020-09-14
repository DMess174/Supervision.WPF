using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SupervisionApp.EF.Migrations
{
    public partial class Add_Customer_Order_Documentation_Contract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "ProductTypes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CoatingDocument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(maxLength: 1000, nullable: false),
                    IsInForce = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoatingDocument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(maxLength: 200, nullable: false),
                    ShortName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDocument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(maxLength: 1000, nullable: false),
                    IsInForce = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDocument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoatingTypeDocument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    DocumentId = table.Column<int>(nullable: true),
                    CoatingType = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoatingTypeDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoatingTypeDocument_CoatingDocument_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "CoatingDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    Number = table.Column<string>(maxLength: 100, nullable: false),
                    SignDate = table.Column<DateTime>(nullable: false),
                    IsInForce = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 4000, nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facility_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    Number = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    FacilityId = table.Column<int>(nullable: true),
                    Programme = table.Column<byte>(nullable: false),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specification_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specification_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PID",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    Number = table.Column<string>(maxLength: 30, nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Consignee = table.Column<string>(maxLength: 4000, nullable: false),
                    SpecificationId = table.Column<int>(nullable: false),
                    FactoryId = table.Column<int>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: true),
                    ShipmentDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Diameter = table.Column<int>(nullable: false),
                    PressureLimit = table.Column<byte>(nullable: false),
                    PressureDifference = table.Column<byte>(nullable: false),
                    ConnectionType = table.Column<byte>(nullable: false),
                    DriveType = table.Column<byte>(nullable: false),
                    SeismicStability = table.Column<byte>(nullable: false),
                    ClimaticModification = table.Column<byte>(nullable: false),
                    CoatingTypeDocumentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PID_CoatingTypeDocument_CoatingTypeDocumentId",
                        column: x => x.CoatingTypeDocumentId,
                        principalTable: "CoatingTypeDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PID_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PID_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PID_Specification_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "Specification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PIDCoatingDocument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RecordCreator = table.Column<string>(nullable: true),
                    PIDId = table.Column<int>(nullable: true),
                    DocumentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIDCoatingDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PIDCoatingDocument_CoatingTypeDocument_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "CoatingTypeDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PIDCoatingDocument_PID_PIDId",
                        column: x => x.PIDId,
                        principalTable: "PID",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_DocumentId",
                table: "ProductTypes",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_CoatingTypeDocument_DocumentId",
                table: "CoatingTypeDocument",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_CustomerId",
                table: "Contract",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_CustomerId",
                table: "Facility",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PID_CoatingTypeDocumentId",
                table: "PID",
                column: "CoatingTypeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_PID_FactoryId",
                table: "PID",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PID_ProductTypeId",
                table: "PID",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PID_SpecificationId",
                table: "PID",
                column: "SpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_PIDCoatingDocument_DocumentId",
                table: "PIDCoatingDocument",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_PIDCoatingDocument_PIDId",
                table: "PIDCoatingDocument",
                column: "PIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Specification_CustomerId",
                table: "Specification",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Specification_FacilityId",
                table: "Specification",
                column: "FacilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_ProductDocument_DocumentId",
                table: "ProductTypes",
                column: "DocumentId",
                principalTable: "ProductDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_ProductDocument_DocumentId",
                table: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "PIDCoatingDocument");

            migrationBuilder.DropTable(
                name: "ProductDocument");

            migrationBuilder.DropTable(
                name: "PID");

            migrationBuilder.DropTable(
                name: "CoatingTypeDocument");

            migrationBuilder.DropTable(
                name: "Specification");

            migrationBuilder.DropTable(
                name: "CoatingDocument");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_DocumentId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "ProductTypes");
        }
    }
}
