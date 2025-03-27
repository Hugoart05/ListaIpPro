using System.Globalization;

namespace DataBase.Models
{
    public class ErroMinitoramento
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public ErroType Tipo { get; set; }
        public int? DispositivoId { get; set; }
        public Dispositivo Dispositivo { get; set; }
        public int? AntenaId { get; set; }
        public Antena Antena { get; set; }
    }
}