namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Excerise 1 
            GetInfo();


           //Exercise 2
            int addResult = Add(7, 7);
            int multiplyResult = Multiply(4, 6);
            int divideResult = Divide(20, 4);
            int subtractResult = Subtract(15, 5);


            Console.WriteLine($"Here are your math results:{addResult}, {multiplyResult}, {divideResult}, {subtractResult} ");


            //Challenge Mode
            int additionResult = Addition(5, 8, 9, 8, 3, 2, 2, 2);
            Console.WriteLine(additionResult);
        }


        //Exercise 1
        public static void GetInfo () 
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What's your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What's your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What's your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Here's a review of the question above:\nName:{name}\nColor:{color}\nAnimal:{animal}\nBand:{band} ");
        
        }

        //Exercise 2
        public static int Add(int num1, int num2)
        { 
        return num1 + num2;
        }

        public static int Multiply(int num1, int num2) 
        {
        return (num1 * num2);
        }

        public static int Divide(int num1, int num2) 
        { 
        return (num1 / num2);
        }
        
        public static int Subtract(int num1, int num2)
        {
         return num1 - num2;
        }

        

        //Challenge Mode
         public static int Addition (params int[] numbersArray)
        {

            int sum = 0;

            foreach(int number in numbersArray)
            {
                sum += number;

            }

            return sum;

        }
    }
}
