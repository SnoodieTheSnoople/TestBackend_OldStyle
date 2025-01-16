namespace TestBackend_OldStyle;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is a test for developing the backend for an online vehicle Service Book");
        
        Console.WriteLine("Menu:");
        Console.WriteLine("1) View");
        Console.WriteLine("2) Add");
        Console.WriteLine("3) Edit");
        
        int choice = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(choice);
        
    }
}