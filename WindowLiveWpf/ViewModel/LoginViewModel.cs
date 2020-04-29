using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Live.Client.Core;
using System;
using System.Threading.Tasks;

namespace Live.Client.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private string report;

        public string Report
        {
            get { return report; }
            set { report = value; RaisePropertyChanged(); }
        }


        private string userName = string.Empty;

        public string UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(); }
        }


        private string passWord = string.Empty;

        public string Password
        {

            get { return passWord; }
            set { passWord = value; RaisePropertyChanged(); }
        }


        private bool rememberMe;

        public bool RememberMe
        {
            get { return rememberMe; }
            set { rememberMe = value; RaisePropertyChanged(); }
        }



        public void ReadConfigInfo()
        {

        }

        #region Binding Command

        private RelayCommand _signCommand;

        public RelayCommand SignCommand
        {
            get
            {
                if (_signCommand == null)
                {
                    _signCommand = new RelayCommand(() => Login());
                }
                return _signCommand;
            }
        }

        private RelayCommand _exitCommand;

        public RelayCommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                {
                    _exitCommand = new RelayCommand(() => ApplicationShutdown());
                }
                return _exitCommand;
            }
        }

        #endregion

        public async void Login()
        {
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                this.Report = "请输入用户名密码";
                return;
            }
            this.Report = "正在验证登录 . . .";
            var LoginTask = Task.Delay(3000);
            await Task.WhenAny(LoginTask);            
            this.Report = "加载用户信息 . . .";

            var dialog = ServiceProvider.Instance.Get<IModelDialog>("MainViewDlg");
            dialog.BindDefaultViewModel();
            Messenger.Default.Send(string.Empty, "ApplicationHiding");
            bool taskResult = await dialog.ShowDialog();
            this.ApplicationShutdown();

        }

        public void ApplicationShutdown()
        {
            Messenger.Default.Send("", "ApplicationShutdown");
        }
    }
}
