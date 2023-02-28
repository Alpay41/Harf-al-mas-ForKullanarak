namespace HarfÇalışmasıForKullanarak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AlpayCa Harf Çalışması");
            Console.WriteLine();

            #region SATIR 1

            for (int u = 0; u < 9; u++) Console.Write(" ");
                Console.Write("*"); // A 

            for (int j = 0; j < 10; j++)Console.Write(" ");
                Console.Write("*");// L 

            for (int n = 0; n < 8; n++)Console.Write(" ");
            
            for (int o = 0; o < 5; o++)Console.Write("*");// P 

            for (int p = 0; p < 11; p++)Console.Write(" ");
                Console.Write("*");// A 

            for (int s = 0; s < 9; s++)Console.Write(" ");
                Console.Write("*");// Y 

            for (int s = 0; s < 11; s++) Console.Write(" ");
                Console.WriteLine("*");// Y 
            #endregion

            #region SATIR 2

            for (int u = 0; u < 8; u++) Console.Write(" ");
            Console.Write("*");// A 
            Console.Write(" ");
            Console.Write("*");// A 

            for (int j = 0; j < 9; j++) Console.Write(" ");
            Console.Write("*");// L 

            for (int n = 0; n < 8; n++) Console.Write(" ");
            Console.Write("*");// P 
            for (int n = 0; n < 4; n++) Console.Write(" ");
            Console.Write("*");// P

            for (int p = 0; p < 9; p++) Console.Write(" ");
            Console.Write("*");// A 
            Console.Write(" ");
            Console.Write("*");// A 

            for (int s = 0; s < 9; s++) Console.Write(" ");
            Console.Write("*");// Y 

            for (int s = 0; s < 9; s++) Console.Write(" ");
            Console.WriteLine("*");// Y 
            #endregion

            #region SATIR 3

            for (int u = 0; u < 7; u++) Console.Write(" ");
            Console.Write("*");// A 
            for (int u = 0; u < 3; u++) Console.Write(" ");
            Console.Write("*");// A 

            for (int j = 0; j < 8; j++) Console.Write(" ");
            Console.Write("*");// L 

            for (int n = 0; n < 8; n++) Console.Write(" ");
            Console.Write("*");// P 
            for (int n = 0; n < 4; n++) Console.Write(" ");
            Console.Write("*");// P 

            for (int p = 0; p < 8; p++) Console.Write(" ");
            Console.Write("*");// A 

            for (int u = 0; u < 3; u++) Console.Write(" ");
            Console.Write("*");// A 

            for (int s = 0; s < 9; s++) Console.Write(" ");
            Console.Write("*");// Y 

            for (int s = 0; s < 7; s++) Console.Write(" ");
            Console.WriteLine("*");// Y 
            #endregion
        }
    }
 }

