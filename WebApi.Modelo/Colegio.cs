namespace WebApi.Modelo
{
    public class Colegio
    {
        public int IdColegio { get; set; }
        public string? NombreColegio { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Logo { get; set; }
        public bool Estado { get; set; } = true;
    }
}
