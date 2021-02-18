
using System;
using Microsoft.EntityFrameworkCore;
using damon_mvc.Models;


namespace damon_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
            public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) 
            : base(options)
            {
            }   
       

            public DbSet<Category> Category { get; set; } 
            public DbSet<ApplicationType> ApplicationType { get; set; }
    }
}