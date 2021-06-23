using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty2.Models;

namespace ZombieParty_DataAccess.Repository.IRepository
{
    public interface IRepositoryZombieType : IRepository<ZombieType>
    {
        public void Update(ZombieType obj);
    }
}
