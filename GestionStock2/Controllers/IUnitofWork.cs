using GestionStock2.Services;

namespace GestionStock2.Controllers
{
    public interface IUnitofWork
    {
        ICategoriasRepository CategoriasRepository { get; }

        IProductosRepository ProductosRepository { get; }

        Task CompleteAsync();
    }
}
