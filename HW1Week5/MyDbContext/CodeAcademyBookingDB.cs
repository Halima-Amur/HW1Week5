using HW1Week5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW1Week5.Models;
namespace HW1Week5.MyDbContext
{
    internal class CodeAcademyBookingDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-0Q9I0GOE\\SQLEXPRESS;Initial Catalog=database;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Space> spaces { get; set; }


    }
}
