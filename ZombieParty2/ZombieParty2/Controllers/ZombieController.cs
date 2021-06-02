using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty2.Models;

namespace ZombieParty2.Controllers
{
    public class ZombieController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MaListe = new List<Zombie>()
            {
                new Zombie(){Name = "LeChuck", Type = "Fiction", Point = 5},
                new Zombie(){Name = "Lenore", Type = "Fiction", Point = 4},
                new Zombie(){Name = "Draugr", Type = "Légendraire", Point = 2},
                new Zombie(){Name = "Ragamuffin", Type = "Légendraire", Point = 5},
                new Zombie(){Name = "Taxidermy", Type = "Légendraire", Point = 1},
                new Zombie(){Name = "chien de l'enfer", Type = "Fiction", Point = 7},
                new Zombie(){Name = "Avogadro", Type = "Fiction", Point = 9}
            };
            
            return View();
        }
    }
}
