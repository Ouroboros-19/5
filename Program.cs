class Program
{
    static void Main()
    {
        Random r = new Random();
        bool z = true, zp = true;
        int a = 15, k = 0, q = 0;
        int[] mas = new int[a];
        for (int i = 0; i < a; i++)
        {
            mas[i] = r.Next(-2, 2);
            Console.Write("{0,3}", mas[i]);
            if (mas[i] != 0)
            {
                if (q == 0)
                {
                    if (mas[i] != 0)
                    {
                        q++;
                        if (mas[i] > 0)
                            z = true;
                        if (mas[i] < 0)
                            z = false;
                        zp = z;
                    }
                }
                else
                {
                    if (mas[i] > 0)
                        z = true;
                    if (mas[i] < 0)
                        z = false;
                    if (zp != z)
                        k++;
                    zp = z;
                }
            }
        }
        Console.WriteLine("\n" + k);
        Console.WriteLine("");
        Console.Write("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}
