using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZombieParty_DataAccess.Repository.IRepository;
using ZombieParty2.Models;
using ZombieParty2_DataAccess.Data;

namespace ZombieParty_DataAccess.Repository
{
    public class RepositoryZombie : Repository<Zombie>, IRepositoryZombie
    {
        private readonly ZombiePartyDbContext _db;

        public RepositoryZombie(ZombiePartyDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Zombie obj)
        {
            _db.Zombie.Update(obj);
        }
    }
}
