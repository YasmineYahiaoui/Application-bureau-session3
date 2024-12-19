using System.ComponentModel;

namespace amira_kenza_yasmineUA2.ViewModels
{
    public class AdherentsViewModel : ViewModelBase
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Nom
        {
            get => nom;
            set
            {
                nom = value;
                OnPropertyChanged(nameof(Nom));
            }
        }

        public string Prenom
        {
            get => prenom;
            set
            {
                prenom = value;
                OnPropertyChanged(nameof(Prenom));
            }
        }

        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
