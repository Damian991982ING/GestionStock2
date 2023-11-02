using GestionStock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionStock2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;
        public CategoriasController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        } 
        

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var _data = await this.unitofWork.CategoriasRepository.GetAllAsync();
            return Ok(_data);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            //return (IActionResult) await this.unitofWork.CategoriasRepository.GetAllAsync();
            var _data = await this.unitofWork.CategoriasRepository.GetAsync(id);
            return Ok(_data);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Categorias categorias)
        {
            var _data = await this.unitofWork.CategoriasRepository.AddEntity(categorias);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(Categorias categorias)
        {
            var _data = await this.unitofWork.CategoriasRepository.UpdateEntity(categorias);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitofWork.CategoriasRepository.DeleteEntity(id);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }
    }
}
