using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IGradoService
    {
        Task<Grado> CrearGrado(string nombreSeccion, string gradoNivel, int anioEscolar);
        Task<bool> ActualizarGrado(int idGrado, string? nombreSeccion, string? gradoNivel, int? anioEscolar);
        Task<bool> ActivarGrado(int idGrado);
        Task<bool> DesactivarGrado(int idGrado);
        Task<Grado?> ObtenerPorId(int idGrado);
        IEnumerable<Grado> ObtenerGradosDisponibles();
        IEnumerable<Grado> ObtenerGradosActivos();
        IEnumerable<Grado> ObtenerGradosInactivos();
        IEnumerable<Grado> ObtenerGradosPorAnio(int anioEscolar);
        IEnumerable<GradoSeccion> ObtenerSecciones(int idGrado);
        int ContarEstudiantes(int idGrado);
        int ContarDocentes(int idGrado);
        int ContarSecciones(int idGrado);
        Task<bool> ExisteGrado(string gradoNivel, int anioEscolar);
        IEnumerable<Grado> BuscarGrado(string criterio);
        IEnumerable<object> ObtenerGradosConMasEstudiantes(int limite);
        Task<bool> EliminarGrado(int idGrado);
    }
}
