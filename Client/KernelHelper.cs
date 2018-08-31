using BM.MultiLayer.Infrastructure.DepenendencyInjection;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class KernelHelper
    {
        public static StandardKernel Kernel { get; private set;}

        static KernelHelper()
        {
            Kernel = new StandardKernel(MappingsAggregator.Mappings);
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
