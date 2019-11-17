using System.Collections.Generic;

namespace _08MilitaryElite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        public Dictionary<int,IPrivate> Privates { get; }
    }
}
