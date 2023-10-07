using System;

public class hi
{
    public static int Binairzoeken(int[] A, int x)
    {
        int laag = 0;
        int hoog = A.Length - 1;
        while (laag < hoog)
        {
            int midden = (laag + hoog) / 2;
            if (A[midden] < x) { laag = midden + 1; }
            else { hoog = midden; }
        }
        if ( A.Length == 0 ) { return -1; }
        if (A[laag] == x) { return laag; }
        else if (A[laag] < x) { return laag; }
        else if (A[laag] > x && laag!=0) { return laag-1; }
        else { return -1; }
    }

    public static void Main()
    {
        string ninput = Console.ReadLine();
        string[] nsplit = ninput.Split(' ');
        int n = int.Parse(nsplit[0]);

        long schijven = 0;
        int[] standaard = new int[n];
        int i = 0;
        while (i < n)
        {
            string blokinput = Console.ReadLine();
            string[] bloksplit = blokinput.Split(' ');
            int blok = int.Parse(bloksplit[0]);
            standaard[i] = blok;
            i++;
        }
        string minput = Console.ReadLine();
        string[] msplit = minput.Split(' ');
        int m = int.Parse(msplit[0]);
        int j = 0;
        while (j < m)
        {
            string hoogteinput = Console.ReadLine();
            string[] hoogtesplit = hoogteinput.Split(' ');
            int hoogte = int.Parse(hoogtesplit[0]);

            int index = Binairzoeken(standaard, hoogte);
            if (index < 0) { schijven += hoogte; }
            else { schijven += hoogte - standaard[index]; }
            j++;
        }
        Console.WriteLine(schijven);
    }

}