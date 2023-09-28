using System;

class Program
{
    //ODEVİ CHAT GPT YE SORDUM
    static void Main(string[] args)
    {
        string[] students = { "Mahmut", "Mehmet", "Cem" };
        bool[] isPresent = new bool[students.Length];

        Console.WriteLine("Hi, these are my students!");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{i + 1:00}. {students[i]}");
        }

        while (true)
        {
            Console.WriteLine("Tell me who is in class?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int studentNumber))
            {
                if (studentNumber >= 1 && studentNumber <= students.Length)
                {
                    if (!isPresent[studentNumber - 1])
                    {
                        isPresent[studentNumber - 1] = true;
                        Console.WriteLine($"{students[studentNumber - 1]} is present in class.");
                    }
                    else
                    {
                        Console.WriteLine($"{students[studentNumber - 1]} is already marked as present.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid student number. Please enter a valid student number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid student number.");
            }

            bool allPresent = true;
            foreach (bool present in isPresent)
            {
                if (!present)
                {
                    allPresent = false;
                    break;
                }
            }

            if (allPresent)
            {
                Console.WriteLine("All students are present in class. Exiting the program.");
                break;
            }
        }
    }
}
