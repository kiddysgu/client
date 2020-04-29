﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live.Client.Core
{
    public interface IAutoFacLocator
    {
        void Register();

        TInterface Get<TInterface>();

        TInterface Get<TInterface>(string typeName);

    }
}
