using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_app.ModelView;

namespace my_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SindikataController : ControllerBase
    {
        public IUnitOfWork _unitOfWork;
        public SindikataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/Sindikata
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _unitOfWork.Sindikata.GetSindikata());
        }

        // GET: api/Sindikata/5
        [HttpGet("{sindikataId}")]
        public async Task<IActionResult> GetAllById(int? sindikataId)
        {
            if (sindikataId != null)
            {
                var klienti = await _unitOfWork.Sindikata.GetSindikataById(sindikataId);
                if (klienti != null)
                {
                    return Ok(Mapper.Map<SindikataModelView>(klienti));
                }
                else
                {
                    return BadRequest("Diqka ka shkuar gabim");
                }
            }
            else
            {
                return BadRequest("Diqka ka shkuar gabim");
            }

        }

        // POST: api/Sindikata
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SindikataModelView sindikataDTO)
        {
            if (ModelState.IsValid)
            {
                var sindikata = Mapper.Map<Sindikata>(sindikataDTO);
                await _unitOfWork.Sindikata.CreteSindikataAsync(sindikata);
                return Ok(sindikata);

            }
            return BadRequest("Diqka ka shkuar gabim");
        }

        // PUT: api/Sindikata/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SindikataModelView sindikataDTO)
        {
            if (ModelState.IsValid)
            {
                var sindikata = Mapper.Map<Sindikata>(sindikataDTO);
                await _unitOfWork.Sindikata.UpdateSindikataAsync(sindikata);
                return Ok(sindikata);

            }
            return BadRequest("Diqka ka shkuar gabim");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Sindikata sindikata)
        {
          return Ok( _unitOfWork.Sindikata.Delete(sindikata));
        }
    }
}
