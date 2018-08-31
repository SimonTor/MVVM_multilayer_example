using BM.MultiLayer.CrossCutting.Logging;
using BM.MultiLayer.CrossCutting.Logging.Contracts;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.MultiLayer.Infrastructure.DepenendencyInjection.CrossCutting
{
    class LoggingMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<Logger>();
        }
    }
}
