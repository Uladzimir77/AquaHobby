using AquaHobby.EfStuff.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.EfStuff.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(AquaDbContext aquaDbContext): base (aquaDbContext)
        {
        }

        public User GetByName(string name)
        {
            return _dbSet.SingleOrDefault(x => x.Name == name);
        }

    }
}
