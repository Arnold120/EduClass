namespace WebApi.Modelo
{
    public class GradoSeccion
    {
        public int IdGradoSeccion { get; set; }
        public int IdGrado { get; set; }
        public string? Seccion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
