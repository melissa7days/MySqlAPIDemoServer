using Microsoft.EntityFrameworkCore;
using MySqlAPIDemoServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlAPIDemoServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
