using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch1_DET_2022.Models;

namespace Batch1_DET_2022.Data
{
    public class BookContext : DbContext
    {

        public BookContext()
        {



        }

        public BookContext(DbContextOptions<BookContext> options)
              : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                //optionsBuilder.UseSqlServer("Server=DESKTOP-OHKB8EP\\SQLEXPRESS;Database=TSQ_Training;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer("Server=DESKTOP-OHKB8EP\\SQLEXPRESS;Database=TSQ_Training;Trusted_Connection=True;MultipleActiveResultsSets=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                   .Property(b => b.price)
                   .IsRequired()
                   .HasColumnName("BKprice")
                   .HasDefaultValue(200);

        }
      

        public static void Main()
        {


        }


    }
}
