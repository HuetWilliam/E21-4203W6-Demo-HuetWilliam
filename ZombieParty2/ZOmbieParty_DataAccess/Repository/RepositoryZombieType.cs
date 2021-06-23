using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty_DataAccess.Repository.IRepository;
using ZombieParty2.Models;
using ZombieParty2_DataAccess.Data;

namespace ZombieParty_DataAccess.Repository
{
    public class RepositoryZombieType : Repository<ZombieType>, IRepositoryZombieType
    {
        private readonly ZombiePartyDbContext _db;

        public RepositoryZombieType(ZombiePartyDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ZombieType obj)
        {
            _db.ZombieType.Update(obj);
        }
    }
}
