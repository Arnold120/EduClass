namespace WebApi.Modelo
{
    public class Asignatura
    {
        public int IdAsignatura { get; set; }
        public string? NombreAsignatura { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdPeriodo { get; set; }
        public bool Estado { get; set; } = true;
    }
}
