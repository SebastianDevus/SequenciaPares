int numeroEscolhido, contador = 0;

Console.Write("\nDigite um número: ");
numeroEscolhido = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nOs números pares entre 0 e {numeroEscolhido} são:");

while (contador <= numeroEscolhido)
{
    Console.Write($"{contador} ");
    contador = contador + 2;
}

Console.WriteLine("\n");