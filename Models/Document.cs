using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amira_kenza_yasmineUA2.Models
{
    public class Document
    {

        [Key]
        public int ISBN { get; set; } // Identifiant unique du document
        public string Titre { get; set; } // Titre du document
        public string Auteur { get; set; } // Auteur du document
        public string Année { get; set; } // Date de publication du document
        

        public Document() { }

        // Constructeur pour initialiser le document
        public Document(int isbn, string titre, string auteur, string année )
        {
            ISBN = isbn;
            Titre = titre;
            Auteur = auteur;
            Année = année;
            
        }
    }

}
