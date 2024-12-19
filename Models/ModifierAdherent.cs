using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amira_kenza_yasmineUA2.Models
{
    public class ModifierAdherent
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public ModifierAdherent() { }

        // Constructeur pour modifier un adhérent
        public ModifierAdherent(int id, string nom, string prenom, string adresse, string telephone, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Telephone = telephone;
            Email = email;
        }
    }

}
