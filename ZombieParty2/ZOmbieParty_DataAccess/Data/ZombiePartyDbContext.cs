using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZombieParty2.Models;

namespace ZombieParty2_DataAccess.Data
{
    public class ZombiePartyDbContext : DbContext
    {
        public ZombiePartyDbContext(DbContextOptions<ZombiePartyDbContext> options) : base(options)
        {

        }

        public DbSet<Zombie> Zombie { get; set; }
        public DbSet<ZombieType> ZombieType { get; set; }
        public DbSet<HuntingLog> HuntingLog { get; set; }
    }
}
