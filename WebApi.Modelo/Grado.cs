namespace WebApi.Modelo
{
    public class Grado
    {
        public int IdGrado { get; set; }
        public string? NombreSeccion { get; set; }
        public string? GradoNivel { get; set; }
        public int AnioEscolar { get; set; }
        public bool Estado { get; set; } = true;
    }
}
