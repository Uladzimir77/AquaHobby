using AquaHobby.EfStuff.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.EfStuff.Repositories
{
    public class FaunaRepository : BaseRepository<Fauna>
    {
        public FaunaRepository(AquaDbContext aquaDbContext) : base(aquaDbContext)
        {
        }
    }
}
