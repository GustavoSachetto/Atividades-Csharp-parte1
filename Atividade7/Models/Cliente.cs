using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade7.Models
{
    public class Cliente
    {
        public string Nome = { get; set; }
        public int Nasc = { get; set; }
        public int Id = { get; set; }
        public DateTime DateNow = DateTime.Now;

        public void ConsultaIdade() {
            return Convert.ToInt32(DateNow.Year) - Nasc;
        }
    }
}