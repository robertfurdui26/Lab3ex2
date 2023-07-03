//Ex 2
//Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul

Console.WriteLine("introduce un numar: ");int numar = int.Parse(Console.ReadLine());bool rezultat= IsNumarPrim(numar);if (rezultat)
{
    Console.WriteLine("Numarul este prim");
}
else
{
    Console.WriteLine("Nu este prim");
}static bool IsNumarPrim(int numar)
{
    if(numar<2) return false;

    for(int i = 2;i < Math.Sqrt(numar); i++)
    {
        if(numar % i == 0)
            return true;
    }
    return false;
}