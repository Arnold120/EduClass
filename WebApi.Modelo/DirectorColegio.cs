namespace WebApi.Modelo
{
    public class DirectorColegio
    {
        public int IdDirector { get; set; }
        public int IdUsuario { get; set; }
        public int IdColegio { get; set; }
        public DateTime FechaInicio { get; set; }
        public bool Estado { get; set; } = true;
    }
}
