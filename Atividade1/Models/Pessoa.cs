using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public decimal Peso { get; set; }
        public bool Status { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos de idade. Tenho {Altura}m e peso {Peso}kg.");
        }

        public void VerificaStatus()
        {
            if (Status == true)
            {
                Console.WriteLine("Status ativo.");
            } else
            {
                Console.WriteLine("Status inativo.");
            }
        }
    }
}