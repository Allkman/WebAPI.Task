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
        public TaskDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
        
    }
}
