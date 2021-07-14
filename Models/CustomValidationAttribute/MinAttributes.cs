using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.Models.CustomValidationAtribute
{
    public class MinAttributes : ValidationAttribute//написание собственного валидационного атрибута
    {
        public int MinValue { get; set; }
        
        public MinAttributes(int minValue)//обрабатывает цифру 18 ,  которая лежит в атрибуте в ProfileViewModel
        {
            MinValue = minValue;
        } 

        public override bool IsValid(object value)//
        {
            var number = value as int?;//присвоить, если number является int, иначе присвоить null

            if (number == null)
            {
                return false;
            }

            return number > MinValue;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.IsNullOrEmpty(ErrorMessage)//если в атрибуте в ProfileViewModel нет Error сообщения, то напиши что указано здесь
                ? $"Больше {MinValue}"
                : ErrorMessage;
        }
        
    }
}
