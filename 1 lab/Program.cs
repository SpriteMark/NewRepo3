namespace _1_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, g;
            try
            {
                x = 1.825 * Math.Pow(10, 2);
                y = 18.225;
                z = -3.298 * Math.Pow(10, 2);
                g = Math.Abs(Math.Pow(x, y / x) - Math.Cbrt(y / x)) + (y - x) * ((Math.Cos(y) - z / (y - x)) / (1 + Math.Pow((y - x), 2)));

                Console.WriteLine("Значение выражения g = {0:F2}", g);
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка при вычислении!");
            }

        }
    }
}