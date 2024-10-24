namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("pleas enter three nhumbers");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"largest number in {num1}");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine($"largest number in {num2}");
            }
            else
            {
                Console.WriteLine($"largest number in {num3}");
            }
            //Asiignment 1














            Console.WriteLine("please enter yor grade");
            string grade;
            grade = Console.ReadLine();

            do
            {
                switch (grade)
                {
                    case "A":
                        Console.WriteLine("EXELENT");
                        break;
                    case "B":
                        Console.WriteLine("Very Good");
                        break;
                    case "C":
                        Console.WriteLine("Good");
                        break;
                    case "D":
                        Console.WriteLine("Fair");
                        break;
                    case "E":
                        Console.WriteLine("Failed");
                        break;

                }
                grade = Console.ReadLine();

            } while (grade == "A" || grade == "B" || grade == "C" || grade == "D" || grade == "E");

            Console.WriteLine("NO MATCH!");
            //// Assignment 2











            Console.WriteLine("please enter numbers");
            double sum = 0;
            do
            {
                double num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            while (sum <= 100);
            Console.WriteLine($"your sum {sum} exeeds 100 now");
            //Asiignment 3













            Console.WriteLine("please enter number between 2 and 9");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x < 2 || x > 9)
            {

                Console.WriteLine("WRONG INPUT \n please enter number between 2 and 9");
                x = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 1; i <= 10; i++)
            {
                int multiplication = x * i;

                Console.WriteLine($"{x} * {i} = {multiplication}");
            }
            //Assignment 4
        }
    }
}
