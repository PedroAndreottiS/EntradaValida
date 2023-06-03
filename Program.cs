int numero = -1;
Console.WriteLine("---Entrada válida---");

while (numero < 0 || numero > 9)
{
    Console.WriteLine("Digite somente números entre 1 e 9 (0 PARA CANCELAR)");
    numero = Convert.ToInt32(Console.ReadLine());
}

if (numero == 0)
{
    Console.WriteLine("CPF CANCELADO COM SUCESSO");
}

else
{
    Console.WriteLine($"\nNúmero selecionado = {numero}");
}

Console.WriteLine("\nVolte sempre!");