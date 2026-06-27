using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IDocenteAsignaturaGradoService
    {
        Task<bool> AsignarDocente(int idDocente, int idAsignatura, int idGradoSeccion);
        Task<bool> QuitarAsignacion(int idDocenteAsignaturaGrado);
        Task<bool> CambiarDocente(int idDocenteAsignaturaGrado, int idNuevoDocente);
        Task<bool> ActivarAsignacion(int idDocenteAsignaturaGrado);
        Task<bool> DesactivarAsignacion(int idDocenteAsignaturaGrado);
        IEnumerable<DocenteAsignaturaGrado> ObtenerCargaDocente(int idDocente);
        IEnumerable<Asignatura> ObtenerAsignaturasDocente(int idDocente);
        IEnumerable<Grado> ObtenerGradosDocente(int idDocente);
        IEnumerable<GradoSeccion> ObtenerSeccionesDocente(int idDocente);
        IEnumerable<Docente> ObtenerDocentesAsignatura(int idAsignatura);
        IEnumerable<Docente> ObtenerDocentesPorGradoSeccion(int idGradoSeccion);
        IEnumerable<DocenteAsignaturaGrado> ObtenerAsignacionesPorGrado(int idGradoSeccion);
        Task<bool> ExisteAsignacion(int idDocente, int idAsignatura, int idGradoSeccion);
        Task<bool> DocenteTieneAsignacion(int idDocente, int idAsignatura);
        int ContarAsignacionesDocente(int idDocente);
        int ContarDocentesAsignatura(int idAsignatura);
        bool DocenteImparteEnGrado(int idDocente, int idGradoSeccion);
    }
}
