List<string> listaEstado = new List<string>();

listaEstado.Add("SP");
listaEstado.Add("RJ");
listaEstado.Add("MG");
listaEstado.Add("AM");
listaEstado.Add("GO");
listaEstado.Add("ES");

Console.WriteLine($" Itens na minha lista: {listaEstado.Count} - Capacidade: {listaEstado.Capacity}");

foreach (var item in listaEstado)
{
    Console.WriteLine(item);
}

listaEstado.Remove("AM");

Console.WriteLine($" Itens na minha lista: {listaEstado.Count} - Capacidade: {listaEstado.Capacity}");