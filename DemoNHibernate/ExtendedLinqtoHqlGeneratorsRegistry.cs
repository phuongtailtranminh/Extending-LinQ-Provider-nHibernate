using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq.Functions;

namespace DemoNHibernate
{
    public class ExtendedLinqtoHqlGeneratorsRegistry : DefaultLinqToHqlGeneratorsRegistry
    {
        public ExtendedLinqtoHqlGeneratorsRegistry()
        {
            this.Merge(new TrimGenerator());
        }
    }
}
