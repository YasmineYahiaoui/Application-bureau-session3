using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace amira_kenza_yasmineUA2
{
    public partial class ModifierDocument : UserControl
    {
        private List<(string ISBN, string Titre, string Auteur, int Annee)> livresList;
        private string isbn;

        public ModifierDocument(List<(string ISBN, string Titre, string Auteur, int Annee)> livresList, string isbn)
        {
            InitializeComponent();
            this.livresList = livresList;
            this.isbn = isbn;

            // Charger les informations du livre correspondant à l'ISBN
            var livre = livresList.FirstOrDefault(l => l.ISBN == isbn);
            if (livre != default)
            {
                ISBNTextBox.Text = livre.ISBN;
                TitreTextBox.Text = livre.Titre;
                AuteurTextBox.Text = livre.Auteur;
                AnneeTextBox.Text = livre.Annee.ToString();
            }
            else
            {
                MessageBox.Show("Livre introuvable.");
            }
        }

        private void EnregistrerModifications_Click(object sender, RoutedEventArgs e)
        {
            var livre = livresList.FirstOrDefault(l => l.ISBN == isbn);
            if (livre != default)
            {
                // Mettre à jour les informations du livre
                livresList.Remove(livre);
                livresList.Add((
                    ISBN: ISBNTextBox.Text,
                    Titre: TitreTextBox.Text,
                    Auteur: AuteurTextBox.Text,
                    Annee: int.Parse(AnneeTextBox.Text)
                ));

                MessageBox.Show("Modifications enregistrées avec succès !");
            }
            else
            {
                MessageBox.Show("Erreur : le livre n'a pas pu être modifié.");
            }
        }
    }
}
