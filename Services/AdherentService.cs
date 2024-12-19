using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amira_kenza_yasmineUA2.Models;
using Microsoft.EntityFrameworkCore;

namespace amira_kenza_yasmineUA2.Services
{
    public class AdherentService : ServiceBase
    {
        public async void AjouterAdherent (Adherent adherent)
        {
            await Context.Adherent.AddAsync(adherent);
            await Context.SaveChangesAsync();
        }

        //Liste des documents
        public async Task<List<Adherent>> GetDocuments()
        {
            return await Context.Adherent.ToListAsync();
        }
    }
}
