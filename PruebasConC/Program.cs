namespace PruebasConC;
class Program
{
    static void Main(string[] args)
    {
        var alfredo = new Character("Alfredo", 100, 20 , 20);
        Console.WriteLine(alfredo.Name);
        var axe = new Axe("Leviatán", 20);
        alfredo.AddItem(axe);
        
    }
}