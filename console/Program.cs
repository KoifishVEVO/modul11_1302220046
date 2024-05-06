using MatematikaLibraries;
namespace MatematikaLibraries;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FPB 40,45");
        Console.WriteLine(MatematikaLibraries.FPB(60, 45));

        Console.WriteLine("KPK 12,8");
        Console.WriteLine(MatematikaLibraries.KPK(12, 8));

        Console.WriteLine("Turunan dari persamaan x^3+4x^2-12x+9");
        Console.WriteLine(MatematikaLibraries.Turunan(new int[]{1, 4, -12, 9}));

        Console.WriteLine("Integral dari persamaan 4x^3 + 6x^2 - 12x + 9");
        Console.WriteLine(MatematikaLibraries.Integral(new int[] {4,6,-12,9}));
    }
}
