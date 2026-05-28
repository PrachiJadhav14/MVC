using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_MVC
{
    using System;

    class Program
    {
        static void Main()
        {
            StudentService service = new StudentService();

            while (true)
            {
                Console.WriteLine("\n1.Add 2.Show 3.Update 4.Delete");
                Console.Write("Enter Choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 1)
                {
                    Student s = new Student();

                    Console.Write("Id: ");
                    s.Id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Name: ");
                    s.Name = Console.ReadLine();

                    Console.Write("City: ");
                    s.City = Console.ReadLine();

                    service.Add(s);
                }

                else if (ch == 2)
                {
                    service.Show();
                }

                else if (ch == 3)
                {
                    Student s = new Student();

                    Console.Write("Id: ");
                    s.Id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("New Name: ");
                    s.Name = Console.ReadLine();

                    Console.Write("New City: ");
                    s.City = Console.ReadLine();

                    service.Update(s);
                }

                else if (ch == 4)
                {
                    Console.Write("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    service.Delete(id);
                }
            }
        }
    }
}