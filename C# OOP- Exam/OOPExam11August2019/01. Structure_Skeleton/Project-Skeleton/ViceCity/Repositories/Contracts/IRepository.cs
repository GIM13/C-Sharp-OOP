using ViceCity.Models.Guns.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Repositories.Contracts
{
    public interface IRepository<T>
    {
        HashSet<T> Models { get; }

        void Add(T model);

        bool Remove(T model);

        T Find(string name);

    }
}
