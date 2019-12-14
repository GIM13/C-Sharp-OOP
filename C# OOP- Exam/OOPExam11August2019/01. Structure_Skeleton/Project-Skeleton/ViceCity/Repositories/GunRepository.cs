using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository<Gun> : IRepository<Gun>
    {
        public HashSet<Gun> Models { get; private set; }

        public void Add(Gun model)
        {
            if (!Models.Any(x => x.Equals(model)))
            {
                Models.ToList().Add((Gun)model);
            }
        }

        public Gun Find(string name)
        {
            return Models.FirstOrDefault(x => x.Equals(name));
        }

        public bool Remove(Gun model)
        {
            return Models.Remove(model); 
        }
    }
}
