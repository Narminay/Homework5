using Homework5;
using static System.Collections.Specialized.BitVector32;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Username:");
        string Username = Console.ReadLine();
        Console.WriteLine("Password:");
        string Password = Console.ReadLine();
        Admin admin = new(true, "Slider section","","");
        if (admin.IsSuperAdmin==true)
        {
            Console.WriteLine(admin.Showdata);
        }
        else
        {
            Console.WriteLine("False!");
        }

        Console.WriteLine("Admin:" + admin.Return());
    }
}
