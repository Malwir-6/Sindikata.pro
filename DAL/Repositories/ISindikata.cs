using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface ISindikata
    {
        Task<IEnumerable<Sindikata>> GetSindikata();
        Task<Sindikata> GetSindikataById(int? sindikataId);
        Task CreteSindikataAsync(Sindikata sindikataDTO);
        Task UpdateSindikataAsync(Sindikata sindikataDTO);
        Task Delete(Sindikata sindikataDTO);

    }
}
