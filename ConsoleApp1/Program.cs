namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userInfo = new string[7];
            string[] repertuar = { "12:00", "13:30", "15:00", "16:30", "18:00", "20:00" };
            string[] film = { "Krzyk 7", "Szrek", "Avengers Finał" };

            Console.WriteLine("Welcome to our ticket booking system\nOur actual sessions:");
            foreach (string i in film)
            {
                Console.WriteLine(i);
            }
            bool containsFilm = false;
            while (containsFilm == false)
            {
                Console.WriteLine("\nType your film:");

                string userFilm = Console.ReadLine().ToLower();

                foreach (string f in film)
                {
                    if (f.ToLower() == userFilm)
                    {
                        containsFilm = true;
                        break;
                    }
                }

                if (containsFilm == true)
                {
                    userInfo[0] = userFilm;
                    Console.WriteLine($"You chose {userFilm}.");
                }
                else if (containsFilm == false)
                {
                    Console.WriteLine("This film doesn't exist, write correct film");
                }
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Time for this movie:");
            foreach (string c in repertuar)
            {
                Console.WriteLine(c);
            }
            bool containsTime = false;

            while (containsTime == false)
            {
                Console.WriteLine("\nType your time:");
                string userTime = Console.ReadLine().ToLower();
                foreach (string r in repertuar)
                {
                    if (r.ToLower() == userTime)
                    {
                        containsTime = true;
                        break;
                    }
                }

                if (containsTime == true)
                {
                    userInfo[1] = userTime;
                    Console.WriteLine($"You chose time: {userTime}.");
                }
                else if (containsTime == false)
                {
                    Console.WriteLine("This time doesn't exist, write correct time");
                }
            }
            Console.ReadKey();
            Console.Clear();

            bool confirmation = false;

            while (confirmation == false) {
                Console.WriteLine("Type your name:");
                string userName = Console.ReadLine().ToLower();
                userInfo[2] = userName;

                Console.WriteLine("\nWrite your surname:");
                string userSurname = Console.ReadLine().ToLower();
                userInfo[3] = userSurname;

                Console.WriteLine("\nType your phone number:");
                Console.Write("+48"); string userPhone = Console.ReadLine().ToLower();
                if (userPhone.Length == 9)
                {
                    userInfo[4] = userPhone;
                } else 
                {
                    Console.WriteLine("Type a correct phone number");
                    userInfo[4] = Console.ReadLine();
                }

                Console.WriteLine("\nWrite your e-mail:");
                string userEmail = Console.ReadLine().ToLower();
                userInfo[5] = userEmail;

                Console.WriteLine("\nQuantity of tickets:");
                string userTickets = Console.ReadLine().ToLower();
                userInfo[6] = userTickets;
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Your reservation information:\n");
            
                    Console.WriteLine($"Your film is: {userInfo[0]}");
                    Console.WriteLine($"Your time is: {userInfo[1]}");
                    Console.WriteLine($"Your name is: {userInfo[2]}");
                    Console.WriteLine($"Your surname is: {userInfo[3]}");
                    Console.WriteLine($"Your phone number is: {userInfo[4]}");
                Console.WriteLine($"Your e-mail is: {userInfo[5]}");
                Console.WriteLine($"Number of tickets: {userInfo[6]}");


                Console.WriteLine("\nIs everything correct? (True/False)");
                confirmation = bool.Parse(Console.ReadLine().ToLower());

                    if (confirmation == true)
                    {
                        Console.WriteLine("Have a nice time!\nProgram's made by malikoyv");
                    }
                    else if (confirmation == false)
                    {
                        Console.WriteLine("Let's rewrite");
                        Console.Clear();
                    }
            }
        }
    }
}