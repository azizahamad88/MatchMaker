using System;
using MatchMakerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace MatchMakerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<AppUser> Users { get; set; }
    }
}
