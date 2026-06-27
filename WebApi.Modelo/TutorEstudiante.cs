namespace WebApi.Modelo
{
    public class TutorEstudiante
    {
        public int IdTutor { get; set; }
        public int IdUsuario { get; set; }
        public int IdEstudiante { get; set; }
        public string? NombreTutor { get; set; }
        public string? ApellidoTutor { get; set; }
        public string? Parentesco { get; set; }
        public bool Estado { get; set; } = true;
    }
}
