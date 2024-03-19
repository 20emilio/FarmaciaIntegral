namespace FarmaciaIntegral.Models
{
    public class Productos
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Calidad { get; set; }
        public string Especificaciones { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
    }
}
