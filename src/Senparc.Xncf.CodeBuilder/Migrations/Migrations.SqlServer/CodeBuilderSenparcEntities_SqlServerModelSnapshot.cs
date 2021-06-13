﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senparc.Xncf.CodeBuilder.Models;

namespace Senparc.Xncf.CodeBuilder.Migrations.Migrations.SqlServer
{
    [DbContext(typeof(CodeBuilderSenparcEntities_SqlServer))]
    partial class CodeBuilderSenparcEntities_SqlServerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");
#pragma warning restore 612, 618
            #region begin 自定义数据库表
            modelBuilder.Entity("Senparc.Xncf.CodeBuilder.BuilderTable", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();
                b.Property<DateTime>("AddTime")
                    .HasColumnType("datetime2");
                b.Property<string>("AdditionNote")
                    .HasColumnType("nvarchar(max)");
                b.Property<string>("AdminRemark")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("TableName")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("Comment")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("DetailTableName")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("DetailComment")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(max)");
                b.Property<string>("ClassName")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("Namespace")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("ModuleCode")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("ModuleName")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("Folder")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("Options")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("TypeId")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("TypeName")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<DateTime>("CreateTime")
                    .HasColumnType("datetime2");
                b.Property<string>("CreateUserId")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("CreateUserName")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<DateTime>("UpdateTime")
                    .HasColumnType("datetime2");
                b.Property<string>("UpdateUserId")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("UpdateUserName")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("Remark")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<int>("TenantId")
                    .HasColumnType("int");
                b.HasKey("Id");
                b.ToTable("Senparc_CodeBuilder_BuilderTable");
            });
            modelBuilder.Entity("Senparc.Xncf.CodeBuilder.BuilderTableColumn", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();
                b.Property<DateTime>("AddTime")
                    .HasColumnType("datetime2");
                b.Property<string>("AdditionNote")
                    .HasColumnType("nvarchar(max)");
                b.Property<string>("AdminRemark")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<int>("TableId")
                    .HasColumnType("int");
                b.Property<string>("TableName")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("ColumnName")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("Comment")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("ColumnType")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("EntityType")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("EntityName")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<bool>("IsKey")
                    .HasColumnType("bit");
                b.Property<bool>("IsIncrement")
                    .HasColumnType("bit");
                b.Property<bool>("IsRequired")
                    .HasColumnType("bit");
                b.Property<bool>("IsInsert")
                    .HasColumnType("bit");
                b.Property<bool>("IsEdit")
                    .HasColumnType("bit");
                b.Property<bool>("IsList")
                    .HasColumnType("bit");
                b.Property<bool>("IsQuery")
                    .HasColumnType("bit");
                b.Property<string>("QueryType")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("HtmlType")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("EditType")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<int>("Sort")
                    .HasColumnType("int");
                b.Property<DateTime>("CreateTime")
                    .HasColumnType("datetime2");
                b.Property<string>("CreateUserId")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<DateTime>("UpdateTime")
                    .HasColumnType("datetime2");
                b.Property<string>("UpdateUserId")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("UpdateUserName")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("CreateUserName")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("Remark")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<int>("TenantId")
                    .HasColumnType("int");
                b.Property<string>("EditRow")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<string>("EditCol")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.Property<int>("MaxLength")
                   .HasColumnType("int");
                b.Property<string>("DataSource")
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");
                b.HasKey("Id");
                b.ToTable("Senparc_CodeBuilder_BuilderTable");
            });
            modelBuilder.Entity("Senparc.Xncf.CodeBuilder.UserBuilderLog", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();
                b.Property<bool>("Flag")
                   .HasColumnType("bit");
                b.Property<DateTime>("AddTime")
                    .HasColumnType("datetime2");
                b.Property<DateTime>("LastUpdateTime")
                   .HasColumnType("datetime2");
                b.Property<string>("AdminRemark")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("Remark")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("AdditionNote")
                    .HasColumnType("nvarchar(max)");
                b.Property<int>("TenantId")
                  .HasColumnType("int");
                b.Property<string>("UserId")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("TableName")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("ModuleName")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<string>("Path")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");
                b.Property<int>("Count")
                  .HasColumnType("int");
                b.HasKey("Id");
                b.ToTable("Senparc_CodeBuilder_UserBuilderLog");
            });
            #endregion end 自定义数据库表


        }
    }
}
