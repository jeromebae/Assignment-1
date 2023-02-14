

using Assignment1;
using Classes_and_Inheritance_Assignment.Properties;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine
                ("Welcome to Modern Appliances!\n" +
                "How may we assist you?\n" +
                "1 - Check out appliance\n" +
                "2 - Find appliances by brand\n" +
                "3 - Display appliances by type\n" +
                "4 - Produce random appliance list\n" +
                "5 - Save & exit");
            Console.WriteLine("Enter option: ");
            int option = Int32.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Enter the item number of an appliance:");
                int itemNum = Int32.Parse(Console.ReadLine());
            }

            else if (option == 2)
            {

            }

            else if (option == 3)
            {

            }

            else if (option == 4)
            {

            }

            else
            {
                break;
            }
        }
    }
}