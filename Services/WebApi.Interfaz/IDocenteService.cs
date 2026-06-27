using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IDocenteService
    {
        Task<Docente> RegistrarDocente(int idUsuario, int idColegio, string nombre, string apellido, string? especialidad);
        Task<bool> ActualizarDocente(int idDocente, string? nombre, string? apellido, string? especialidad);
        Task<bool> ActivarDocente(int idDocente);
        Task<bool> DesactivarDocente(int idDocente);
        Task<Docente?> ObtenerPorId(int idDocente);
        Docente? ObtenerPorUsuario(int idUsuario);
        IEnumerable<Docente> ObtenerTodos();
        IEnumerable<Docente> ObtenerDocentesActivos();
        IEnumerable<Docente> ObtenerPorColegio(int idColegio);
        IEnumerable<Docente> BuscarPorNombre(string nombre);
        IEnumerable<Docente> BuscarPorEspecialidad(string especialidad);
        IEnumerable<Asignatura> ObtenerAsignaturas(int idDocente);
        IEnumerable<Grado> ObtenerGrados(int idDocente);
        IEnumerable<GradoSeccion> ObtenerSecciones(int idDocente);
        IEnumerable<DocenteAsignaturaGrado> ObtenerCargaAcademica(int idDocente);
        int ContarAsignaturas(int idDocente);
        int ContarGrados(int idDocente);
        int ContarSecciones(int idDocente);
        Task<bool> ExisteDocente(int idUsuario);
        Colegio? ObtenerColegio(int idDocente);
        Task<bool> EliminarDocente(int idDocente);
    }
}
