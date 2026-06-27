using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface ITutorEstudianteService
    {
        Task<TutorEstudiante> RegistrarTutor(int idUsuario, int idEstudiante, string nombre, string apellido, string? parentesco);
        Task<bool> ActualizarTutor(int idTutor, string? nombre, string? apellido, string? parentesco);
        Task<bool> ActivarTutor(int idTutor);
        Task<bool> DesactivarTutor(int idTutor);
        Task<TutorEstudiante?> ObtenerPorId(int idTutor);
        TutorEstudiante? ObtenerPorUsuario(int idUsuario);
        IEnumerable<TutorEstudiante> ObtenerTodos();
        IEnumerable<TutorEstudiante> ObtenerTutoresActivos();
        IEnumerable<Estudiante> ObtenerEstudiantes(int idTutor);
        int ContarEstudiantes(int idTutor);
        IEnumerable<TutorEstudiante> BuscarTutor(string nombre);
        string? ObtenerTelefono(int idTutor);
        string? ObtenerCorreo(int idTutor);
        Task<bool> ExisteTutor(int idUsuario);
        Task<bool> EliminarTutor(int idTutor);
    }
}
