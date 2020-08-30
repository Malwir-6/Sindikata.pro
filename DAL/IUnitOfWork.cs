using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUnitOfWork
    {
        ISindikata Sindikata { get; }
        IDepartamenti Departamenti { get; }
        int SaveChange();
    }
}
