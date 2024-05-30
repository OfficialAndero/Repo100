namespace SkipTakeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik");
            Console.WriteLine("1. SkipWhile");
            Console.WriteLine("2. Take");
            Console.WriteLine("3. Püramiid");
            Console.WriteLine("4.ifandelseMeetod");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SkipWhile();
                    break;
                case "2":
                    Take();
                    break;
                case "3":
                    Puramiid();
                    break;
                case "4":
                    ifandelseMeetod();
                    break;
            }

        }

        public static void SkipWhile()
        {
            Console.WriteLine("\n\n----------------SkipWhile------------");
            var skip = PeopleList.people.SkipWhile(x => x.Age > 18);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }

        public static void Take()
        {
            Console.WriteLine("\n\n----------------Take------------");
            //n'itab kolme esimest

            var take = PeopleList.people.Take(3);

            foreach (var item in take)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }

      public static void Puramiid()
        {
            int i, j, rows;
            int t = 1;
            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++) 
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 1 * i - 1; j++) 
                {
                    Console.Write("{0} ", t++);
                }
                Console.Write("\n");
            }
        }
        public static void ifandelseMeetod() 
        {
            Console.WriteLine("Kas soovid faili kirjutada");

            string ja = Console.ReadLine();

            if (ja == "ja")
            {
                Console.WriteLine("Kirjuta fail");

                string filePath = @"C:/Users/Ingvar/Desktop/WriteToFile.txt"; 
                string inputText = Console.ReadLine();

                File.WriteAllText(filePath, inputText);
            }
            else 
            {
                Console.WriteLine("Ei kirjuta");
            }
        }
}
}  

         