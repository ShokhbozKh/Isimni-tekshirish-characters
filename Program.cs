namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "jeck", "Jako", "Kol9oi" };

            for (int i = 0; i < names.Length; i++)
            {
                if (ValidName(names[i]))
                {
                    Console.WriteLine("okeyyyyyyyyyy");
                }
                else
                {
                    Console.WriteLine("nooooooooooo");
                }
            }


        }
        static bool ValidName(string names)
        {
            int count = 0;
           
            for (int i = 0; i < names.Length; i++)
            {
                if (char.IsLetter(names[i]))
                {
                    count++;
                }
                else
                {
                    break;
                }
                
            }
            return count==names.Length && char.IsUpper(names[0]);

        }
    }
}