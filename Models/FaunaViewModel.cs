using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.Models
{
    public class FaunaViewModel
    {
        public string ImageUrl { get; set; }

        [Required]
        public string FaunaName { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public long Id { get; set; }
    }
}
