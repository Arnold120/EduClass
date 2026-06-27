using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IDirectorColegioService
    {
        Task<bool> AsignarDirector(int idUsuario, int idColegio);
        Task<bool> CambiarDirector(int idColegio, int idNuevoDirector);
        Task<bool> ActivarDirector(int idDirector);
        Task<bool> DesactivarDirector(int idDirector);
        Task<DirectorColegio?> ObtenerDirectorActual(int idColegio);
        IEnumerable<DirectorColegio> ObtenerHistorialDirectores(int idColegio);
        Task<bool> DirectorYaAsignado(int idUsuario);
        Task<bool> ColegioTieneDirector(int idColegio);
        Task<Colegio?> ObtenerColegioDirector(int idUsuario);
        Task<bool> RemoverDirector(int idColegio);
    }
}
