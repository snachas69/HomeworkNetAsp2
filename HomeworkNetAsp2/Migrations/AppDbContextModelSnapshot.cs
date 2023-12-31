﻿// <auto-generated />
using HomeworkNetAsp2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeworAspNet2Task1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HomeworkNetAsp2.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AnimalType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sound")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spicies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("HomeworkNetAsp2.Models.Cat", b =>
                {
                    b.HasBaseType("HomeworkNetAsp2.Models.Animal");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("HomeworkNetAsp2.Models.Dog", b =>
                {
                    b.HasBaseType("HomeworkNetAsp2.Models.Animal");

                    b.Property<string>("TrainedFor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("HomeworkNetAsp2.Models.Mouse", b =>
                {
                    b.HasBaseType("HomeworkNetAsp2.Models.Animal");

                    b.ToTable("Mice");
                });

            modelBuilder.Entity("HomeworkNetAsp2.Models.Spider", b =>
                {
                    b.HasBaseType("HomeworkNetAsp2.Models.Animal");

                    b.Property<bool>("IsPoisonous")
                        .HasColumnType("bit");

                    b.ToTable("Spiders");
                });

            modelBuilder.Entity("HomeworkNetAsp2.Models.Cat", b =>
                {
                    b.HasOne("HomeworkNetAsp2.Models.Animal", null)
                        .WithOne()
                        .HasForeignKey("HomeworkNetAsp2.Models.Cat", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeworkNetAsp2.Models.Dog", b =>
                {
                    b.HasOne("HomeworkNetAsp2.Models.Animal", null)
                        .WithOne()
                        .HasForeignKey("HomeworkNetAsp2.Models.Dog", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeworkNetAsp2.Models.Mouse", b =>
                {
                    b.HasOne("HomeworkNetAsp2.Models.Animal", null)
                        .WithOne()
                        .HasForeignKey("HomeworkNetAsp2.Models.Mouse", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeworkNetAsp2.Models.Spider", b =>
                {
                    b.HasOne("HomeworkNetAsp2.Models.Animal", null)
                        .WithOne()
                        .HasForeignKey("HomeworkNetAsp2.Models.Spider", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
