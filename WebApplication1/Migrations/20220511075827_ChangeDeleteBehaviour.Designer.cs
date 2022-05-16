﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Context;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220511075827_ChangeDeleteBehaviour")]
    partial class ChangeDeleteBehaviour
    {
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "3.1.24")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128)
//                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//            modelBuilder.Entity("WebApplication1.Models.Club", b =>
//                {
//                    b.Property<int>("Id")
//                        .HasColumnType("int");

//                    b.Property<int>("Budget")
//                        .HasColumnType("int");

//                    b.Property<string>("City")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("ClubName")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Founded")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Owner")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("Club");
//                });

//            modelBuilder.Entity("WebApplication1.Models.Footballer", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int>("ClubId")
//                        .HasColumnType("int");

//                    b.Property<string>("DateOfBirth")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Position")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<int>("Price")
//                        .HasColumnType("int");

//                    b.Property<int>("Rating")
//                        .HasColumnType("int");

//                    b.Property<string>("Status")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Surname")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.HasIndex("ClubId");

//                    b.ToTable("Footballer");
//                });

//            modelBuilder.Entity("WebApplication1.Models.Footballer", b =>
//                {
//                    b.HasOne("WebApplication1.Models.Club", "Club")
//                        .WithMany()
//                        .HasForeignKey("ClubId")
//                        .OnDelete(DeleteBehavior.NoAction)
//                        .IsRequired();
//                });
//#pragma warning restore 612, 618
//        }
    }
}
