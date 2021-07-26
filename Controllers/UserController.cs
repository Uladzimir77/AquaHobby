using AquaHobby.EfStuff;
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
    public class UserController : Controller
    {
        public static int Counter = 0;

        private UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Profile()
        {
            var model = new ProfileViewModel()
            {


            };
            return View(model);
        }

        public IActionResult MyHomeContent()
        {
        
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            var model = new RegistrationViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _userRepository.GetByName(model.Login);

            if (user == null)
            {
                ModelState.AddModelError(nameof(RegistrationViewModel.Login), "Нет такого пользователя");//добавляет сообщение , возле поля Login , на странице Login
                return View(model);
            }

            if (user.Password != model.Password)
            {
                ModelState.AddModelError(nameof(RegistrationViewModel.Password), "Не правильный пароль");//добавляет сообщение , возле поля Password , на странице Login
                return View(model);
            }

            return RedirectToAction("Profile", "User");
        }

        [HttpGet]
        public IActionResult Registration()
        {
            var model = new RegistrationViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Registration(RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var isUserUniq = _userRepository.GetByName(model.Login) == null;

            if (isUserUniq)
            {
                var user = new User()//создаем объект для базы данных
                {
                    Name = model.Login,
                    Password = model.Password,
                    Age = 18
                };
                _userRepository.Save(user);
            }

            return View(model);
        }

        public JsonResult IsUserExist(string name)//проверка, существует ли уже пользователь с таким User.Name
        {
            var isExistUserWithTheName = _userRepository.GetByName(name) != null;
            return Json(isExistUserWithTheName);
        }
    }
}
