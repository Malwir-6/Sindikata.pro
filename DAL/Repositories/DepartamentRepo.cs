using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DepartamentRepo : Repository<Departamenti>, IDepartamenti
    {
        public DepartamentRepo(ApplicationDbContext context):base(context){}
        private ApplicationDbContext _appcontext => (ApplicationDbContext)_context;
        public async Task CreteDepartamentAsync(Departamenti departamentiDTO)
        {
            await _appcontext.Departamenti.AddAsync(departamentiDTO);
            await _appcontext.SaveChangesAsync();
        }

        public async Task Delete(Departamenti departamentiDTO)
        {
              _appcontext.Departamenti.Remove(departamentiDTO);
            await _appcontext.SaveChangesAsync();

        }

        public async Task<IEnumerable<Departamenti>> GetDepartamentAll()
        {
            return await _appcontext.Departamenti.ToListAsync();
        }

        public async Task<Departamenti> GetDepartamnetById(int? departamentId)
        {
            return await _appcontext.Departamenti.FindAsync(departamentId);
        }

        public async Task UpdateDepartamentAsync(Departamenti departamentiDTO)
        {
            _appcontext.Departamenti.Update(departamentiDTO);
            await _appcontext.SaveChangesAsync();
        }
    }
}
