using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty2.Models;
using ZombieParty2.Models.Data;

namespace ZombieParty2.Controllers
{
    public class ZombieTypeController : Controller
    {
        private readonly ZombiePartyDbContext _db;

        public ZombieTypeController(ZombiePartyDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ZombieType> objList = _db.ZombieType;
            #region Avec liste
            /*
            ViewBag.MaListe = new List<ZombieType>()
            {
                new ZombieType() {TypeName = "Virus", Id = 1},
                new ZombieType() {TypeName = "Contact", Id = 2}
            };
            */
            #endregion

            return View(objList);
        }

        //GET CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ZombieType zombieType)
        {
            _db.ZombieType.Add(zombieType);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
