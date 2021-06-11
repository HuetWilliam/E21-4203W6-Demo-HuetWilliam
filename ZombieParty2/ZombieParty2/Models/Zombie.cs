using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty2.Models
{
    public class Zombie
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The Name has to be fill.")]
        public string Name { get; set; }       

        [Range(1, 10, ErrorMessage = "The point must be 1 to 10")]
        public int Point { get; set; }

        //Clé étrangère
        public int IdZombieType { get; set; }

        [ForeignKey("IdZombieType")]
        //Relation avec ZombieType
        public virtual ZombieType ZombieType { get; set; }

        public string ShortDesc { get; set; }

    }
}
