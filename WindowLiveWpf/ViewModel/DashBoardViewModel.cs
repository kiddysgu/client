using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live.Client.ViewModel
{
    public class UserModule
    {
        public string FilePath { get; set; }

        public string UserName { get; set; }

        public string Content { get; set; }

        public string SignTime { get; set; }
    }


    public class DashBoardViewModel: ViewModelBase
    {
        public DashBoardViewModel()
        {
            InitUserModuleBar();
        }

        public ObservableCollection<UserModule> UserModules { get; set; }

        private void InitUserModuleBar()
        {
            UserModules = new ObservableCollection<UserModule>();
            UserModules.Add(new UserModule() { FilePath = "/image/Image1.jpg", UserName = "James Bloor", Content = "What's up", SignTime = "32 min" });
            UserModules.Add(new UserModule() { FilePath = "/image/Image2.jpg", UserName = "Fionn Withehead", Content = "Nice one", SignTime = "2 days" });
            UserModules.Add(new UserModule() { FilePath = "/image/Image3.jpg", UserName = "Damien Bonnard", Content = "Go on in comi", SignTime = "1 weeks" });
            UserModules.Add(new UserModule() { FilePath = "/image/Image4.jpg", UserName = "Aneurin Barnard", Content = "I am coming", SignTime = "2 weeks" });
            UserModules.Add(new UserModule() { FilePath = "/image/Image5.jpg", UserName = "James Bloor", Content = "What's up", SignTime = "32 min" });
            UserModules.Add(new UserModule() { FilePath = "/image/Image6.jpg", UserName = "Fionn Withehead", Content = "Nice one", SignTime = "2 days" });
            UserModules.Add(new UserModule() { FilePath = "/image/Image7.jpg", UserName = "Damien Bonnard", Content = "Go on in comi", SignTime = "1 weeks" });
            UserModules.Add(new UserModule() { FilePath = "/image/Image8.jpg", UserName = "Aneurin Barnard", Content = "I am coming", SignTime = "2 weeks" });
        }
    }
}
