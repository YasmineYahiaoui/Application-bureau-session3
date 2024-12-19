using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amira_kenza_yasmineUA2.Models
{
    public class Adherent
    {
        [Key]
        public int Id { get; set; } // Identifiant unique de l'adhérent
        public string Nom { get; set; } // Nom de l'adhérent
        public string Prenom { get; set; } // Prénom de l'adhérent
      
        public string Email { get; set; } // Adresse e-mail de l'adhérent
      

        public Adherent() { }

        // Constructeur pour initialiser l'adhérent
        public Adherent(int id, string nom, string prenom, string adresse, string telephone, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            
            Email = email;
        }
    }
}
