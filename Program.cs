using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            // -------- პირველი დავალების ორი ვარიანტი --------
            // checkPassAndUsername();
            // checkPassAndUsernameCringeWay();

            // ------ მეორე დავალების ორი ვარიანტი -------
            // ConverterToBinary(578);
            // ConverterToBinaryFirsVariant();

            // ----- მესამე დავალება -------
            // Calculate the area
            // double area = Calculate(60, 170);
            // Console.WriteLine($"The area is: {area}");

            // Calculate the volume
            // double volume = Calculate(53, 110, 33);
            // Console.WriteLine($"The volume is: {volume}");
        }
        // პირველი დავალება
        // აქ კარგად ვერ მივხვდი შეცდომა როდის უნდა დაებრუნებინა 5"წარუმატებელი ცდის შემდეგ მხოლოდ თუ 5 ნებისმიერი ცდის შემდეგ. ამიტომ ორივე ხერხიდავწერე"

        // საქსესის დროს ჩერდება
        static void checkPassAndUsername()
        {
            string username = "Nika";
            string password = "12345";
            int attempts = 5;
            while (attempts > 0)
            {
                Console.Write("Enter username: ");
                string? inputUsername = Console.ReadLine();

                Console.Write("Enter password: ");
                string? inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    Console.WriteLine("Success!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                    attempts--;
                }
            }

            if (attempts == 0)
            {
                Console.WriteLine("Oooops something gone wrong!!!.");
            }

            Console.ReadLine();
        }
        // მეორე ვარიანტი საქსესის მერეც რომ არ ჩერდება
        static void checkPassAndUsernameCringeWay()
        {
            // create a username and password
            string username = "123";
            string password = "123";

            int maxAttempts = 5;
            int attempts = 0;

            while (true)
            {
                Console.Write("Enter your username: ");
                string? inputUsername = Console.ReadLine();
                Console.Write("Enter your password: ");
                string? inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    Console.WriteLine("Success!");
                    attempts++;
                }
                if (inputUsername != username || inputPassword != password)
                {
                    attempts++;
                    Console.WriteLine("Incorrect username or password.");
                }

                if (attempts >= maxAttempts)
                {
                    Console.WriteLine("Opps! something gone wrong");
                    return;
                }
            }
        }

        // მეორე დავალების ორი ვარიანტი
        static void ConverterToBinaryFirsVariant()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine() ?? "0");

            string binary = Convert.ToString(number, 2);

            Console.WriteLine($"The binary representation of {number} is: {binary}");
        }
        static void ConverterToBinary(int number)
        {
            string binary = Convert.ToString(number, 2);
            Console.WriteLine($"The binary representation of {number} is: {binary}");
        }


        /// ------------ მესამე დავალება ----------
        static double Calculate(double length, double width)
        {
            return length * width;
        }

        static double Calculate(double length, double width, double height)
        {
            return length * width * height;
        }

    }
}
