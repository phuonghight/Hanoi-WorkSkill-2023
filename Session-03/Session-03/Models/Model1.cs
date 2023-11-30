using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Session_03.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Amenity> Amenities { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Attraction> Attractions { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<CancellationPolicy> CancellationPolicies { get; set; }
        public virtual DbSet<CancellationRefundFee> CancellationRefundFees { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<DimDate> DimDates { get; set; }
        public virtual DbSet<ItemAmenity> ItemAmenities { get; set; }
        public virtual DbSet<ItemAttraction> ItemAttractions { get; set; }
        public virtual DbSet<ItemPicture> ItemPictures { get; set; }
        public virtual DbSet<ItemPrice> ItemPrices { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amenity>()
                .HasMany(e => e.ItemAmenities)
                .WithRequired(e => e.Amenity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.Attractions)
                .WithRequired(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attraction>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Attraction>()
                .HasMany(e => e.ItemAttractions)
                .WithRequired(e => e.Attraction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.BookingDetails)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CancellationPolicy>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CancellationPolicy>()
                .HasMany(e => e.CancellationRefundFees)
                .WithRequired(e => e.CancellationPolicy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CancellationPolicy>()
                .HasMany(e => e.ItemPrices)
                .WithRequired(e => e.CancellationPolicy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CancellationRefundFee>()
                .Property(e => e.PenaltyPercentage)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Coupon>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(4, 1);

            modelBuilder.Entity<Coupon>()
                .Property(e => e.MaximimDiscountAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DimDate>()
                .Property(e => e.MonthName)
                .IsUnicode(false);

            modelBuilder.Entity<DimDate>()
                .Property(e => e.DayName)
                .IsUnicode(false);

            modelBuilder.Entity<ItemAttraction>()
                .Property(e => e.Distance)
                .HasPrecision(5, 1);

            modelBuilder.Entity<ItemPicture>()
                .Property(e => e.PictureFileName)
                .IsUnicode(false);

            modelBuilder.Entity<ItemPrice>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ItemPrice>()
                .HasMany(e => e.BookingDetails)
                .WithRequired(e => e.ItemPrice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ExactAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ApproximateAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemAmenities)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemAttractions)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemPictures)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemPrices)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemType>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.ItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionType>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.TransactionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserType>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserType)
                .WillCascadeOnDelete(false);
        }
    }
}
