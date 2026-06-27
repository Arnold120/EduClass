using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IEstudianteService
    {
        Task<Estudiante> RegistrarEstudiante(int idUsuario, int idGradoSeccion, string nombre, string apellido);
        Task<bool> ActualizarEstudiante(int idEstudiante, string? nombre, string? apellido);
        Task<bool> ActivarEstudiante(int idEstudiante);
        Task<bool> DesactivarEstudiante(int idEstudiante);
        Task<Estudiante?> ObtenerPorId(int idEstudiante);
        Estudiante? ObtenerPorUsuario(int idUsuario);
        IEnumerable<Estudiante> ObtenerTodos();
        IEnumerable<Estudiante> ObtenerEstudiantesActivos();
        IEnumerable<Estudiante> BuscarPorNombre(string nombre);
        IEnumerable<Estudiante> ObtenerPorGradoSeccion(int idGradoSeccion);
        IEnumerable<Estudiante> ObtenerCompanieros(int idEstudiante);
        GradoSeccion? ObtenerGrado(int idEstudiante);
        GradoSeccion? ObtenerSeccion(int idEstudiante);
        TutorEstudiante? ObtenerTutor(int idEstudiante);
        IEnumerable<Docente> ObtenerDocentes(int idEstudiante);
        IEnumerable<Asignatura> ObtenerAsignaturas(int idEstudiante);
        Task<bool> CambiarGrado(int idEstudiante, int idGradoSeccion);
        Task<bool> CambiarSeccion(int idEstudiante, int idGradoSeccion);
        int ContarMaterias(int idEstudiante);
        double ObtenerPromedio(int idEstudiante);
        Task<bool> ExisteEstudiante(int idUsuario);
        Task<bool> EliminarEstudiante(int idEstudiante);
        int ContarEstudiantesPorGrado(int idGrado);
        int ContarEstudiantesPorGradoSeccion(int idGradoSeccion);
    }
}
