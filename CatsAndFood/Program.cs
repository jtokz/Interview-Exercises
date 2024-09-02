using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace CatsAndFood
{
    internal class Program
    {
        /// <summary>
        /// Imagine you are in a kitchen that is full of cats
        /// Every typical hungry cat will follow you if you hold some food, right?
        /// 
        /// You with food in the kitchen will be marked as F
        /// Every cat will be represented as ~O or O~ depending on the direction
        /// 
        /// Our goal is to count not hungry cats in the kitchen
        /// 
        /// Example= (O~ ~O~O~O F O~O~O~ ~O)
        /// 
        /// Expected: 2 - bc are 2 cats not following us
        /// </summary>
        /// <param name="Exercise"></param>


        static void Main(string[] args)
        {
            Console.WriteLine(HungryCats("O~ ~O~O~O~O F O~O~O~ ~O~O~O"));

            // Expected = 4
        }
        public static int HungryCats(string catsAndFood)
        {
            // Split the string
            var cats = catsAndFood.Replace(" ", "").Split('F');

            // tails are odd
            var leftCats = cats[0].Where((x,i) => i%2 == 1).Count(x => x=='~');
            // tails are even
            var rightCats = cats[1].Where((x, i) => i%2 == 0).Count(x => x=='~');

            return leftCats + rightCats;
        }
    }
}
