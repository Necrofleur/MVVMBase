using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Logic.UI;
using UI.Desktop;

namespace Logic.UI
{
   public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            if (IsInDesignMode)
            {
                TitleLogin = "DesignModus";
            }
            else
            {
                if (TitleLogin == null || TitleLogin == "")
                {
                    TitleLogin = "LaufzeitModus";
                }
                else
                {
                    SetWindowTitle(TitleLogin);
                }
            }
        }
        public void SetWindowTitle(string windowTitle)
        {
            TitleLogin = windowTitle;
        }

        #region Properties

        private string _TitleLogin;
        public string TitleLogin
        {
            get
            {
                return _TitleLogin;
            }
            set
            {
                _TitleLogin = value;
                RaisePropertyChanged("TitleLogin");
            }
        }
        #endregion
        #region Relaycommands
        private ICommand _Login;
        public ICommand Login
        {
            get
            {
                if (_Login == null)
                {
                    _Login = new RelayCommand(() =>
                    {
                        SetWindowTitle(TitleLogin);
                    });
                }
                return _Login;
            }
        }
        #endregion
    }
}
