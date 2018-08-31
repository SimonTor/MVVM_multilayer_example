using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BM.MultiLayer.Data.Repositories.Contracts;

namespace DM.MultiLayer.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        public IEnumerable<Animal> GetAll()
        {
            return new[]
            {
                new Animal(1,"Wuffi","Wuff", 30),
                new Animal(2,"Mizzi","Miez", 27),
                new Animal(3,"Fischi","Fisch", 1),
            };
        }
    }
}
