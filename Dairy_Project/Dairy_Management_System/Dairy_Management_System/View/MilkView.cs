using System;
using System.Collections.Generic;
using System.Text;

namespace Dairy_Management_System.View
{
    internal class MilkView
    {
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n============***************================");
            Console.WriteLine(" \n🥛 DAIRY MANAGEMENT SYSTEM \U0001f95b\n ");
            Console.WriteLine("============***************================\n");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("➕ 1. Add Record");
            Console.WriteLine("📋 2. Show All Records");
            Console.WriteLine("🔍 3. Search Record");
            Console.WriteLine("✏️  4. Update Record");
            Console.WriteLine("🗑️ 5. Delete Record");
            Console.WriteLine("🚪 6. Exit");
            Console.Write("\n 👉 Enter Youre Choice : ");
            Console.ResetColor();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
