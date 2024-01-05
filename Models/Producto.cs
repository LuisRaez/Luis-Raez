namespace Luis_Raez.Models
{
    public class Producto
    {
        public int Id { get; set; } 

        public string SKU { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Etiquetas { get; set; } 
        public decimal Precio { get; set; }
        public string UnidadMedida { get; set; }
    }
}
