using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.EfStuff.Model
{
    public class Fish : BaseModel
    {
        public int Cost { get; set; }
        public string Url { get; set; }
    }
}
