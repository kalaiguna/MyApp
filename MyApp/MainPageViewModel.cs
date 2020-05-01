using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            Keys = new ObservableCollection<string>();
            SaveCommand = new Command(() =>
            {
                Keys.Add(Key);
                Key = string.Empty;
            });
            DeleteCommand = new Command(() =>
            {
                Key = string.Empty;
            });
        }
        private string key;
        public string Key
        {
            get { return key; }
            set
            {
                key = value;
                OnPropertyRaised("Key");
            }
        }
        //private ObservableCollection<string> keys;
        public ObservableCollection<string> Keys
        {
            get; set;
        }
        //    get { return keys; }
        //    set
        //    {
        //        //keys.Add(value);
        //        OnPropertyRaised("Keys");
        //    }
        //}
        public Command SaveCommand { get; }
        public Command DeleteCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
