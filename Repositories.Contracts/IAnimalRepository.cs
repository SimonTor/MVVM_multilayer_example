using DM.MultiLayer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.MultiLayer.Data.Repositories.Contracts
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAll();
    }
}