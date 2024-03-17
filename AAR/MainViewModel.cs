using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AAR
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private bool _isLoginFormVisible = true;
        private bool _isTripInfoVisible = false;

        public bool IsLoginFormVisible
        {
            get { return _isLoginFormVisible; }
            set { _isLoginFormVisible = value; OnPropertyChanged(); }
        }

        public bool IsTripInfoVisible
        {
            get { return _isTripInfoVisible; }
            set { _isTripInfoVisible = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
