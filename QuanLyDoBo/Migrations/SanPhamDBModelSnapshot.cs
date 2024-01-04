﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyDoBo.Model;

#nullable disable

namespace QuanLyDoBo.Migrations
{
    [DbContext(typeof(SanPhamDB))]
    partial class SanPhamDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("QuanLyDoBo.Model.Anh", b =>
                {
                    b.Property<int>("idanh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("hethang")
                        .HasColumnType("INTEGER");

                    b.Property<string>("maanh")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.Property<string>("masp")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("mau")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("path")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("idanh");

                    b.HasIndex("maanh")
                        .IsUnique();

                    b.HasIndex("masp");

                    b.ToTable("Anh");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.KieuMau", b =>
                {
                    b.Property<string>("idkieumau")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("tenmau")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("idkieumau");

                    b.ToTable("KieuMau");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.SanPham", b =>
                {
                    b.Property<int>("idsp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("idsp");

                    b.Property<string>("anhdaidien")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("gia")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("hethang")
                        .HasColumnType("INTEGER");

                    b.Property<string>("idkieumau")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("loaivai")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("masp")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("namesp")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("sale")
                        .HasColumnType("INTEGER");

                    b.HasKey("idsp");

                    b.HasIndex("idkieumau");

                    b.HasIndex("masp");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.Size", b =>
                {
                    b.Property<int>("idsize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("maanh")
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.Property<string>("masize")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("masp")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("size")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<int>("soluong")
                        .HasColumnType("INTEGER");

                    b.HasKey("idsize");

                    b.HasIndex("maanh");

                    b.HasIndex("masize")
                        .IsUnique();

                    b.HasIndex("masp");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.Anh", b =>
                {
                    b.HasOne("QuanLyDoBo.Model.SanPham", "SanPham")
                        .WithMany("Anhs")
                        .HasForeignKey("masp")
                        .HasPrincipalKey("masp");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.SanPham", b =>
                {
                    b.HasOne("QuanLyDoBo.Model.KieuMau", "KieuMau")
                        .WithMany("SanPhams")
                        .HasForeignKey("idkieumau")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KieuMau");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.Size", b =>
                {
                    b.HasOne("QuanLyDoBo.Model.Anh", "Anh")
                        .WithMany("Sizes")
                        .HasForeignKey("maanh")
                        .HasPrincipalKey("maanh");

                    b.HasOne("QuanLyDoBo.Model.SanPham", "SanPham")
                        .WithMany("Sizes")
                        .HasForeignKey("masp")
                        .HasPrincipalKey("masp");

                    b.Navigation("Anh");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.Anh", b =>
                {
                    b.Navigation("Sizes");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.KieuMau", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("QuanLyDoBo.Model.SanPham", b =>
                {
                    b.Navigation("Anhs");

                    b.Navigation("Sizes");
                });
#pragma warning restore 612, 618
        }
    }
}
