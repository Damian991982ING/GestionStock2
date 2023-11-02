namespace GestionStock.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int CantMInDes {  get; set; }
        public int CantMaxDes { get; set; }

        public int CantEnEx { get; set; }

        public int IdCat {  get; set; }

        public bool BajaLogica { get; set; }

    }
}
