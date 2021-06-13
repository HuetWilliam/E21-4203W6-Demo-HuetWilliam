using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty2.Models
{
    public class ZombieType
    {

        public int Id { get; set; }

        [DisplayName("Type Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Type Name has to be fill.")]
        public string TypeName { get; set; }

        [Required]
        [Range(2,5, ErrorMessage = "The point must be between 2 and 5.")]
        public int Point { get; set; }

    }
}
