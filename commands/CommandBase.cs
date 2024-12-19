using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using amira_kenza_yasmineUA2.commands;


namespace amira_kenza_yasmineUA2.commands
{
    public abstract class CommandBase : ICommand
    {
        // Permet de gérer les événements
        public event EventHandler? CanExecuteChanged;

        // Permet de savoir si la commande peut être exécutée
        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        // Permet d'exécuter la commande et doit être implémentée dans les classes filles
        public abstract void Execute(object? parameter);

        // Permet de notifier que la commande peut être exécutée
        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
