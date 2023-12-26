using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade9.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Nasc { get; set; }
        public string VerficaIdade() {
            DateTime date = DateTime.Now;
            return (date.Year - Nasc).ToString();
        }
    }
}