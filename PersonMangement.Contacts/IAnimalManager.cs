using System.Collections.Generic;

using DM.MultiLayer.Data.Repositories;

namespace BM.MultiLayer.Logic.PersonMangement.Contacts
{
    public interface IAnimalManager
    {
        IEnumerable<Animal> GetAll();
        IEnumerable<Animal> GetAllAdults();
    }
}
