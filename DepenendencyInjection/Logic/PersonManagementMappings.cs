using BM.MultiLayer.Logic.PersonMangement.Contacts;
using DM.MutliLayer.Logic.PersonManagement;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.MultiLayer.Infrastructure.DepenendencyInjection.Logic
{
    class PersonManagementMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonManager>().To<PersonManager>();
            Bind<IAnimalManager>().To<AnimalManager>();
        }
    }
}
