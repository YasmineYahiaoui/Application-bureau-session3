using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amira_kenza_yasmineUA2.Models
{
    public class ModifierDocument
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public DateTime DatePublication { get; set; }
        public string Description { get; set; }

        public ModifierDocument() { }

        // Constructeur pour modifier un document
        public ModifierDocument(int id, string titre, string auteur, DateTime datePublication, string description)
        {
            Id = id;
            Titre = titre;
            Auteur = auteur;
            DatePublication = datePublication;
            Description = description;
        }
    }

}
