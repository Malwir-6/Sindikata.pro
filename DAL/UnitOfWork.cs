using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {

        public readonly ApplicationDbContext _context;

        ISindikata _sindikata;
        IDepartamenti _departamenti;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }


        public ISindikata Sindikata {
            get
            {
                if (_sindikata == null)
                    _sindikata = new SindikataRepo(_context);
                return _sindikata;
            }
        }

        public IDepartamenti Departamenti {
            get
            {
                if (_departamenti == null)
                    _departamenti = new DepartamentRepo(_context);
                return _departamenti;
            }

        }

        public int SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}
