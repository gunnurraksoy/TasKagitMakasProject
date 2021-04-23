using System;

namespace TasKagitMakasProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointA = 0;
            
            int pointB = 0;
           
            int tie = 0;

        
            string[] choice = { "taş", "kağıt", "makas" };

            for (int i = 0; i < 100; i++)
            {
                Random B = new Random();
                int a = B.Next(3);

                if (choice[a] == "taş")
                {
                    pointA++;
                   

                }
                if (choice[a] == "kağıt")

                {
                    tie++;
                }
                if (choice[a] == "makas")
                {

                    pointB++;
                }



            }
            Console.WriteLine("Oyuncu A 100 oyunun " + pointA + " tanesini kazandı.");
            Console.WriteLine("Oyuncu B 100 oyunun " + pointB + " tanesini kazandı.");
            Console.WriteLine("100 oyunun " +tie+ " tanesi berabere kaldı.");
            
        }
    }
}
