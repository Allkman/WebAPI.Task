using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data.Models;

namespace Task.Data
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MC4QAMJ;Database=EventsDB;Trusted_Connection=True;");
        }

        //public TaskDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        //{
        //}

    }
}
