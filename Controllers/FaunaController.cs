using AquaHobby.EfStuff.Model;
using AquaHobby.EfStuff.Repositories;
using AquaHobby.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.Controllers
{
    public class FaunaController : Controller
    {
        private FaunaRepository _faunaRepository;

        public FaunaController(FaunaRepository faunaRepository)
        {
            _faunaRepository = faunaRepository;
        }

        public IActionResult Index()
        {
           var models= _faunaRepository
                .GetAll()
                .Select(x => new FaunaViewModel()
                {
                    Id=x.Id,
                    FaunaName = x.FaunaName,
                    ImageUrl = x.ImageUrl,
                    Price = x.Price,
                    Count = x.Count
                })
                .ToList();
            return View(models);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new FaunaViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(FaunaViewModel faunaViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(faunaViewModel);
            }

            var fauna = new Fauna()
            {
                FaunaName = faunaViewModel.FaunaName,
                ImageUrl = faunaViewModel.ImageUrl,
                Price = faunaViewModel.Price,
                Count = faunaViewModel.Count
            };

            _faunaRepository.Save(fauna);
            return RedirectToAction("Index");//перенаправляет на нужную страницу
        }
    
        public IActionResult Remove(long id)
        {
            _faunaRepository.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
