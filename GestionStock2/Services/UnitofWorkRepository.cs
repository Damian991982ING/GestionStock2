using GestionStock2.Controllers;
using GestionStock2.Models;

namespace GestionStock2.Services
{
    public class UnitofWorkRepository : IUnitofWork
    {
        //public ICategoriasRepository CategoriasRepository => throw new NotImplementedException();

        public ICategoriasRepository CategoriasRepository { get; private set; }

        private readonly GestionStockDBContext _dbContext;

        public UnitofWorkRepository(GestionStockDBContext dbContext)
        {
            _dbContext = dbContext;
            CategoriasRepository=new CategoriasRepository(dbContext);
        }

        public async Task CompleteAsync()
        {
          await this._dbContext.SaveChangesAsync();
        }
    }
}
