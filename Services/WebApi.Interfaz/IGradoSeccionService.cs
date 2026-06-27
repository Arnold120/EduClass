using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IGradoSeccionService
    {
        Task<GradoSeccion> CrearSeccion(int idGrado, char seccion);
        Task<bool> ActivarSeccion(int idGradoSeccion);
        Task<bool> DesactivarSeccion(int idGradoSeccion);
        Task<bool> EliminarSeccion(int idGradoSeccion);
        Task<GradoSeccion?> ObtenerPorId(int idGradoSeccion);
        IEnumerable<GradoSeccion> ObtenerSeccionesPorGrado(int idGrado);
        IEnumerable<GradoSeccion> ObtenerSeccionesActivas();
        IEnumerable<Estudiante> ObtenerEstudiantes(int idGradoSeccion);
        IEnumerable<Docente> ObtenerDocentes(int idGradoSeccion);
        IEnumerable<Asignatura> ObtenerAsignaturas(int idGradoSeccion);
        int ContarEstudiantes(int idGradoSeccion);
        int ContarDocentes(int idGradoSeccion);
        int ContarAsignaturas(int idGradoSeccion);
        Task<bool> ExisteSeccion(int idGrado, char seccion);
        IEnumerable<GradoSeccion> ObtenerSeccionesDisponibles();
    }
}
