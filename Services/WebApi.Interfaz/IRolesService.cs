using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IRolesService
    {
        Task<Roles> CrearRol(string nombreRol, string? descripcion);
        Task<bool> ActualizarRol(int idRol, string nombreRol, string? descripcion);
        Task<bool> DesactivarRol(int idRol);
        Task<bool> ActivarRol(int idRol);
        Task<Roles?> ObtenerRolPorId(int idRol);
        Task<Roles?> ObtenerRolPorNombre(string nombreRol);
        IEnumerable<Roles> ObtenerRolesActivos();
        IEnumerable<Roles> ObtenerTodosLosRoles();
        Task<bool> ExisteRol(string nombreRol);
        Task<bool> RolEstaActivo(int idRol);
        Task<bool> EliminarRol(int idRol);
    }
}
