using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Service;
using Accounting.DataLayer;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        
        private Accounting_ProjectEntities _DB = new Accounting_ProjectEntities();


        private GenericRepository<Customers> _CustomerRepository;
        public GenericRepository<Customers> CustomerRepository
        {
            get
            {
                if (_CustomerRepository == null)
                {
                    _CustomerRepository = new GenericServices<Customers>(_DB);
                }
                return _CustomerRepository;
            }
        }
        private GenericRepository<Accounting> _AccountingRepository;
        public GenericRepository<Accounting> AccountingRepository => _AccountingRepository = new GenericServices<Accounting>(_DB);

        public void saveChange()
        {
            _DB.SaveChanges();
        }

        public void Dispose()
        {
            _DB.Dispose();
        }
    }
}
