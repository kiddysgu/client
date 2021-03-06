﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Live.Client.Core
{
    public class AutofacLocator : IAutoFacLocator
    {
        IContainer container;

        public TInterface Get<TInterface>(string typeName)
        {
            return container.ResolveNamed<TInterface>(typeName);
        }

        public TInterface Get<TInterface>()
        {
            return container.Resolve<TInterface>();
        }

        public void Register()
        {
            var Container = new ContainerBuilder();
            Assembly asm = Assembly.GetExecutingAssembly();
            RegisterByAssembly(asm, ref Container);  
            //Container.RegisterType<MsgDlg>().As<IShowContent>();

            container = Container.Build();
        }

        private void RegisterByAssembly(Assembly asm, ref ContainerBuilder Container)
        {
            var types = asm.GetTypes();
            foreach (var t in types)
            {
                var attr = (AutofacAttribute)t.GetCustomAttribute(typeof(AutofacAttribute), false);
                if (attr != null && attr.Allow)
                {
                    var interfaceDefault = t.GetInterfaces().FirstOrDefault();
                    if (interfaceDefault != null)
                    {
                        Container.RegisterType(t).Named(t.Name, interfaceDefault);
                    }
                }
            }
        }

    }
}
