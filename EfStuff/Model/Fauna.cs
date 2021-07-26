using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.EfStuff.Model
{
    public class Fauna : BaseModel
    {
        public string ImageUrl { get; set; }
        public string FaunaName { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}
