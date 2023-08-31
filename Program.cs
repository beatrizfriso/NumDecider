Console.WriteLine("\r\n███╗░░██╗██╗░░░██╗███╗░░░███╗  ██████╗░███████╗░█████╗░██╗██████╗░███████╗██████╗░\r\n████╗░██║██║░░░██║████╗░████║  ██╔══██╗██╔════╝██╔══██╗██║██╔══██╗██╔════╝██╔══██╗\r\n██╔██╗██║██║░░░██║██╔████╔██║  ██║░░██║█████╗░░██║░░╚═╝██║██║░░██║█████╗░░██████╔╝\r\n██║╚████║██║░░░██║██║╚██╔╝██║  ██║░░██║██╔══╝░░██║░░██╗██║██║░░██║██╔══╝░░██╔══██╗\r\n██║░╚███║╚██████╔╝██║░╚═╝░██║  ██████╔╝███████╗╚█████╔╝██║██████╔╝███████╗██║░░██║\r\n╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝  ╚═════╝░╚══════╝░╚════╝░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝");
Console.WriteLine("  ");
Console.WriteLine("Bem-vindo ao app de comparação numérica que reconhece qual o maior valor digitado!");

Console.Write("Digite o primeiro número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} é maior que {num2}.");
}
else if (num2 > num1)
{
    Console.WriteLine($"{num2} é maior que {num1}.");
}
else
{
    Console.WriteLine("Nice try! Os números são iguais hahaha");
}
        