using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IAsignaturaService
    {
        Task<Asignatura> RegistrarAsignatura(string nombre, int idPeriodo);
        Task<bool> ActualizarAsignatura(int idAsignatura, string nombre);
        Task<bool> ActivarAsignatura(int idAsignatura);
        Task<bool> DesactivarAsignatura(int idAsignatura);
        Task<Asignatura?> ObtenerPorId(int idAsignatura);
        IEnumerable<Asignatura> ObtenerTodas();
        IEnumerable<Asignatura> ObtenerAsignaturasActivas();
        IEnumerable<Asignatura> BuscarAsignatura(string nombre);
        Task<bool> ExisteAsignatura(string nombre);
        IEnumerable<Docente> ObtenerDocentes(int idAsignatura);
        IEnumerable<Grado> ObtenerGrados(int idAsignatura);
        IEnumerable<GradoSeccion> ObtenerSecciones(int idAsignatura);
        int ContarDocentes(int idAsignatura);
        int ContarEstudiantes(int idAsignatura);
        PeriodoAcademico? ObtenerPeriodo(int idAsignatura);
        IEnumerable<Asignatura> ObtenerPorPeriodo(int idPeriodo);
        IEnumerable<Asignatura> ObtenerAsignaturasSinDocente();
        Task<bool> EliminarAsignatura(int idAsignatura);
    }
}
