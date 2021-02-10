using Microsoft.EntityFrameworkCore;
using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.DAL.EFCoreContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DatabaseContext(DbContextOptions options)
            : base(options) { }
    }
}
