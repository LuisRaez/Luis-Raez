namespace Luis_Raez.Models
{
    public class Pedido
    {
        public int Id { get; set; } 

        public int NumeroPedido { get; set; }
        public List<Producto> Productos { get; set; } 
        public DateTime FechaPedido { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public DateTime? FechaDespacho { get; set; }
        public DateTime? FechaEntrega { get; set; }

        public int? VendedorId { get; set; } 
        public int? RepartidorId { get; set; }

        public Usuario Vendedor { get; set; }
        public Usuario Repartidor { get; set; }
        public string Estado { get; set; } 
    }
}
