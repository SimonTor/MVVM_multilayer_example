
using BM.MultiLayer.CrossCutting.Logging.Contracts;
using BM.MultiLayer.Data.Repositories.Contracts;
using BM.MultiLayer.Logic.PersonMangement.Contacts;
using DM.MultiLayer.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DM.MutliLayer.Logic.PersonManagement
{
    public class AnimalManager : IAnimalManager
    {
        public IAnimalRepository Repository { get; set; }
        public ILogger Logger { get; set; }


        public AnimalManager(IAnimalRepository animalRepository, ILogger logger)
        {
            Repository = animalRepository;
            Logger = logger;
        }

        public IEnumerable<Animal> GetAll()
        {
            return Repository.GetAll();
        }

        public IEnumerable<Animal> GetAllAdults()
        {
            return Repository.GetAll().Where(p => p.Age >= 18);
        } 
    }
}
