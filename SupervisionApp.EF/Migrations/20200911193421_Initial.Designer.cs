﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupervisionApp.EF.DataContexts;

namespace SupervisionApp.EF.Migrations
{
    [DbContext(typeof(CommonDataContext))]
    [Migration("20200911193421_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("FactoryProductType");
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

                    b.ToTable("SubdivisionDepartment");
                });

            modelBuilder.Entity("SupervisionApp.CommonModel.Models.Products.ProductType", b =>
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
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
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
#pragma warning restore 612, 618
        }
    }
}
