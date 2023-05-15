namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var schoolSubject = Console.ReadLine();

            switch (schoolSubject.ToLower())
            {
                case "math":
                    {
                        Console.WriteLine("Your favorite subject is math");
                    }
                    break;

                case "science":
                    {
                        Console.WriteLine("Your favorite subject is math");
                    }
                    break;

                case "pe":
                    {
                        Console.WriteLine("Your favorite subject is math");
                    }
                    break;

                case "english":
                    {
                        Console.WriteLine("Your favorite subject is math");
                    }
                    break;

                case "history":
                    {
                        Console.WriteLine("Your favorite subject is math");
                    }
                    break;

                default:
                    {
                        Console.WriteLine($"Your favorite subject is {schoolSubject}");
                    }
                    break;
            }
        }
    }
}
