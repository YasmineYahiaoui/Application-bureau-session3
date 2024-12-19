using amira_kenza_yasmineUA2.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace amira_kenza_yasmineUA2
{
    public partial class Documents : UserControl
    {
        private MainViewModel _viewModel;

        public Documents()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            DataContext = _viewModel;
        }
     

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchBox.Text.ToLower();
            var results = _viewModel.Documents//livresList
                .Where(livre => livre.Titre.ToLower().Contains(searchTerm) || livre.Auteur.ToLower().Contains(searchTerm)).ToList();
               

            if (results.Count > 0)
            {
                BooksDataGrid.ItemsSource = results; // Met à jour le DataGrid avec les résultats de recherche
            }
            else
            {
                MessageBox.Show("Aucun livre trouvé avec ce titre ou cet auteur.");
                BooksDataGrid.ItemsSource = _viewModel.Documents;//livresList.Select(livre => new
               
            }
        }
        public void RefreshDataGrid()
        {
            BooksDataGrid.ItemsSource = null;
            BooksDataGrid.ItemsSource = _viewModel.Livres;
        }
       
    }
}
