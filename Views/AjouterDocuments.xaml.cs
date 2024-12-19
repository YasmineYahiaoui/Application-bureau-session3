using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace amira_kenza_yasmineUA2
{
    public partial class AjouterDocuments : UserControl
    {
        private List<(string ISBN, string Titre, string Auteur, int Annee)> livresList;
        private Documents documentsControl;

        public AjouterDocuments(List<(string ISBN, string Titre, string Auteur, int Annee)> livres, Documents documents)
        {
            InitializeComponent();
            livresList = livres;
            documentsControl = documents;
        }

        private void AjouterLivre_Click(object sender, RoutedEventArgs e)
        {
            string isbn = ISBNTextBox.Text;
            string titre = TitreTextBox.Text;
            string auteur = AuteurTextBox.Text;

            if (int.TryParse(AnneeTextBox.Text, out int annee))
            {
                livresList.Add((isbn, titre, auteur, annee));
                Console.WriteLine($"Livre ajouté: ISBN={isbn}, Titre={titre}, Auteur={auteur}, Année={annee}");

                // Rafraîchir le DataGrid en utilisant la référence de Documents
                documentsControl.RefreshDataGrid();

                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une année valide.");
            }
        }

        private void ClearInputFields()
        {
            ISBNTextBox.Clear();
            TitreTextBox.Clear();
            AuteurTextBox.Clear();
            AnneeTextBox.Clear();
        }
    }
}
