using BM.MultiLayer.Infrastructure.DepenendencyInjection.CrossCutting;
using BM.MultiLayer.Infrastructure.DepenendencyInjection.Data;
using BM.MultiLayer.Infrastructure.DepenendencyInjection.Logic;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.MultiLayer.Infrastructure.DepenendencyInjection
{
    public static class MappingsAggregator
    {
        public static INinjectModule[] Mappings
        {
            get
            {
                return new INinjectModule[]{
                    new RepositoriesMappings(),
                    new PersonManagementMappings(),
                    new LoggingMappings()
                };
            }
        }
    }
}
