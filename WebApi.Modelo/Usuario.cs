namespace WebApi.Modelo
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Contrasena { get; set; }
        public string? Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string? Genero { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public DateTime UltimaActividad { get; set; } 
        public bool EnSesion { get; set; } = false;
    }
}
