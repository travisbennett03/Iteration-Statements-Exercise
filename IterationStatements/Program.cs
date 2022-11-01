namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();

            Threes();

            Console.WriteLine(Equals(4, 7));

            Console.WriteLine(OddOrEven (7));

            Console.WriteLine(IsPositive(9));

            Console.WriteLine(VotingAge(26));

            string num = Console.ReadLine();
            Console.WriteLine(TenToTen(int.Parse(num)));

            string num2 = Console.ReadLine();
            MultiTable(int.Parse (num2));

        }

        public static void PrintThousand()
        {
            for(int i = 1000; i >= -1000; i --)
            {
                Console.WriteLine(i);
            }

        }

        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool Equals(int a, int b)
        {
           var check = (a == b) ? true : false;

            return check; 
        }

        public static bool OddOrEven(int number)
        { 
            
            if (number % 2 == 0)
            {
                return true;

            }
            else
            {
               return false;
            }

        }

        public static bool IsPositive(int num1)
        {
            if (num1 > 0)
            {
                return true;
            }

            return false;
        }

        public static bool VotingAge (int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Congrats, you can vote");
                return true;
            }
            else
            {
                Console.WriteLine("You are too young, better luck next years");
                return false;
            }
        }

        public static bool TenToTen (int number)
        {
            if (number <= 10 && number >= -10)
            {
                return true;

            }
           return false; 
        }

        public static void MultiTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(number * i);
            }
        }
    }
}
