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
using System.Data;




namespace amira_kenza_yasmineUA2.commands
{
    public class AjouterDocumentCommand : CommandBase
    {
        private readonly AjouterDocumentViewModel _ajouterDocumentViewModel;

        public AjouterDocumentCommand(AjouterDocumentViewModel ajouterDocumentViewModel)
        {
            _ajouterDocumentViewModel = ajouterDocumentViewModel;

            //Apres avoir ajouter CanExecute et utiliser Alt+Enter pour générer la méthode onViewModelPropertyChanged
            _ajouterDocumentViewModel.PropertyChanged += onViewModelPropertyChanged;
        }

        //Apres avoir ajouter CanExecute et utiliser Alt+Enter pour générer la méthode onViewModelPropertyChanged
        private void onViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(AjouterDocumentViewModel.Titre) || 
                e.PropertyName == nameof(AjouterDocumentViewModel.Auteur) ||
                e.PropertyName == nameof(AjouterDocumentViewModel.Année) )

            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            string titre = _ajouterDocumentViewModel.Titre;
            string auteur = _ajouterDocumentViewModel.Auteur;
            string Année = _ajouterDocumentViewModel.Année;
            

            return !string.IsNullOrWhiteSpace(titre) &&
                     !string.IsNullOrWhiteSpace(auteur) &&
                     !string.IsNullOrWhiteSpace(Année) &&
                    
                     base.CanExecute(parameter);
        }

 

    public override void Execute(object? parameter)
        {
            try
            {
                // Implémentation pour ajouter un document
                Console.WriteLine("Document ajouté avec succès !");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'ajout du document : {ex.Message}");
            }

            // Réinitialisation des champs
            _ajouterDocumentViewModel.Titre = "";
            _ajouterDocumentViewModel.Auteur = "";
            _ajouterDocumentViewModel.Année = "";
            
        }
    } }

