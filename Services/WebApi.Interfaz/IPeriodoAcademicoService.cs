using WebApi.Modelo;

namespace WebApi.Interfaz
{
    public interface IPeriodoAcademicoService
    {
        Task<PeriodoAcademico> CrearPeriodo(string nombre, DateTime fechaInicio, DateTime fechaFin);
        Task<bool> ActivarPeriodo(int idPeriodo);
        Task<bool> CerrarPeriodo(int idPeriodo);
        Task<bool> FinalizarPeriodo(int idPeriodo);
        Task<PeriodoAcademico?> ObtenerPeriodoActivo();
        Task<bool> ExistePeriodoActivo();
        Task<PeriodoAcademico?> ObtenerPeriodoActual();
        Task<PeriodoAcademico?> ObtenerPeriodoAnterior();
        Task<PeriodoAcademico?> ObtenerPorId(int idPeriodo);
        IEnumerable<PeriodoAcademico> ObtenerTodos();
        IEnumerable<PeriodoAcademico> ObtenerPeriodosCerrados();
        IEnumerable<PeriodoAcademico> ObtenerPeriodosActivos();
        IEnumerable<PeriodoAcademico> ObtenerPeriodosPorAnio(int anio);
        Task<bool> ActualizarFechas(int idPeriodo, DateTime fechaInicio, DateTime fechaFin);
    }
}
