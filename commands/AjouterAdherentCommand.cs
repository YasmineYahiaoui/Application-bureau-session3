using amira_kenza_yasmineUA2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using amira_kenza_yasmineUA2.Services;
using amira_kenza_yasmineUA2.Models;




namespace amira_kenza_yasmineUA2.commands
{
    public class AjouterAdherentCommand : CommandBase
    {
        private readonly AjouterAdherentsViewModel _ajouterAdherentsViewModel;

        public AjouterAdherentCommand(AjouterAdherentsViewModel ajouterAdherentsViewModel)
        {
            _ajouterAdherentsViewModel = ajouterAdherentsViewModel;

            //Apres avoir ajouter CanExecute et utiliser Alt+Enter pour générer la méthode onViewModelPropertyChanged
            _ajouterAdherentsViewModel.PropertyChanged += onViewModelPropertyChanged;
        }

        //Apres avoir ajouter CanExecute et utiliser Alt+Enter pour générer la méthode onViewModelPropertyChanged
        private void onViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(AjouterAdherentsViewModel.ID) || e.PropertyName == nameof(AjouterAdherentsViewModel.Nom) || 
                e.PropertyName == nameof(AjouterAdherentsViewModel.Prénom) || e.PropertyName == nameof(AjouterAdherentsViewModel.Email))

            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            string ID = _ajouterAdherentsViewModel.ID;
            string Nom = _ajouterAdherentsViewModel.Nom;
            String Prénom = _ajouterAdherentsViewModel.Prénom;
            String Email= _ajouterAdherentsViewModel.Email;

            return !string.IsNullOrWhiteSpace( ID) &&
                     !string.IsNullOrWhiteSpace(Nom) &&
                     !string.IsNullOrWhiteSpace(Prénom) &&
                     !string.IsNullOrWhiteSpace(Email) &&
                     base.CanExecute(parameter);
        }



        public override void Execute(object? parameter)
        {
            try
            {
                // Implémentation pour ajouter un document
                Console.WriteLine("Adherent ajouté avec succès !");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'ajout d'adherent : {ex.Message}");
            }

            // Réinitialisation des champs
            _ajouterAdherentsViewModel.ID = "";
            _ajouterAdherentsViewModel.Nom="";
            _ajouterAdherentsViewModel.Prénom = "";
            _ajouterAdherentsViewModel.Email = "";
        }
    }
}

