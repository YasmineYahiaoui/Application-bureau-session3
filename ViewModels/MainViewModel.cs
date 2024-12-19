using amira_kenza_yasmineUA2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace amira_kenza_yasmineUA2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<DocumentViewModel> _documents;
        private ObservableCollection<Adherent> _adherents;

        public ObservableCollection<DocumentViewModel> Documents
        {
            get => _documents;
            set
            {
                _documents = value;
                OnPropertyChanged(nameof(Documents));
            }
        }
        public ObservableCollection<Adherent> Adherents
        {
            get => _adherents;
            set
            {
                _adherents = value;
                OnPropertyChanged(nameof(Adherents));
            }
        }

        public IEnumerable? Livres { get; internal set; }

        public MainViewModel()
        {
            _documents = new ObservableCollection<DocumentViewModel>();
            _adherents = new ObservableCollection<Adherent>();
            ChargerDocuments();
            ChargerAdherents();
        }

        private void ChargerDocuments()
        {
            // Code pour charger les documents
            using (var context = new MyDbContext())
            {
                var documents = context.Document.ToList();

                Documents = new ObservableCollection<DocumentViewModel>(
                    documents.Select(d => new DocumentViewModel
                    {
                        ISBN = d.ISBN,
                        Titre = d.Titre,
                        Auteur = d.Auteur,
                        Année = d.Année

                    }));
            }
        }

        private void ChargerAdherents()
        {
            using (var context = new MyDbContext())
            {
                var adherents = context.Adherent.ToList();

                Adherents = new ObservableCollection<Adherent>(adherents);
            }
        }
        public class DocumentViewModel
        {
            public int ISBN { get; set; }
            public string Titre { get; set; }
            public string Auteur { get; set; }
            public string Année { get; set; }

        }
    }
    public class AdherentViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
    }

}
