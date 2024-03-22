using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace DataAccess.Models
{
    public partial class PetShopContext : DbContext
    {

        //singleton pattern
        // Create an private static instance to access database following Singleton pattern
        private static PetShopContext instance = null;

        //using lock to prevent multithread
        private static readonly object instanceLock = new object();

        //create private constructor
        //private constructor is used to prevent user from 
        //creating instances with new() keyword
        private PetShopContext()
        {
        }

        //Tao property Instance de ket noi database
        public static PetShopContext Instance
        {
            //using lock to prevent multithread
            //It keeps separate threads from creating new instances of the singleton at the same time
            get
            {
                if (instance == null) // check instance before lock will save source rather than implement a lock
                                      //This technique call Double-Check Locking
                {
                    lock (instanceLock)
                    {
                        if (instance == null) // Check instance twice here to make sure no error occur when get instance
                        {
                            instance = new PetShopContext();
                        }
                    }
                }
                return instance;
            }
        }


        public PetShopContext(DbContextOptions<PetShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        public virtual DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:AssSalesDB"];
            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.TotalMoney).HasColumnType("money");
                entity.Property(e => e.OrderDate).HasColumnType("datetime");
                entity.Property(e => e.RequiredDate).HasColumnType("datetime");
                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Order__UserId__25869641");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderId).ValueGeneratedNever();
                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Order).WithOne(p => p.OrderDetail)
                    .HasForeignKey<OrderDetail>(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__2A4B4B5E");

                entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__OrderDeta__Produ__2B3F6F97");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
                entity.Property(e => e.UnitPrice).HasColumnType("money");
                entity.Property(e => e.Weight)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.Species)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}