using amira_kenza_yasmineUA2.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using amira_kenza_yasmineUA2.Models;

namespace amira_kenza_yasmineUA2
{
    public partial class Adherents : UserControl
    {
        private MainViewModel _viewModel;

        public Adherents(List<(string ID, string Nom, string Prenom, string Email)> adherentsList)
        {
            InitializeComponent();
           
            _viewModel = new MainViewModel();
            DataContext = _viewModel;
        }
   
        private static void Add(Adherent adherent)
        {
            throw new NotImplementedException();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel?.Adherents == null)
            {
                MessageBox.Show("Adherents data is not available.");
                return;
            }

            string searchTerm = SearchBox.Text.ToLower();
            var results = _viewModel.Adherents
                .OfType<Adherent>()
                .Where(adherent => adherent.Nom.ToLower().Contains(searchTerm) || adherent.Prenom.ToLower().Contains(searchTerm))
                .ToList();

            if (results.Count > 0)
            {
                AdherentsDataGrid.ItemsSource = results;
            }
            else
            {
                MessageBox.Show("Aucun adhérent trouvé avec ce nom ou ce prénom.");
                AdherentsDataGrid.ItemsSource = _viewModel.Adherents;
            }
        }


        public void RefreshDataGrid()
        {
            AdherentsDataGrid.ItemsSource = null;
            AdherentsDataGrid.ItemsSource = _viewModel.Adherents;
        }
    }
}