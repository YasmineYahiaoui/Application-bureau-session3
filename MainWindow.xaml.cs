
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace amira_kenza_yasmineUA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Connecter_Click(object sender, RoutedEventArgs e)
        {
            // Check credentials
            if (NomUser.Text == "admin" && MotDePasse.Password == "admin")
            {
                // Open HomePage window
                HomePage homePage = new HomePage();
                homePage.Show();

                // Close the login window if necessary
                this.Close();
            }
            else
            {
                // Display error message if credentials are incorrect
                erreur.Content = "Nom d'utilisateur ou mot de passe incorrect.";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}