using GestionStock.Models;
using GestionStock2.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionStock2.Services
{
    public class ProductosRepository:GenericRepository<Productos>, IProductosRepository
    {
        public ProductosRepository(GestionStockDBContext GestionDB):base(GestionDB) 
        {

        }
        public override Task<List<Productos>> GetAllAsync()
        {
            return base.GetAllAsync();
            //return DBSet.Select(x=>x.Nombre).ToList();
        }

        public override async Task<Productos> GetAsync(int id)
        {
            return await DBSet.FirstOrDefaultAsync(item => item.Id == id);
        }
        public override async Task<bool> AddEntity(Productos entity)
        {
            try
            {
                await DBSet.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public override async Task<bool> UpdateEntity(Productos entity)
        {
            try
            {
                var existdata = await DBSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
                if (existdata != null)
                {
                    existdata.Nombre = entity.Nombre;
                    existdata.Descripcion = entity.Descripcion;
                    existdata.CantMInDes = entity.CantMInDes;
                    existdata.CantMaxDes = entity.CantMaxDes;
                    existdata.CantEnEx=entity.CantEnEx;
                    existdata.BajaLogica = entity.BajaLogica;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override async Task<bool> DeleteEntity(int id)
        {
            var existdata = await DBSet.FirstOrDefaultAsync(item => item.Id == id);
            if (existdata != null)
            {
                DBSet.Remove(existdata);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
