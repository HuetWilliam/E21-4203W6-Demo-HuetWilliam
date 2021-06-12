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

        //GET EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.ZombieType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ZombieType zombieType)
        {
            if (ModelState.IsValid)
            {
                _db.ZombieType.Update(zombieType);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(zombieType);
        }

        //GET DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.ZombieType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.ZombieType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
                        
            _db.ZombieType.Remove(obj);
            _db.SaveChanges();
            
            return RedirectToAction("Index");
            
        }
    }
}
