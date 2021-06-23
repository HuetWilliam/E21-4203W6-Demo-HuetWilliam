using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty_DataAccess.Repository.IRepository;
using ZombieParty2.Models;
using ZombieParty2_DataAccess.Data;

namespace ZombieParty2.Controllers
{
    public class ZombieController : Controller
    {
        private readonly IRepositoryZombie _zombieRepo;

        public ZombieController(IRepositoryZombie db)
        {
            _zombieRepo = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Zombie> objList = _zombieRepo.GetAll();
            #region Avec liste
            /*
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
        public IActionResult Create(Zombie zombie)
        {
            _zombieRepo.Add(zombie);
            _zombieRepo.Save();

            return RedirectToAction("Index");
        }

        //GET EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _zombieRepo.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Zombie zombie)
        {
            if (ModelState.IsValid)
            {
                _zombieRepo.Update(zombie);
                _zombieRepo.Save();

                return RedirectToAction("Index");
            }
            return View(zombie);
        }

        //GET DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _zombieRepo.Find(id);
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
            var obj = _zombieRepo.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _zombieRepo.Remove(obj);
            _zombieRepo.Save();

            return RedirectToAction("Index");

        }
    }
}
