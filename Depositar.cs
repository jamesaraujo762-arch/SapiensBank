void Depositar()
{
    Console.Write("Número da conta: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Valor do depósito: ");
    decimal valor = decimal.Parse(Console.ReadLine());

    bool ok = banco.Depositar(numero, valor);

    Console.WriteLine(ok ? "Depósito realizado!" : "Conta não encontrada.");
}
