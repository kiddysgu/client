using Live.Client.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Live.Client
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //this.ConfigureServices();
            //var dialog = ServiceProvider.Instance.Get<IModelDialog>("LoginViewDlg");
            //dialog.BindDefaultViewModel();
            //dialog.ShowDialog();
        }

        protected void ConfigureServices()
        {
            AutofacLocator autofacLocator = new AutofacLocator();  //创建IOC容器
            autofacLocator.Register();   //注册服务
            BootStrapper.Initialize(autofacLocator);
        }
    }
}
