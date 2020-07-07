using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using UI.Desktop;

namespace UI.Desktop.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                WindowTitle = "DesignModus";
            }
            else
            {
                if (WindowTitle == null || WindowTitle == "")
                {
                    WindowTitle = "LaufzeitModus";
                }
                else
                {
                    SetWindowTitle(WindowTitle);
                }
            }
        }
        public void SetWindowTitle(string windowTitle)
        {
            WindowTitle = windowTitle;
        }

        #region Properties

        private string _WindowTitle;
        public string WindowTitle
        {
            get
            {
                return _WindowTitle;
            }
            set
            {
                _WindowTitle = value;
                RaisePropertyChanged("WindowTitle");
            }
        }
        #endregion
        #region Relaycommands
        private ICommand _Save;
        public ICommand Save
        {
            get
            {
                if(_Save == null)
                {
                    _Save = new RelayCommand(() =>
                    {
                        SetWindowTitle(WindowTitle);
                    });
                }
                return _Save;
            }
        }

        private ICommand _Login;
        public ICommand Login
        {
            get
            {
                if(_Login == null)
                {
                    _Login = new RelayCommand(() =>
                    {
                        
                    });
                }
                return Login;
            }
        }
#endregion
    }
}