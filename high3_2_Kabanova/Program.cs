using System;

namespace high3_2_Kabanova
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 0, sum = 0, a = 1;
                Console.WriteLine("Введите последовательность чисел после стрелки, для завершения ввода введите 0.");
                do
                {
                    Console.Write("->");
                    a = int.Parse(Console.ReadLine());
                    if (a > 0) sum += a;
                    n++;
                }
                while (a != 0);
                Console.WriteLine($"Сумма чисел: {sum}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
