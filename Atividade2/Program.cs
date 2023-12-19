string somar = "40";
int valor = 80;
int resultado;

// resultado = int.Parse(somar) + valor;

resultado = Convert.ToInt32(somar) + valor;
resultado += 5;
resultado++;

Console.WriteLine(resultado);

int inteiro = 32;
string teste = inteiro.ToString() + 10;

Console.WriteLine(teste);

int n1 = 6789;
int n2 = 193;
double n3 = 333.0;
double n4 = 1234.55;

double geralContas = n4 / (n1 * (n2 + n3));

Console.WriteLine(geralContas);

string valorA = "13!";
int valorB = 0;

int.TryParse(valorA, out valorB);

Console.WriteLine(valorB);