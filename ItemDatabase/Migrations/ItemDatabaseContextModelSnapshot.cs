﻿// <auto-generated />
using ItemDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ItemDatabase.Migrations
{
    [DbContext(typeof(ItemDatabaseContext))]
    partial class ItemDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("ItemDatabase.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddedProjectiles")
                        .HasColumnType("INTEGER");

                    b.Property<float>("AttackDamage")
                        .HasColumnType("REAL");

                    b.Property<float>("AttackSpeed")
                        .HasColumnType("REAL");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("TEXT");

                    b.Property<float>("ItemHealing")
                        .HasColumnType("REAL");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxLife")
                        .HasColumnType("INTEGER");

                    b.Property<float>("MoveSpeed")
                        .HasColumnType("REAL");

                    b.Property<string>("SpritePath")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Unlocked")
                        .HasColumnName("unlocked")
                        .HasColumnType("bool");

                    b.HasKey("Id");

                    b.ToTable("ItemTable");
                });
#pragma warning restore 612, 618
        }
    }
}
