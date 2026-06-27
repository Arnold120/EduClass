namespace WebApi.Modelo
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public int IdUsuario { get; set; }
        public int IdGradoSeccion { get; set; }
        public string? NombreEstudiante { get; set; }
        public string? ApellidoEstudiante { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? Nivel { get; set; } = "Secundaria";
        public bool Estado { get; set; } = true;
    }
}
