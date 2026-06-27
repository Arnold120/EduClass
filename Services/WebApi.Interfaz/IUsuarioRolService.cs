using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IUsuarioRolService
    {
        Task<bool> AsignarRol(int idUsuario, int idRol);
        Task<bool> QuitarRol(int idUsuario, int idRol);
        Task<bool> CambiarRol(int idUsuario, int idRolViejo, int idRolNuevo);
        IEnumerable<Roles> ObtenerRolesUsuario(int idUsuario);
        IEnumerable<Usuario> ObtenerUsuariosPorRol(int idRol);
        Task<bool> UsuarioTieneRol(int idUsuario, int idRol);
        Task<bool> UsuarioTieneAlgunRol(int idUsuario, IEnumerable<int> roles);
        int ContarUsuariosEnRol(int idRol);
    }
}
