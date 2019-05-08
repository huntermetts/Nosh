using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nosh.Models;

namespace Nosh.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Snack> Snack { get; set; }
        public DbSet<VendingMachine> VendingMachine { get; set; }
        public DbSet<UserSnack> UserSnack { get; set; }
        public DbSet<SnackType> SnackType { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Restrict deletion of related order when OrderProducts entry is removed
            modelBuilder.Entity<VendingMachine>()
                .HasMany(v => v.Snack)
                .WithOne(l => l.vendingMachine)
                .OnDelete(DeleteBehavior.Restrict);


            //Adding the first user to the DB
            User userOne = new User
            {
                firstName = "Hunter",
                lastName = "Metts",
                UserName = "hmetts@gmail.com",
                NormalizedUserName = "HMETTS@GMAIL.COM",
                NormalizedEmail = "HMETTS@GMAIL.COM",
                Email = "hmetts@gmail.com",
                isVendor = false,
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            var passwordHash1 = new PasswordHasher<User>();
            userOne.PasswordHash = passwordHash1.HashPassword(userOne, "Hmetts*1");
            modelBuilder.Entity<User>().HasData(userOne);

            //Adding the second user to the DB
            User userTwo = new User
            {
                firstName = "Jordan",
                lastName = "Rosas",
                Email = "jrosas@gmail.com",
                UserName = "jrosas@gmail.com",
                NormalizedUserName = "JROSAS@GMAIL.COM",
                NormalizedEmail = "JROSAS@GMAIL.COM",
                isVendor = false,
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            var passwordHash2 = new PasswordHasher<User>();
            userTwo.PasswordHash = passwordHash2.HashPassword(userTwo, "Jrosas*1");
            modelBuilder.Entity<User>().HasData(userTwo);


            //Adding the third user to the DB
            User userThree = new User
            {
                firstName = "Asia",
                lastName = "Carter",
                Email = "acarter@gmail.com",
                UserName = "acarter@gmail.com",
                NormalizedUserName = "ACARTER@GMAIL.COM",
                NormalizedEmail = "ACARTER@GMAIL.COM",
                isVendor = false,
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            var passwordHash3 = new PasswordHasher<User>();
            userThree.PasswordHash = passwordHash3.HashPassword(userThree, "Acarter*1");
            modelBuilder.Entity<User>().HasData(userThree);

            //Adding the only VENDOR to the DB
            User vendorOne = new User
            {
                firstName = "Steven",
                lastName = "Brader",
                Email = "sbrader@gmail.com",
                UserName = "sbrader@gmail.com",
                NormalizedUserName = "SBRADER@GMAIL.COM",
                NormalizedEmail = "SBRADER@GMAIL.COM",
                isVendor = true,
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            var passwordHash4 = new PasswordHasher<User>();
            vendorOne.PasswordHash = passwordHash4.HashPassword(vendorOne, "Sbrader*1");
            modelBuilder.Entity<User>().HasData(vendorOne);

            //Adding 9 snacks to the DB
            modelBuilder.Entity<Snack>().HasData(
                new Snack()
                {
                    id = 1,
                    snackName = "Reese's Peanut Butter Cups",
                    snackPrice = 1.00,
                    snackCalories = 210,
                    SnackTypeId = 3,
                    vendingMachineId = 1
                },
                new Snack()
                {
                    id = 2,
                    snackName = "Coke",
                    snackPrice = 1.00,
                    snackCalories = 140,
                    SnackTypeId = 1,
                    vendingMachineId = 1
                },
                new Snack()
                {
                    id = 3,
                    snackName = "Lays Original",
                    snackPrice = .75,
                    snackCalories = 160,
                    SnackTypeId = 2,
                    vendingMachineId = 1
                },
                new Snack()
                {
                    id = 4,
                    snackName = "Iced Coffee",
                    snackPrice = 3.00,
                    snackCalories = 240,
                    SnackTypeId = 1,
                    vendingMachineId = 1
                },
                new Snack()
                {
                    id = 5,
                    snackName = "Lays BBQ",
                    snackPrice = .75,
                    snackCalories = 160,
                    SnackTypeId = 2,
                    vendingMachineId = 1
                },
                new Snack()
                {
                    id = 6,
                    snackName = "Snickers",
                    snackPrice = 1.00,
                    snackCalories = 215,
                    SnackTypeId = 3,
                    vendingMachineId = 1
                },
                new Snack()
                {
                    id = 7,
                    snackName = "Dr. Pepper",
                    snackPrice = 1.00,
                    snackCalories = 150,
                    SnackTypeId = 1,
                    vendingMachineId = 1
                },
                new Snack()
                {
                    id = 8,
                    snackName = "Doritos Salsa Verde",
                    snackPrice = 1.00,
                    snackCalories = 150,
                    SnackTypeId = 2,
                    vendingMachineId = 1
                },
                new Snack()
                {
                    id = 9,
                    snackName = "Red Bull",
                    snackPrice = 2.50,
                    snackCalories = 168,
                    SnackTypeId = 1,
                    vendingMachineId = 2
                }
                );

            //Adding 2 vending machines to the DB
            modelBuilder.Entity<VendingMachine>().HasData(
                new VendingMachine()
                {
                    id = 2,
                    vendingMachineName = "Loud and Cold",
                    vendingMachineLocation = "Closest to the coffee pot"
                },
                new VendingMachine()
                {
                    id = 1,
                    vendingMachineName = "The Mothership",
                    vendingMachineLocation = "Across from the microwaves"
                }
            );

            //Adding 3 snack types to the DB
            modelBuilder.Entity<SnackType>().HasData(
                new SnackType()
                {
                    SnackTypeId = 1,
                    snackTypeName = "Drink",
                    imageURL = "/images/milk-bottle.png"
                },
                new SnackType()
                {
                    SnackTypeId = 2,
                    snackTypeName = "Chip",
                    imageURL ="/images/snack.png"
                },
                new SnackType()
                {
                    SnackTypeId = 3,
                    snackTypeName = "Candy",
                    imageURL = "/images/chocolate-bar.png"
                }
            );

            //Adding user snacks to the DB
            modelBuilder.Entity<UserSnack>().HasData(
                new UserSnack()
                {
                    id = 1,
                    userId = 1,
                    snackId = 8
                },
                new UserSnack()
                {
                    id = 2,
                    userId = 1,
                    snackId = 7
                },
                new UserSnack()
                {
                    id = 3,
                    userId = 2,
                    snackId = 9
                },
                new UserSnack()
                {
                    id = 4,
                    userId = 3,
                    snackId = 1
                },
                new UserSnack()
                {
                    id = 5,
                    userId = 3,
                    snackId = 7
                }
            );
        }
    }
}
