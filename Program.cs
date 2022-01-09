using System;

namespace Singleton
{
    class Program
    {
        //Singleton
        public class Rector
        {
            static Rector rector;
            protected Rector()
            {
                Console.WriteLine("Назначен новый ректор");
            }
            public static Rector Instance()
            {
                if (rector == null)
                {
                    rector = new Rector();
                }
                else
                {
                    Console.WriteLine("Ректор уже есть");
                }
                return rector;
            }
        }
        static void Main(string[] args)
        {
            //Singleton
            Rector r_1 = Rector.Instance();
            Rector r_2 = Rector.Instance();
        }
    }
}
