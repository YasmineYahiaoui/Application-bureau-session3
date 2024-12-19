using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace amira_kenza_yasmineUA2
{
    public partial class ModifierAdherents : UserControl
    {
        private List<(string ID, string Nom, string Prenom, string Email)> adherentsList;
        private Adherents adherentsControl;

        public ModifierAdherents(List<(string ID, string Nom, string Prenom, string Email)> adherents, Adherents adherentsControl)
        {
            InitializeComponent();
            adherentsList = adherents;
            this.adherentsControl = adherentsControl;
        }

        public void LoadAdherent(string id)
        {
            var adherent = adherentsList.Find(a => a.ID == id);
            if (adherent.ID != null)
            {
                IDTextBox.Text = adherent.ID;
                NomTextBox.Text = adherent.Nom;
                PrenomTextBox.Text = adherent.Prenom;
                EmailTextBox.Text = adherent.Email;
            }
            else
            {
                MessageBox.Show("Adhérent non trouvé.");
            }
        }

        private void ModifierAdherent_Click(object sender, RoutedEventArgs e)
        {
            string id = IDTextBox.Text;
            string nom = NomTextBox.Text;
            string prenom = PrenomTextBox.Text;
            string email = EmailTextBox.Text;

            var index = adherentsList.FindIndex(a => a.ID == id);
            if (index != -1)
            {
                adherentsList[index] = (id, nom, prenom, email);
                MessageBox.Show($"Adhérent modifié: ID={id}, Nom={nom}, Prénom={prenom}, Email={email}");

                // Rafraîchir le DataGrid en utilisant la référence de Adherents
                adherentsControl.RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification: Adhérent non trouvé.");
            }
        }
    }
}
