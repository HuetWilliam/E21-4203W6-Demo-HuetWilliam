using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty2.Models;

namespace ZombieParty_Models.ViewModels
{
    public class ZombieCardVM
    {
        public IEnumerable<Zombie> Zombie { get; set; }
        public IEnumerable<ZombieType> ZombieType { get; set; }
    }
}
