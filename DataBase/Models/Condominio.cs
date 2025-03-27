using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class Condominio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Dispositivo> Dispositivos { get; set; }
        public List<Antena> Antenas { get; set; }

    }
}
