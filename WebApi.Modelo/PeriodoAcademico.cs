namespace WebApi.Modelo
{
    public class PeriodoAcademico
    {
        public int IdPeriodo { get; set; }
        public string? NombrePeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; } = true;
    }
}
