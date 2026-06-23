using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IUsuarioService
    {
        Task<Usuario> RegistrarUsuario(Usuario usuario, string contrasena);
        Task<Usuario?> AutenticarUsuario(string nombreUsuario, string contrasena);
        Task<bool> CerrarSesion(int idUsuario);
        IEnumerable<Usuario> GetUsuarios();
        Task<Usuario?> GetById(int id);
        string GenerarJwtToken (Usuario usario);
        IEnumerable<Usuario> ObtenerUsuariosEnLinea();
        bool EstaEnLinea(Usuario usuario);
        Task<bool> ActualizarUltimaActividad(int idUsuario);
        (bool estaEnLinea, DateTime? ultimaActividad) VerificarEstadoEnLinea(int idUsuario);
        IEnumerable<Object> ObtenerTodosLosEstadosEnLinea();
        Task<bool> ActualizarPerfil(int idUsuario, Usuario usuario);
        Task<bool> PuedeEditarPerfil(int idUsuario);
        Task<DateTime?> ObtenerFechaUltimaEdicionPerfil(int idUsuario);
        Task<bool> SolicitarRecuperacion(string Email, string telefono);
        Task<bool> VerificarCodigoRecuperacion(string Email, string codigo);
        Task<bool> CambiarContrasenaRecuperada(string Email, string nuevaContrasena);
    }
}
