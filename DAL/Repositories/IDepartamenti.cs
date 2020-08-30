using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IDepartamenti
    {
        Task<IEnumerable<Departamenti>> GetDepartamentAll();
        Task<Departamenti> GetDepartamnetById(int? departamentId);
        Task CreteDepartamentAsync(Departamenti departamentiDTO);
        Task UpdateDepartamentAsync(Departamenti departamentiDTO);
        Task Delete(Departamenti departamentiDTO);
    }
}
