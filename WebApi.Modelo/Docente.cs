namespace WebApi.Modelo
{
    public class Docente
    {
        public int IdDocente { get; set; }
        public int IdUsuario { get; set; }
        public int IdColegio { get; set; }
        public string? NombreDocente { get; set; }
        public string? ApellidoDocente { get; set; }
        public string? Especialidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; } = true;
    }
}
