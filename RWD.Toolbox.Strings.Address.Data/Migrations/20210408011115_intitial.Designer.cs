﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RWD.Toolbox.Strings.Address.Data;

namespace RWD.Toolbox.Strings.Address.Data.Migrations
{
    [DbContext(typeof(SQLiteDBContext))]
    [Migration("20210408011115_intitial")]
    partial class intitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("RWD.Toolbox.Strings.Address.Data.PostalCode", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountyProvinceCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountyProvinceName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StateCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("StateName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PostalCodes");
                });
#pragma warning restore 612, 618
        }
    }
}
