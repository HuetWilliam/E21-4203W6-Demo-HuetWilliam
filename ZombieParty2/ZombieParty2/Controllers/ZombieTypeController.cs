using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty2.Models;

namespace ZombieParty2.Controllers
{
    public class ZombieTypeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MaListe = new List<ZombieType>()
            {
                new ZombieType() {TypeName = "Virus", Id = 1},
                new ZombieType() {TypeName = "Contact", Id = 2}
            };
            
            return View();
        }

        //GET CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST CREATE
        [HttpPost]
        public IActionResult Create(ZombieType zombieType)
        {
            if (ModelState.IsValid)
            {

            }            
            
            return View(zombieType);
        }
    }
}
