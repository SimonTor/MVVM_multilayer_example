using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BM.MultiLayer.Data.Repositories.Contracts;

namespace DM.MultiLayer.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetAll()
        {
            return new[]
            {
                new Person(1,"Simon","To", 30),
                new Person(2,"Peter","Hase", 27),
                new Person(3,"Mall","Function", 1),
            };
        }
    }
}
