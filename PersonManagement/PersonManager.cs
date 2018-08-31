using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.MultiLayer.Data.Repositories;
using BM.MultiLayer.CrossCutting.Logging.Contracts;
using BM.MultiLayer.Data.Repositories.Contracts;
using BM.MultiLayer.Logic.PersonMangement.Contacts;

namespace DM.MutliLayer.Logic.PersonManagement
{
    public class PersonManager : IPersonManager
    {
        public IPersonRepository Repository { get; set; }
        public ILogger Logger { get; set; }


        public PersonManager(IPersonRepository personRepository, ILogger logger)
        {
            Repository = personRepository;
            Logger = logger;
        }

        public IEnumerable<Person> GetAll()
        {
            return Repository.GetAll();
        }

        public IEnumerable<Person> GetAllAdults()
        {
            return Repository.GetAll().Where(p => p.Age >= 18);
        } 
    }
}
