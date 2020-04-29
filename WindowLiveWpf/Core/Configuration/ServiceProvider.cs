using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live.Client.Core
{
   public class ServiceProvider
    {
        public static IAutoFacLocator Instance { get; private set; }

        public static void RegisterServiceLocator(IAutoFacLocator s)
        {
            Instance = s;
        }
    }
}
