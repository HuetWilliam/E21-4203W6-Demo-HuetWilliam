using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty_DataAccess.Repository.IRepository;
using ZombieParty_Models.ViewModels;
using ZombieParty2.Models;
using ZombieParty2_DataAccess.Data;

namespace ZombieParty2.Controllers
{
    public class ZombieController : Controller
    {
        private readonly IRepositoryZombie _zombieRepo;
        private readonly IRepositoryZombieType _zombieTypeRepo;

        public ZombieController(IRepositoryZombie zombieRepo, IRepositoryZombieType zombieTypeRepo)
        {
            _zombieRepo = zombieRepo;
            _zombieTypeRepo = zombieTypeRepo;
        }

        public IActionResult Index()
        {
            ZombieCardVM zombieCardVM = new ZombieCardVM()
            {
                Zombie = _zombieRepo.GetAll(includeProperties: "ZombieType"),
                ZombieType = _zombieTypeRepo.GetAll()
            };
            
            return View(zombieCardVM);
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
