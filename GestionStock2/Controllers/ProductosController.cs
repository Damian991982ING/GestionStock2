using GestionStock.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionStock2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public ProductosController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _data = await this.unitofWork.ProductosRepository.GetAllAsync();
            return Ok(_data);
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            //return (IActionResult) await this.unitofWork.CategoriasRepository.GetAllAsync();
            var _data = await this.unitofWork.ProductosRepository.GetAsync(id);
            return Ok(_data);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(Productos productos)
        {
            var _data = await this.unitofWork.ProductosRepository.AddEntity(productos);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(Productos productos)
        {
            var _data = await this.unitofWork.ProductosRepository.UpdateEntity(productos);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }
        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitofWork.ProductosRepository.DeleteEntity(id);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }
    }
}
