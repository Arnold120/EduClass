namespace WebApi.Modelo
{
    public class Roles
    {
        public int IdRol { get; set; }
        public string? NombreRol { get; set; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; } = true;
        public DateTime FechaRegistro { get; set; }
    }
}
