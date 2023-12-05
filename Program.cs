// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int rango1 = 1000;
int rango2 = 1500;

ObtenerNumerosAmistosos(rango1, rango2);


static void ObtenerNumerosAmistosos(int inicio, int fin)
{
    for (int m = inicio; m <= fin; m++)
    {
        int n = SumaDivisores(m);

        if (n != m && SumaDivisores(n) == m)
        {
            Console.WriteLine($"Par amigable encontrado: ({m}, {n})");
        }
    }
}

static int SumaDivisores(int numero)
{
    int suma = 0;
    for (int i = 1; i < numero; i++)
    {
        if (numero % i == 0)
        {
            suma += i;
        }
    }
    return suma;
}