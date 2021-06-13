﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senparc.Xncf.CodeBuilder.Models;

namespace Senparc.Xncf.CodeBuilder.Migrations.Migrations.Sqlite
{
    [DbContext(typeof(CodeBuilderSenparcEntities))]
    [Migration("20210108155659_AddTenantId")]
    partial class AddTenantId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Senparc.Xncf.CodeBuilder.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdditionNote")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<int>("Blue")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Green")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Red")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Senparc_CodeBuilder_Color");
                });
#pragma warning restore 612, 618
        }
    }
}
