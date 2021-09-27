using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using HomeWorkTask.Data.Models;

namespace HomeWorkTask.Data
{
    public class HomeWorkTaskDbContext : DbContext
    {
        public HomeWorkTaskDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }

    }
}
