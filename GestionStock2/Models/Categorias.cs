namespace GestionStock.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        public string? Nombre { get; set;}

        public string? Descripcion { get; set;}

        public bool BajaLogica { get; set;}
    }
}
