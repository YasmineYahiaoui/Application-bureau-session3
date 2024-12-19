using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using amira_kenza_yasmineUA2.commands;
using amira_kenza_yasmineUA2.Models;


namespace amira_kenza_yasmineUA2.ViewModels
{
    public class AjouterDocumentViewModel:ViewModelBase
    {
        private List<Document> _listeDocuments;
        public List<Document> ListeDocuments
        {
            get { return _listeDocuments; }
            set
            {
                _listeDocuments = value;
                OnPropertyChanged(nameof(ListeDocuments));
            }
        }
        private string _titre;
        public string Titre
        {
            get
            {
                return _titre;
            }
            set
            {
                _titre = value;
                OnPropertyChanged(nameof(Titre));
            }
        }

        private string _auteur;
        public string Auteur
        {
            get
            {
                return _auteur;
            }
            set
            {
                _auteur = value;
                OnPropertyChanged(nameof(Auteur));
            }
        }

        private string _année;
        public string Année
        {
            get
            {
                return _année;
            }
            set
            {
                _année = value;
                OnPropertyChanged(nameof(Année));
            }
        }

     

        public ICommand BoutonAJouter { get; }

        public AjouterDocumentViewModel()
        {
            BoutonAJouter = new AjouterDocumentCommand(this);
        }
        public void ChargerDocuments()
        {
            using (var context = new MyDbContext())
            {
                ListeDocuments = context.Document.ToList();
            }
        }

    }
}
