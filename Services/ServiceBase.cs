using amira_kenza_yasmineUA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amira_kenza_yasmineUA2.Services
{
    public class ServiceBase
    {
        private readonly MyDbContext _context;
        public MyDbContext Context => _context;
        public ServiceBase()
        {
            _context = new MyDbContext();
        }
    }
}