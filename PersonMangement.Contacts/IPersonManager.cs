using DM.MultiLayer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.MultiLayer.Logic.PersonMangement.Contacts
{
    public interface IPersonManager
    {
        IEnumerable<Person> GetAll();
        IEnumerable<Person> GetAllAdults();
    }
}
