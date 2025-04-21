using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubClassLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Member - Membership (One-to-many)
            modelBuilder.Entity<Membership>()
                .HasOne(m => m.Member)
                .WithMany(mb => mb.Memberships)
                .HasForeignKey(m => m.MemberId)
                .OnDelete(DeleteBehavior.NoAction); // Important: Prevent deleting member if memberships exist

            // MembershipType - Membership (One-to-many)
            modelBuilder.Entity<Membership>()
                .HasOne(m => m.MembershipType)
                .WithMany(mt => mt.Memberships)
                .HasForeignKey(m => m.MembershipTypeId)
                .OnDelete(DeleteBehavior.NoAction); // Prevent deleting membership type if memberships exist

            // Member - Payment (One-to-many)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Member)
                .WithMany(m => m.Payments)
                .HasForeignKey(p => p.MemberId)
                .OnDelete(DeleteBehavior.NoAction);

            // Membership - Payment (One-to-many, optional)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Membership)  // Payment might not be for a membership
                .WithMany(m => m.Payments)
                .HasForeignKey(p => p.MembershipId)
                .OnDelete(DeleteBehavior.NoAction);



            // Seed Membership Types
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType { Id = 1, Name = "Monthly", Description = "Monthly Membership", BasePrice = 50 },
                new MembershipType { Id = 2, Name = "Annual", Description = "Annual Membership", BasePrice = 500 },
                new MembershipType { Id = 3, Name = "Premium", Description = "Premium Membership", BasePrice = 800 }
            );

            // Seed Members
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    Name = "John",
                    BirthDate = new DateTime(1990, 5, 15),
                    JoinDate = new DateTime(2024, 01, 01),
                    Address = "",
                    PhoneNumber =""
                },
                new Member
                {
                    Id = 2,
                    Name = "Jane",
                    BirthDate = new DateTime(1985, 10, 20),
                    JoinDate = new DateTime(2024, 01, 01),
                    Address = "",
                    PhoneNumber = ""
                }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "admin1",
                    Email =  "admin1@gmail.com",
                    Password =  "123",
                    UsersPermission = true ,
                    MembersPermission = false ,
                    ReportsPermission = false ,
                },
                new User
                {
                    Id = 2,
                    Name = "admin2",
                    Email = "admin2@gmail.com",
                    Password = "456",
                    UsersPermission = false,
                    MembersPermission = true,
                    ReportsPermission = false,
                },
                new User
                {
                    Id = 3,
                    Name = "admin3",
                    Email = "admin3@gmail.com",
                    Password = "789",
                    UsersPermission = false,
                    MembersPermission = false,
                    ReportsPermission = true,
                }
            );

            base.OnModelCreating(modelBuilder);

        }
    }
}
