using BM.MultiLayer.Data.Repositories.Contracts;
using DM.MultiLayer.Data.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.MultiLayer.Infrastructure.DepenendencyInjection.Data
{
    class RepositoriesMappings : NinjectModule
    {

        public override void Load()
        {
            Bind<IPersonRepository>().To<PersonRepository>();
            Bind<IAnimalRepository>().To<AnimalRepository>();
        }
    }
}
