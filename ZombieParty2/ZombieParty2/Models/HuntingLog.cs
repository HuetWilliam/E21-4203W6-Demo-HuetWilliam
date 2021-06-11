using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty2.Models
{
    public class HuntingLog
    {
        [Key]
        public int Id { get; set; } 

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
