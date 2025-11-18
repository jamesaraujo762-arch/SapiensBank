void Sacar()
{
    Console.Write("Número da conta: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Valor do saque: ");
    decimal valor = decimal.Parse(Console.ReadLine());

    bool ok = banco.Sacar(numero, valor);

    Console.WriteLine(ok ? "Saque realizado!" : "Falha no saque.");
}
