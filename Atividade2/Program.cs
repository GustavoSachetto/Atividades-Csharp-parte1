string somar = "40";
int valor = 80;
int resultado;

// resultado = int.Parse(somar) + valor;

resultado = Convert.ToInt32(somar) + valor;
resultado += 5;
resultado++;

Console.WriteLine(resultado);