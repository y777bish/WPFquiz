using QuizOstateczny.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace QuizOstateczny.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ObservableCollection<Quest> QuestList { get; set; }

        public ViewModel()
        {
            QuestList = new ObservableCollection<Quest>();
        }

        private ICommand dodajPytanie;
        public ICommand DodajPytanie
        {
            get
            {
                if (dodajPytanie == null)
                    dodajPytanie = new RelayCommand(
                    Quest nowy = new Quest
                    );
                return dodajPytanie;
            }
        }

        private string pytanie = "";
        public string Pytanie
        {
            get => pytanie;
            set
            {
                pytanie = value;
                //zgłoszenie zmiany wartości
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Pytanie));
            }
        }

        private string odp1 = "";
        private string odp2 = "";
        private string odp3 = "";
        private string odp4 = "";
    }
}