using AquaHobby.EfStuff.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.EfStuff.Repositories
{
    public abstract class BaseRepository<ModelType> where ModelType : BaseModel
    {

        protected AquaDbContext _aquaDbContext;
        protected DbSet<ModelType> _dbSet;

        public BaseRepository(AquaDbContext aquaDbContext)
        {
            _aquaDbContext = aquaDbContext;
            _dbSet = _aquaDbContext.Set<ModelType>();
        }

        public List<ModelType> GetAll()
        {
            return _dbSet.ToList();
        }

        public ModelType Get(long id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public void Save(ModelType model)
        {
            _dbSet.Add(model);
            _aquaDbContext.SaveChanges();

        }
        public void Remove(long id)
        {
            var model = Get(id);
            Remove(model);
        }

        public void Remove(ModelType model)
        {
            _aquaDbContext.Remove(model);
            _aquaDbContext.SaveChanges();
        }

    }
}
