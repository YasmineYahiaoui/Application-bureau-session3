using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amira_kenza_yasmineUA2.Models;
using Microsoft.EntityFrameworkCore;

namespace amira_kenza_yasmineUA2.Services
{
    public class DocumentService : ServiceBase
    {
        public async void AjouterDocument(Document document)
        {
            await Context.Document.AddAsync(document);
            await Context.SaveChangesAsync();
        }

        //Liste des documents
        public async Task<List<Document>> GetDocuments()
        {
            return await Context.Document.ToListAsync();
        }
    }
}
