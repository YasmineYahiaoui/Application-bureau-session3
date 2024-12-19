using System;
using System.Collections.Generic;
using System.Windows;
using amira_kenza_yasmineUA2.ViewModels;

namespace amira_kenza_yasmineUA2
{
    public partial class HomePage : Window
    {
        private List<(string ISBN, string Titre, string Auteur, int Annee)> livresList;
        private List<(string ID, string Nom, string Prenom, string Email)> adherentsList;

        public HomePage()
        {
            InitializeComponent();
            livresList = new List<(string ISBN, string Titre, string Auteur, int Annee)>
                {
                    // Livres d'exemple
                    ("978-3-16-148410-0", "Le Livre de la Jungle", "Rudyard Kipling", 1894),
                    ("978-0-7432-7356-5", "1984", "George Orwell", 1949),
                    ("978-0-452-28423-4", "Fahrenheit 451", "Ray Bradbury", 1953)
                };

            adherentsList = new List<(string ID, string Nom, string Prenom, string Email)>
                {
                    // Adhérents d'exemple
                    ("1", "Dupont", "Jean", "jean.dupont@example.com"),
                    ("2", "Martin", "Marie", "marie.martin@example.com"),
                    ("3", "Durand", "Paul", "paul.durand@example.com")
                };

            // Charge le UserControl pour afficher les documents par défaut
            MainContent.Content = new Documents { DataContext = new DocumentViewModel { LivresList = livresList } };
        }

        private void Ajouterad_Click(object sender, RoutedEventArgs e)
        {
            var ajouterAdherents = new AjouterAdherents(adherentsList, new Adherents(adherentsList));
            MainContent.Content = ajouterAdherents; // Charge le UserControl d'ajout d'adhérents
        }

        private void Modifierad_Click(object sender, RoutedEventArgs e)
        {
            // Demande à l'utilisateur l'ID de l'adhérent à modifier
            string idToModify = Microsoft.VisualBasic.Interaction.InputBox("Entrez l'ID de l'adhérent à modifier :", "Modifier Adhérent", "1");

            if (!string.IsNullOrEmpty(idToModify))
            {
                // Créez une instance de ModifierAdherents et chargez l'adhérent
                ModifierAdherents modifierAdherents = new ModifierAdherents(adherentsList, new Adherents(adherentsList));
                modifierAdherents.LoadAdherent(idToModify); // Chargez les informations de l'adhérent
                MainContent.Content = modifierAdherents; // Affiche le UserControl de modification
            }
            else
            {
                MessageBox.Show("Veuillez entrer un ID valide.");
            }
        }

        private void Ajouterdoc_Click(object sender, RoutedEventArgs e)
        {
            var documents = MainContent.Content as Documents;
            if (documents != null)
            {
                AjouterDocuments ajouterDocuments = new AjouterDocuments(livresList, documents);
                MainContent.Content = ajouterDocuments; // Charge le UserControl d'ajout de documents
            }
            else
            {
                MessageBox.Show("Erreur : le contrôle Documents n'est pas chargé.");
            }
        }

        private void Modifierdoc_Click(object sender, RoutedEventArgs e)
        {
            string isbn = Microsoft.VisualBasic.Interaction.InputBox("Entrez l'ISBN du livre à modifier :", "Modifier Livre", "978-0-7432-7356-5");

            if (!string.IsNullOrEmpty(isbn))
            {
                ModifierDocument modifierDocument = new ModifierDocument(livresList, isbn);
                MainContent.Content = modifierDocument;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un ISBN valide.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Affiche le UserControl des documents
            MainContent.Content = new Documents { DataContext = new DocumentViewModel { LivresList = livresList } };
        }

        private void AfficherAdherents_Click(object sender, RoutedEventArgs e)
        {
            // Affiche le UserControl des adhérents
            var adherentsControl = new Adherents(adherentsList);
            MainContent.Content = adherentsControl;
        }
    }
}
