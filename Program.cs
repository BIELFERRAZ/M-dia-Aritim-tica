double n1 ,n2 , n3 , media;

Console.WriteLine("Média Aritmética de 3 números\n");

Console.Write("Digite o primeiro número..: ");
n1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o segundo número...: ");
n2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o terceiro número..: ");
n3 = Convert.ToDouble(Console.ReadLine()!);

media = (n1 + n2 + n3) / 4; 

Console.WriteLine($"Média: {media:N1}");
