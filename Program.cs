using System.Data;

Console.WriteLine("ingrese un numero mayor a 0 para ser invertido:");
string? entrada = Console.ReadLine();
if(int.TryParse(entrada, out int numero))
{
    if (numero > 0)
    {
        int numeroOriginal = numero;
        int invertido = 0;
        while (numero > 0)
        {
            int resto = numero % 10;
            invertido = (invertido * 10)* resto;
            numero = numero/10;
        }
        Console.WriteLine($"\nEl número orignal era: {numeroOriginal}");
        Console.WriteLine($"\nEl número invertido es: {invertido}");
    }
    else
    {
        Console.WriteLine ("Error: El numero ingresado debe ser estrictamente mayor a 0.");
    }
}else
{
    Console.WriteLine("Error: la entrada introducida no es un numero entero valido.");
}
