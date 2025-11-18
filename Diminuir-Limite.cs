void DiminuirLimite()
{
    Console.WriteLine("=== DIMINUIR LIMITE ===");

    Console.Write("Número da conta: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Valor a diminuir: ");
    decimal valor = decimal.Parse(Console.ReadLine());

    bool ok = banco.DiminuirLimite(numero, valor);

    Console.WriteLine(ok ? "Limite diminuído com sucesso!" : "Falha ao diminuir limite!");
}
