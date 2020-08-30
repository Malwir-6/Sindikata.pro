using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SindikataRepo : Repository<Sindikata>, ISindikata
    {
        public SindikataRepo(ApplicationDbContext context) : base(context) { }
        private ApplicationDbContext _appcontext => (ApplicationDbContext)_context;
        public async Task CreteSindikataAsync(Sindikata sindikataDTO)
        {
            await _appcontext.Sindikatas.AddAsync(sindikataDTO);
            await _appcontext.SaveChangesAsync();
        }

        public async Task Delete(Sindikata sindikataDTO)
        {
            _appcontext.Sindikatas.Remove(sindikataDTO);
            await _appcontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Sindikata>> GetSindikata()
        {
          return await _appcontext.Sindikatas.ToListAsync();
        }

        public async Task<Sindikata> GetSindikataById(int? sindikataId)
        {
            return await _appcontext.Sindikatas.FindAsync(sindikataId);
        }

        public async Task UpdateSindikataAsync(Sindikata sindikataDTO)
        {
            _appcontext.Sindikatas.Update(sindikataDTO);
            await _appcontext.SaveChangesAsync();
        }
    }
}
