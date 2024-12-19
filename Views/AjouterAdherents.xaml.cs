using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace amira_kenza_yasmineUA2
{
    public partial class AjouterAdherents : UserControl
    {
        private List<(string ID, string Nom, string Prenom, string Email)> adherentsList;
        private Adherents adherentsControl;

        public AjouterAdherents(List<(string ID, string Nom, string Prenom, string Email)> adherents, Adherents adherentsControl)
        {
            InitializeComponent();
            adherentsList = adherents;
            this.adherentsControl = adherentsControl;
        }

        private void AjouterAdherent_Click(object sender, RoutedEventArgs e)
        {
            string id = IDTextBox.Text;
            string nom = NomTextBox.Text;
            string prenom = PrenomTextBox.Text;
            string email = EmailTextBox.Text;

            adherentsList.Add((id, nom, prenom, email));
            MessageBox.Show($"Adhérent ajouté: ID={id}, Nom={nom}, Prénom={prenom}, Email={email}");

            // Rafraîchir le DataGrid en utilisant la référence de Adherents
            adherentsControl.RefreshDataGrid();

            ClearInputFields();
        }

        private void ClearInputFields()
        {
            IDTextBox.Clear();
            NomTextBox.Clear();
            PrenomTextBox.Clear();
            EmailTextBox.Clear();
        }
    }
}
