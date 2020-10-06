﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupervisionApp.EF.DataContexts;

namespace SupervisionApp.EF.Migrations
{
    [DbContext(typeof(CommonDataContext))]
    partial class CommonDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Supervision.CommonModel.Models.Contracts.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsInForce")
                        .HasColumnType("bit");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SignDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Customers.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Documentation.CoatingDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsInForce")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoatingDocument");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Documentation.CoatingTypeDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("CoatingType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("CoatingTypeDocument");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Documentation.ProductDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsInForce")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductDocument");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Orders.PID", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("ClimaticModification")
                        .HasColumnType("tinyint");

                    b.Property<int?>("CoatingTypeDocumentId")
                        .HasColumnType("int");

                    b.Property<byte>("ConnectionType")
                        .HasColumnType("tinyint");

                    b.Property<string>("Consignee")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Diameter")
                        .HasColumnType("int");

                    b.Property<byte>("DriveType")
                        .HasColumnType("tinyint");

                    b.Property<int>("FactoryId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<byte>("PressureDifference")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PressureLimit")
                        .HasColumnType("tinyint");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("SeismicStability")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("ShipmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("CoatingTypeDocumentId");

                    b.HasIndex("FactoryId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SpecificationId");

                    b.ToTable("PIDs");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Orders.PIDCoatingDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DocumentId")
                        .HasColumnType("int");

                    b.Property<int?>("PIDId")
                        .HasColumnType("int");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("PIDId");

                    b.ToTable("PIDCoatingDocument");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Orders.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("FacilityId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte>("Programme")
                        .HasColumnType("tinyint");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FacilityId");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.Factories.Factory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("SubdivisionDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubdivisionDepartmentId");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.Factories.FactoryProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FactoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("FactoryProductTypes");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Role")
                        .HasColumnType("tinyint");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PostId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.EmployeeFactories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("FactoryId")
                        .HasColumnType("int");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("FactoryId");

                    b.ToTable("EmployeeFactories");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.Subdivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subdivisions");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.SubdivisionDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubdivisionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("SubdivisionId");

                    b.ToTable("SubdivisionDepartments");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.Products.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RecordCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Contracts.Contract", b =>
                {
                    b.HasOne("Supervision.CommonModel.Models.Customers.Customer", "Customer")
                        .WithMany("Contracts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Customers.Facility", b =>
                {
                    b.HasOne("Supervision.CommonModel.Models.Customers.Customer", "Customer")
                        .WithMany("Facilities")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Documentation.CoatingTypeDocument", b =>
                {
                    b.HasOne("Supervision.CommonModel.Models.Documentation.CoatingDocument", "Document")
                        .WithMany("CoatingTypes")
                        .HasForeignKey("DocumentId");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Orders.PID", b =>
                {
                    b.HasOne("Supervision.CommonModel.Models.Documentation.CoatingTypeDocument", null)
                        .WithMany("PIDs")
                        .HasForeignKey("CoatingTypeDocumentId");

                    b.HasOne("SupervisionApp.CommonModel.Models.Factories.Factory", "Factory")
                        .WithMany("PIDs")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SupervisionApp.CommonModel.Models.Products.ProductType", "ProductType")
                        .WithMany("PIDs")
                        .HasForeignKey("ProductTypeId");

                    b.HasOne("Supervision.CommonModel.Models.Orders.Specification", "Specification")
                        .WithMany("PIDs")
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Orders.PIDCoatingDocument", b =>
                {
                    b.HasOne("Supervision.CommonModel.Models.Documentation.CoatingTypeDocument", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId");

                    b.HasOne("Supervision.CommonModel.Models.Orders.PID", "PID")
                        .WithMany("CoatingDocuments")
                        .HasForeignKey("PIDId");
                });

            modelBuilder.Entity("Supervision.CommonModel.Models.Orders.Specification", b =>
                {
                    b.HasOne("Supervision.CommonModel.Models.Customers.Customer", "Customer")
                        .WithMany("Specifications")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Supervision.CommonModel.Models.Customers.Facility", "Facility")
                        .WithMany("Specifications")
                        .HasForeignKey("FacilityId");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.Factories.Factory", b =>
                {
                    b.HasOne("SupervisionApp.CommonModel.Models.OrganizationStructure.SubdivisionDepartment", "SubdivisionDepartment")
                        .WithMany("Factories")
                        .HasForeignKey("SubdivisionDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.Factories.FactoryProductType", b =>
                {
                    b.HasOne("SupervisionApp.CommonModel.Models.Factories.Factory", "Factory")
                        .WithMany("ProductTypes")
                        .HasForeignKey("FactoryId");

                    b.HasOne("SupervisionApp.CommonModel.Models.Products.ProductType", "ProductType")
                        .WithMany("Factories")
                        .HasForeignKey("ProductTypeId");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.Account", b =>
                {
                    b.HasOne("SupervisionApp.CommonModel.Models.OrganizationStructure.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.Employee", b =>
                {
                    b.HasOne("SupervisionApp.CommonModel.Models.OrganizationStructure.SubdivisionDepartment", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("SupervisionApp.CommonModel.Models.OrganizationStructure.Post", "Post")
                        .WithMany("Employees")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.EmployeeFactories", b =>
                {
                    b.HasOne("SupervisionApp.CommonModel.Models.OrganizationStructure.Employee", "Employee")
                        .WithMany("EmployeeFactories")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("SupervisionApp.CommonModel.Models.Factories.Factory", "Factory")
                        .WithMany("EmployeeFactories")
                        .HasForeignKey("FactoryId");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.OrganizationStructure.SubdivisionDepartment", b =>
                {
                    b.HasOne("SupervisionApp.CommonModel.Models.OrganizationStructure.Department", "Department")
                        .WithMany("SubdivisionDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SupervisionApp.CommonModel.Models.OrganizationStructure.Subdivision", "Subdivision")
                        .WithMany("SubdivisionDepartments")
                        .HasForeignKey("SubdivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.Products.ProductType", b =>
                {
                    b.HasOne("Supervision.CommonModel.Models.Documentation.ProductDocument", "Document")
                        .WithMany("ProductTypes")
                        .HasForeignKey("DocumentId");
                });
#pragma warning restore 612, 618
        }
    }
}
