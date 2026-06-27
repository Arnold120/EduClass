namespace WebApi.Modelo
{
    public class DocenteAsignaturaGrado
    {
        public int IdDocenteAsignaturaGrado { get; set; }
        public int IdDocente { get; set; }
        public int IdAsignatura { get; set; }
        public int IdGradoSeccion { get; set; }
        public bool Estado { get; set; } = true;
    }
}
