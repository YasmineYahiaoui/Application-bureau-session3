using System;
using System.ComponentModel;

namespace amira_kenza_yasmineUA2.ViewModels
{
    public class DocumentViewModel : ViewModelBase
    {
        private int isbn;
        private string titre;
        private string auteur;
        private string année;

        public int ISBN
        {
            get => isbn;
            set
            {
                isbn = value;
                OnPropertyChanged(nameof(ISBN));
            }
        }

        public string Titre
        {
            get => titre;
            set
            {
                titre = value;
                OnPropertyChanged(nameof(Titre));
            }
        }

        public string Auteur
        {
            get => auteur;
            set
            {
                auteur = value;
                OnPropertyChanged(nameof(Auteur));
            }
        }

        public string Année
        {
            get => année;
            set
            {
                année = value;
                OnPropertyChanged(nameof(Année));
            }
        }

        public List<(string ISBN, string Titre, string Auteur, int Annee)> LivresList { get; internal set; } = new List<(string ISBN, string Titre, string Auteur, int Annee)>();

        public DocumentViewModel()
        {
            titre = string.Empty;
            auteur = string.Empty;
            année = string.Empty;
        }
    }
}
