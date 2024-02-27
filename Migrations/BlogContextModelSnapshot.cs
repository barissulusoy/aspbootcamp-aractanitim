﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using songece.Models.Siniflar;

#nullable disable

namespace songece.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("songece.Models.Siniflar.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Kullanici")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sifre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("songece.Models.Siniflar.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdresAcik")
                        .HasColumnType("TEXT");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.Property<string>("Konum")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("songece.Models.Siniflar.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .HasColumnType("TEXT");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogImage")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("songece.Models.Siniflar.Hakkimizda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .HasColumnType("TEXT");

                    b.Property<string>("FotoUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hakkimizdas");
                });

            modelBuilder.Entity("songece.Models.Siniflar.Yorumlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Blogid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<int>("Userid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Yorum")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Blogid");

                    b.HasIndex("Userid");

                    b.ToTable("Yorumlars");
                });

            modelBuilder.Entity("songece.Models.Siniflar.İletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdSoyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Konu")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mesaj")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("İletisims");
                });

            modelBuilder.Entity("songece.Siniflar.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameSurname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("songece.Models.Siniflar.Blog", b =>
                {
                    b.HasOne("songece.Siniflar.Models.User", "Users")
                        .WithMany("Blogs")
                        .HasForeignKey("UsersId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("songece.Models.Siniflar.Yorumlar", b =>
                {
                    b.HasOne("songece.Models.Siniflar.Blog", "Blogs")
                        .WithMany("Yorumlars")
                        .HasForeignKey("Blogid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("songece.Siniflar.Models.User", "Users")
                        .WithMany("Yorumlars")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blogs");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("songece.Models.Siniflar.Blog", b =>
                {
                    b.Navigation("Yorumlars");
                });

            modelBuilder.Entity("songece.Siniflar.Models.User", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Yorumlars");
                });
#pragma warning restore 612, 618
        }
    }
}