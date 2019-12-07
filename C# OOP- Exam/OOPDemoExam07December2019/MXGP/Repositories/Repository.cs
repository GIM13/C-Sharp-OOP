
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public abstract class Repository<T> 
        : IRepository<T>
    {  
        public IReadOnlyCollection<T> Models { get ; private set ; }

        public T GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(T model)
        {
            if (!Models.Contains(model))
            {
                Models.ToList().Add(model);
            }
        }

        public bool Remove(T model)
        {
          return  Models.ToList().Remove(model);
        }
    }
}
