using amira_kenza_yasmineUA2.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using amira_kenza_yasmineUA2.commands;

namespace amira_kenza_yasmineUA2.ViewModels
{
    public class AjouterAdherentsViewModel : ViewModelBase
    {
        private string _id;
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        private string _nom;
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
                OnPropertyChanged(nameof(Nom));
            }
        }

        private string _prénom;
        public string Prénom
        {
            get
            {
                return _prénom;
            }
            set
            {
                _prénom = value;
                OnPropertyChanged(nameof(Prénom));
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ICommand BoutonAJouter { get; }

        public AjouterAdherentsViewModel()
        {
            BoutonAJouter = new AjouterAdherentCommand(this);
        }
    }
}
