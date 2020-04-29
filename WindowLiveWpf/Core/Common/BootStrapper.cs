using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live.Client.Core
{
    public class BootStrapper
    {
        public static void Initialize(IAutoFacLocator autoFacLocator)
        {
            ServiceProvider.RegisterServiceLocator(autoFacLocator);
            ServiceProvider.Instance.Register();
        }
    }
}
