using Microsoft.EntityFrameworkCore.Migrations;

namespace SupervisionApp.EF.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SubdivisionDepartment_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Factories_SubdivisionDepartment_SubdivisionDepartmentId",
                table: "Factories");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoryProductType_Factories_FactoryId",
                table: "FactoryProductType");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoryProductType_ProductTypes_ProductTypeId",
                table: "FactoryProductType");

            migrationBuilder.DropForeignKey(
                name: "FK_SubdivisionDepartment_Departments_DepartmentId",
                table: "SubdivisionDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_SubdivisionDepartment_Subdivisions_SubdivisionId",
                table: "SubdivisionDepartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubdivisionDepartment",
                table: "SubdivisionDepartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoryProductType",
                table: "FactoryProductType");

            migrationBuilder.RenameTable(
                name: "SubdivisionDepartment",
                newName: "SubdivisionDepartments");

            migrationBuilder.RenameTable(
                name: "FactoryProductType",
                newName: "FactoryProductTypes");

            migrationBuilder.RenameIndex(
                name: "IX_SubdivisionDepartment_SubdivisionId",
                table: "SubdivisionDepartments",
                newName: "IX_SubdivisionDepartments_SubdivisionId");

            migrationBuilder.RenameIndex(
                name: "IX_SubdivisionDepartment_DepartmentId",
                table: "SubdivisionDepartments",
                newName: "IX_SubdivisionDepartments_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_FactoryProductType_ProductTypeId",
                table: "FactoryProductTypes",
                newName: "IX_FactoryProductTypes_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_FactoryProductType_FactoryId",
                table: "FactoryProductTypes",
                newName: "IX_FactoryProductTypes_FactoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubdivisionDepartments",
                table: "SubdivisionDepartments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoryProductTypes",
                table: "FactoryProductTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SubdivisionDepartments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "SubdivisionDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_SubdivisionDepartments_SubdivisionDepartmentId",
                table: "Factories",
                column: "SubdivisionDepartmentId",
                principalTable: "SubdivisionDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoryProductTypes_Factories_FactoryId",
                table: "FactoryProductTypes",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoryProductTypes_ProductTypes_ProductTypeId",
                table: "FactoryProductTypes",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubdivisionDepartments_Departments_DepartmentId",
                table: "SubdivisionDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubdivisionDepartments_Subdivisions_SubdivisionId",
                table: "SubdivisionDepartments",
                column: "SubdivisionId",
                principalTable: "Subdivisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SubdivisionDepartments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Factories_SubdivisionDepartments_SubdivisionDepartmentId",
                table: "Factories");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoryProductTypes_Factories_FactoryId",
                table: "FactoryProductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoryProductTypes_ProductTypes_ProductTypeId",
                table: "FactoryProductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SubdivisionDepartments_Departments_DepartmentId",
                table: "SubdivisionDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_SubdivisionDepartments_Subdivisions_SubdivisionId",
                table: "SubdivisionDepartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubdivisionDepartments",
                table: "SubdivisionDepartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoryProductTypes",
                table: "FactoryProductTypes");

            migrationBuilder.RenameTable(
                name: "SubdivisionDepartments",
                newName: "SubdivisionDepartment");

            migrationBuilder.RenameTable(
                name: "FactoryProductTypes",
                newName: "FactoryProductType");

            migrationBuilder.RenameIndex(
                name: "IX_SubdivisionDepartments_SubdivisionId",
                table: "SubdivisionDepartment",
                newName: "IX_SubdivisionDepartment_SubdivisionId");

            migrationBuilder.RenameIndex(
                name: "IX_SubdivisionDepartments_DepartmentId",
                table: "SubdivisionDepartment",
                newName: "IX_SubdivisionDepartment_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_FactoryProductTypes_ProductTypeId",
                table: "FactoryProductType",
                newName: "IX_FactoryProductType_ProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_FactoryProductTypes_FactoryId",
                table: "FactoryProductType",
                newName: "IX_FactoryProductType_FactoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubdivisionDepartment",
                table: "SubdivisionDepartment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoryProductType",
                table: "FactoryProductType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SubdivisionDepartment_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "SubdivisionDepartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_SubdivisionDepartment_SubdivisionDepartmentId",
                table: "Factories",
                column: "SubdivisionDepartmentId",
                principalTable: "SubdivisionDepartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoryProductType_Factories_FactoryId",
                table: "FactoryProductType",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoryProductType_ProductTypes_ProductTypeId",
                table: "FactoryProductType",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubdivisionDepartment_Departments_DepartmentId",
                table: "SubdivisionDepartment",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubdivisionDepartment_Subdivisions_SubdivisionId",
                table: "SubdivisionDepartment",
                column: "SubdivisionId",
                principalTable: "Subdivisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
