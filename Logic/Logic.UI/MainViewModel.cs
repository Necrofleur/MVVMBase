using GalaSoft.MvvmLight;

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
                WindowTitle = "LaufzeitModus";
            }
        }

        public string WindowTitle
        {
            get;
            set;
        }
    }
}