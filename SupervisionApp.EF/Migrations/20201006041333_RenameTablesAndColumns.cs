using Microsoft.EntityFrameworkCore.Migrations;

namespace SupervisionApp.EF.Migrations
{
    public partial class RenameTablesAndColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Customer_CustomerId",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Facility_Customer_CustomerId",
                table: "Facility");

            migrationBuilder.DropForeignKey(
                name: "FK_PID_CoatingTypeDocument_CoatingTypeDocumentId",
                table: "PID");

            migrationBuilder.DropForeignKey(
                name: "FK_PID_Factories_FactoryId",
                table: "PID");

            migrationBuilder.DropForeignKey(
                name: "FK_PID_ProductTypes_ProductTypeId",
                table: "PID");

            migrationBuilder.DropForeignKey(
                name: "FK_PID_Specification_SpecificationId",
                table: "PID");

            migrationBuilder.DropForeignKey(
                name: "FK_PIDCoatingDocument_PID_PIDId",
                table: "PIDCoatingDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_Specification_Customer_CustomerId",
                table: "Specification");

            migrationBuilder.DropForeignKey(
                name: "FK_Specification_Facility_FacilityId",
                table: "Specification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specification",
                table: "Specification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PID",
                table: "PID");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facility",
                table: "Facility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "PID");

            migrationBuilder.RenameTable(
                name: "Specification",
                newName: "Specifications");

            migrationBuilder.RenameTable(
                name: "PID",
                newName: "PIDs");

            migrationBuilder.RenameTable(
                name: "Facility",
                newName: "Facilities");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Specification_FacilityId",
                table: "Specifications",
                newName: "IX_Specifications_FacilityId");

            migrationBuilder.RenameIndex(
                name: "IX_Specification_CustomerId",
                table: "Specifications",
                newName: "IX_Specifications_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_PID_SpecificationId",
                table: "PIDs",
                newName: "IX_PIDs_SpecificationId");

            migrationBuilder.RenameIndex(
                name: "IX_PID_ProductTypeId",
                table: "PIDs",
                newName: "IX_PIDs_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PID_FactoryId",
                table: "PIDs",
                newName: "IX_PIDs_FactoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PID_CoatingTypeDocumentId",
                table: "PIDs",
                newName: "IX_PIDs_CoatingTypeDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Facility_CustomerId",
                table: "Facilities",
                newName: "IX_Facilities_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "ProductQuantity",
                table: "PIDs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specifications",
                table: "Specifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PIDs",
                table: "PIDs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Customers_CustomerId",
                table: "Contract",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_Customers_CustomerId",
                table: "Facilities",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PIDCoatingDocument_PIDs_PIDId",
                table: "PIDCoatingDocument",
                column: "PIDId",
                principalTable: "PIDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PIDs_CoatingTypeDocument_CoatingTypeDocumentId",
                table: "PIDs",
                column: "CoatingTypeDocumentId",
                principalTable: "CoatingTypeDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PIDs_Factories_FactoryId",
                table: "PIDs",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PIDs_ProductTypes_ProductTypeId",
                table: "PIDs",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PIDs_Specifications_SpecificationId",
                table: "PIDs",
                column: "SpecificationId",
                principalTable: "Specifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Customers_CustomerId",
                table: "Specifications",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Facilities_FacilityId",
                table: "Specifications",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Customers_CustomerId",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_Customers_CustomerId",
                table: "Facilities");

            migrationBuilder.DropForeignKey(
                name: "FK_PIDCoatingDocument_PIDs_PIDId",
                table: "PIDCoatingDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_PIDs_CoatingTypeDocument_CoatingTypeDocumentId",
                table: "PIDs");

            migrationBuilder.DropForeignKey(
                name: "FK_PIDs_Factories_FactoryId",
                table: "PIDs");

            migrationBuilder.DropForeignKey(
                name: "FK_PIDs_ProductTypes_ProductTypeId",
                table: "PIDs");

            migrationBuilder.DropForeignKey(
                name: "FK_PIDs_Specifications_SpecificationId",
                table: "PIDs");

            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Customers_CustomerId",
                table: "Specifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Facilities_FacilityId",
                table: "Specifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specifications",
                table: "Specifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PIDs",
                table: "PIDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ProductQuantity",
                table: "PIDs");

            migrationBuilder.RenameTable(
                name: "Specifications",
                newName: "Specification");

            migrationBuilder.RenameTable(
                name: "PIDs",
                newName: "PID");

            migrationBuilder.RenameTable(
                name: "Facilities",
                newName: "Facility");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Specifications_FacilityId",
                table: "Specification",
                newName: "IX_Specification_FacilityId");

            migrationBuilder.RenameIndex(
                name: "IX_Specifications_CustomerId",
                table: "Specification",
                newName: "IX_Specification_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_PIDs_SpecificationId",
                table: "PID",
                newName: "IX_PID_SpecificationId");

            migrationBuilder.RenameIndex(
                name: "IX_PIDs_ProductTypeId",
                table: "PID",
                newName: "IX_PID_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PIDs_FactoryId",
                table: "PID",
                newName: "IX_PID_FactoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PIDs_CoatingTypeDocumentId",
                table: "PID",
                newName: "IX_PID_CoatingTypeDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Facilities_CustomerId",
                table: "Facility",
                newName: "IX_Facility_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "PID",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specification",
                table: "Specification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PID",
                table: "PID",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facility",
                table: "Facility",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Customer_CustomerId",
                table: "Contract",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facility_Customer_CustomerId",
                table: "Facility",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PID_CoatingTypeDocument_CoatingTypeDocumentId",
                table: "PID",
                column: "CoatingTypeDocumentId",
                principalTable: "CoatingTypeDocument",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PID_Factories_FactoryId",
                table: "PID",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PID_ProductTypes_ProductTypeId",
                table: "PID",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PID_Specification_SpecificationId",
                table: "PID",
                column: "SpecificationId",
                principalTable: "Specification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PIDCoatingDocument_PID_PIDId",
                table: "PIDCoatingDocument",
                column: "PIDId",
                principalTable: "PID",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specification_Customer_CustomerId",
                table: "Specification",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specification_Facility_FacilityId",
                table: "Specification",
                column: "FacilityId",
                principalTable: "Facility",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
