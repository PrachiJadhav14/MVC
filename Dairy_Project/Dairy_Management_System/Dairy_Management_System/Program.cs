using Dairy_Management_System.Controller;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        MilkContoller controller = new MilkContoller();

        controller.Start();
    }
}