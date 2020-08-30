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
    public class DepartamentController : ControllerBase
    {
        public readonly IUnitOfWork _unitOfWork;
        public DepartamentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/Departament
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _unitOfWork.Departamenti.GetDepartamentAll());
        }

        // GET: api/Departament/5
        [HttpGet("{departamentId}")]
        public async Task<IActionResult> GetById(int? departamentId)
        {
            if (departamentId != null)
            {
                var departamenti = await _unitOfWork.Departamenti.GetDepartamnetById(departamentId);
                if (departamenti != null)
                {
                    return Ok(Mapper.Map<DepartamentiModelView>(departamenti));
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

        // POST: api/Departament
        [HttpPost]
        public async Task<IActionResult>Create([FromBody] DepartamentiModelView departamentiDTO)
        {
            if (ModelState.IsValid)
            {
                var departamenti = Mapper.Map<Departamenti>(departamentiDTO);
                await _unitOfWork.Departamenti.CreteDepartamentAsync(departamenti);
                return Ok(departamentiDTO);
            }
            return BadRequest("Diqka ka shkuar gabim");
        }
        // PUT: api/Departament/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] DepartamentiModelView departamentiDTO)
        {
            if (ModelState.IsValid)
            {
                var departamenti = Mapper.Map<Departamenti>(departamentiDTO);
                await _unitOfWork.Departamenti.UpdateDepartamentAsync(departamenti);
                return Ok(departamentiDTO);
            }
            return BadRequest("Diqka ka shkuar gabim");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete(Departamenti departamenti)
        {
            return Ok(_unitOfWork.Departamenti.Delete(departamenti));
        }
    }
}
