internal class Program
{
    private static void Main(string[] args)
    {

        int acu1 = 0;
        int acu2 = 0;
        int par1 = 0;
        int par2 = 0;
        for (int i = 1; i < 1500; i++)
        {
            for (int j = 1; j < 1500; j++)
            {
                if (i != j)
                {
                    for (int k = 1; k < i; k++)
                    {

                        if (i % k == 0)
                            acu1 += k;
                    }
                    for (int l = 1; l < j; l++)
                    {
                        if (j % l == 0)
                            acu2 += l;
                    }
                    if (acu1 == j && acu2 == i)
                    {
                        par1 = i;
                        par2 = j;
                    }
                    acu1 = 0;
                    acu2 = 0;
                }
            }
        }
        Console.WriteLine($"Numero 1 = {par1}");
        Console.WriteLine($"Numero 2 = {par2}");
        Console.ReadKey();
    }
}