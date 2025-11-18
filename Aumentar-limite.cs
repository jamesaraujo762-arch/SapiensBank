void AumentarLimite()
{
    Console.WriteLine("=== AUMENTAR LIMITE ===");

    Console.Write("Número da conta: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Valor a aumentar: ");
    decimal valor = decimal.Parse(Console.ReadLine());

    bool ok = banco.AumentarLimite(numero, valor);

    Console.WriteLine(ok ? "Limite aumentado com sucesso!" : "Falha ao aumentar limite!");
}
