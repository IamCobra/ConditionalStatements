namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 

            Console.WriteLine(AbsolutValue(-36));

            Console.WriteLine(Divisable(7, 12));

            // Herunder har jeg opgaven, store og små bogstaver beregener

            Console.WriteLine(tjek("pil"));
            Console.WriteLine(tjek("ABC"));
            Console.WriteLine(tjek("gul"));

            // Herunder har jeg lavet en funktion der viser om de to første tal bliver større end det tredje når man ganger dem med hinanden

            int[] numbers = { 2, 7, 12 };
            bool result = IfGreaterThanThirdOne(numbers);
            Console.WriteLine(result);

            // Ved denne opgave skal vi lave en funktion der tjekker om det kører i rækkefølge eller ej

            int[] numbers2 = { 3, 4, 5, };
            int[] numbers3 = { 5, 3, 2, };
            Console.WriteLine(IfSortedAscending(numbers2));
            Console.WriteLine(IfSortedAscending(numbers3));
        }

        static int AbsolutValue(int value) // Denne funktion tjekker om tallet er minus. Og hvis den er så ganger den tallet med minus for at det bliver et positivt tal
        {
            if (value < 0)
            {
                value = value * (-1);
            }

            return value;
        }

        static int Divisable(int firstValue, int secondValue) // Ved denne funktion har jeg lavet en if statement.
        {
            int result;
            bool isTrue = false;

            if (secondValue % 2 == 0 || secondValue % 3 == 0) // Her tjekker jeg om secondValue kan divideres med 2 eller 3, ved at bruge modulus for at være sikker på at resten er ligemed 0.
            {
                isTrue = true;
            }

            if ((firstValue % 2 == 0 || firstValue % 3 == 0) && isTrue == true) // Her gør vi noget lignende udover her tjekker vi bare om det vi gjorde før er sandt.
            {
                result = firstValue * secondValue;
            }
            else
            {
                result = firstValue + secondValue; // hvis vores value ikke kan divideres med 2 eller 3 fortæller vi den at den skal plusse det sammen.
            }

            return result;

        }

        static bool tjek(string storeOrd) // I denne opgave skal vi lave en metode der tjekker om der er store bogstaver eller små."
        {
            if (storeOrd.Length == 3)
            {
                foreach (char c in storeOrd)
                {
                    if (char.IsUpper(c))
                        return true;


                }
                return false;


            }
            else { return false; }
        }





        public static bool IfGreaterThanThirdOne(int[] arrays)
        {
            if (arrays.Length != 3)
            {
                return false;
            }

            int num1 = arrays[0];
            int num2 = arrays[1];
            int num3 = arrays[2];

            return (num1 * num2 > num3) || (num1 + num2 > num3);
        }

        public static bool IfSortedAscending(int[] array)
        {
            if (array.Length != 3)
            {
                return false;
            }
            return array[0] <= array[1] && array[1] <= array[2];
        }




    }
}