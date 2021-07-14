using AquaHobby.Models.CustomValidationAtribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.Models
{
    public class ProfileViewModel
    {
        [Required(ErrorMessage ="Поле обязательное для заполнения")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [MinAttributes(18,ErrorMessage = "Только совершеннолетние")] 
        public int Age { get; set; }
        public string Bio { get; set; }
        public DateTime DateRegistration { get; set; }
    }
}
