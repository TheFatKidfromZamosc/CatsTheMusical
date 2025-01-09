// Program counts the amount of speed an object can get if they were to fall for the amount of time specified by the user
// Input : 10 s
//Output : 490 m

namespace TwinTowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The time the object will free fall in seconds : ");
            int t = Convert.ToInt32(Console.ReadLine());
            double distance = (0.5*9.8*(t));
            Console.WriteLine("The distance the object has fallen :" + distance );
        }
    }
}
