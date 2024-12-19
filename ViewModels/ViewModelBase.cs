using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amira_kenza_yasmineUA2.ViewModels
{
    public class ViewModelBase: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// permet de notifier le changement de valeur d'une propriété
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            // si il y a des abonnés à l'événement PropertyChanged
            // alors on les notifie du changement de valeur de la propriété propertyName 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
