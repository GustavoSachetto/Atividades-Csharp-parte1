using Atividade1.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Gustavo";
pessoa1.Idade = 17;
pessoa1.Altura = 1.80;
pessoa1.Peso = 56.99M;
pessoa1.Status = true;

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "João";
pessoa2.Idade = 27;
pessoa2.Altura = 1.63;
pessoa2.Peso = 62.20M;
pessoa2.Status = false;

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);
pessoa1.Apresentar();
pessoa1.VerificaStatus();

pessoa2.Apresentar();
pessoa2.VerificaStatus();