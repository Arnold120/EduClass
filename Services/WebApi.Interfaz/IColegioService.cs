using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IColegioService
    {
        Task<Colegio> RegistrarColegio(string nombre, string? direccion, string? telefono, string? correo);
        Task<bool> ActualizarInformacion(int idColegio, string? nombre, string? direccion, string? telefono, string? correo);
        Task<bool> ActualizarLogo(int idColegio, string logo);
        Task<bool> ActivarColegio(int idColegio);
        Task<bool> DesactivarColegio(int idColegio);
        Task<Colegio?> ObtenerPorId(int idColegio);
        IEnumerable<Colegio> ObtenerTodos();
        IEnumerable<Colegio> ObtenerColegiosActivos();
        Task<Colegio?> ObtenerColegioPrincipal();
        Task<bool> ExisteColegio(string nombre);
        Task<bool> ExisteCorreo(string correo);
        Task<bool> ExisteTelefono(string telefono);
        IEnumerable<Colegio> BuscarPorNombre(string nombre);
        IEnumerable<Docente> ObtenerDocentes(int idColegio);
        IEnumerable<Estudiante> ObtenerEstudiantes(int idColegio);
        DirectorColegio? ObtenerDirector(int idColegio);
        int ContarDocentes(int idColegio);
        int ContarEstudiantes(int idColegio);
        int ContarGrados(int idColegio);
        Task<bool> EliminarColegio(int idColegio);
    }
}
