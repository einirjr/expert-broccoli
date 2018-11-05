using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dinwin.Models;

namespace dinwin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<dinwin.Models.Ingredient> Ingredient { get; set; }
        public DbSet<dinwin.Models.Recipe> Recipe { get; set; }
    }
}
