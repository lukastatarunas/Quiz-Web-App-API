using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public new DbSet<User> Users { get; set; }
        public DbSet<Test1Result> Test1Results { get; set; }
        public DbSet<Test2Result> Test2Results { get; set; }
        public DbSet<Test3Result> Test3Results { get; set; }
        public DbSet<Test4Result> Test4Results { get; set; }
        public DbSet<Test5Result> Test5Results { get; set; }
    }
}
