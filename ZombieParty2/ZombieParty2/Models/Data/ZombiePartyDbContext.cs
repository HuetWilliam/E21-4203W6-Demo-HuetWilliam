﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZombieParty2.Models.Data
{
    public class ZombiePartyDbContext : DbContext
    {
        public ZombiePartyDbContext(DbContextOptions<ZombiePartyDbContext> options) : base(options)
        {

        }

        public DbSet<Zombie> Zombie { get; set; }
        public DbSet<ZombieType> ZombieType { get; set; }
    }
}
