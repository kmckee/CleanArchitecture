using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace CleanArchitecture.IOC
{
    public class ApplicationKernel : StandardKernel
    {
        public ApplicationKernel() 
            : base(
                new CommonModule()
                // Additional Modules are added here.
            )
        { }
    }
}
