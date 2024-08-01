namespace Anagram.UI
{
    using Anagram.BL;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to reverse him (enter \"exit\" to close program):");
            while (true)
            {
                try
                {
                    Console.Write("Enter : [");
                    var text = Console.ReadLine();
                    Console.CursorTop--;
                    Console.CursorLeft = text.Length + 9;
                    Console.WriteLine("]");

                    if (text.ToLower().Equals("exit"))
                    {
                        break;
                    }
                    Console.WriteLine("Result: [{0}]", Anagram.ReverseText(text));
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Result: [{0}]", exception.Message);
                }

            }


        }
    }
}
