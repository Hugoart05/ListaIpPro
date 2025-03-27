using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class Antena
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Local { get; set; }
        public string Ip { get; set; }
        public List<ErroMinitoramento> Erros { get; set; }
        public DateTime DataCadastro { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public BKPType Tipo { get; set; }
    }
}
