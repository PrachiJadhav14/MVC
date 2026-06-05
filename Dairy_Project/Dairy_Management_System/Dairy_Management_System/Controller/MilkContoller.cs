using Dairy_Management_System.Model;
using Dairy_Management_System.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dairy_Management_System.Controller
{
    internal class MilkContoller
    {


        private List<MilkRecord> records = new List<MilkRecord>();
        private MilkView view = new MilkView();

        public void Start()
        {
            while (true)
            {
                view.ShowMenu();

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddRecord();
                        break;

                    case 2:
                        ShowAll();
                        break;

                    case 3:
                        Search();
                        break;

                    case 4:
                        Update();
                        break;
                        
                    case 5:
                        Delete();
                        break;

                    case 6:
                        return;

                    default:
                        view.ShowMessage("Invalid Choice");
                        break;
                }
            }
        }

        private void AddRecord()
        {
            MilkRecord m = new MilkRecord();

            Console.Write("Id : ");
            m.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Customer Name : ");
            m.FarmerName = Console.ReadLine();

            Console.Write("Milk Type : ");
            m.MilkType = Console.ReadLine();

            Console.Write("Liters : ");
            m.Liters = Convert.ToDouble(Console.ReadLine());

            Console.Write("Rate : ");
            m.Rate = Convert.ToDouble(Console.ReadLine());

            records.Add(m);

            Console.ForegroundColor = ConsoleColor.Green;
            view.ShowMessage("✅ Record Added Successfully");
            Console.ResetColor();
        }

        private void ShowAll()
        {
            foreach (var item in records)
            {
                Console.WriteLine("\n══════════********════════════\n");
                Console.WriteLine("📋 ALL RECORDS");
                Console.WriteLine("\n══════════********════════════\n");

                Console.WriteLine("🆔 Id : " + item.Id);
                Console.WriteLine("👤 Farmer : " + item.FarmerName);
                Console.WriteLine("🥛 Milk : " + item.MilkType);
                Console.WriteLine("📦 Liters : " + item.Liters);
                Console.WriteLine("💰 Rate : " + item.Rate);
                Console.WriteLine("Amount : " + (item.Liters * item.Rate));
            }
        }

        private void Search()
        {
            Console.Write("Enter Customer Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            var record = records.Find(x => x.Id == id);

            if (record != null)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n════****** CUSTOMER DETAILS ******════\n");

                Console.WriteLine("👤 Customer Name : " + record.FarmerName);
                Console.WriteLine("🥛 Milk Type : " + record.MilkType);
                Console.WriteLine("📦 Litters : " + record.Liters);
                Console.WriteLine("💰 Rate : " + record.Rate);

                Console.ResetColor();
                Console.WriteLine("\n════════════****************════════════\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                view.ShowMessage("\n❌ Record Not Found");
                Console.ResetColor();
            }
        }

        private void Update()
        {
            Console.Write("Enter Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            var record = records.Find(x => x.Id == id);

            if (record != null)
            {
                Console.Write("New Customer Name : ");
                record.FarmerName = Console.ReadLine();

                Console.Write("New Milk Type : ");
                record.MilkType = Console.ReadLine();

                Console.Write("New Liters : ");
                record.Liters = Convert.ToDouble(Console.ReadLine());

                Console.Write("New Rate : ");
                record.Rate = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor= ConsoleColor.Gray;
                view.ShowMessage("✅ Updated Successfully");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                view.ShowMessage("\n❌ Record Not Found\n");
                Console.ResetColor();
            }
        }

        private void Delete()
        {
            Console.Write("Enter Customer Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            var record = records.Find(x => x.Id == id);

            if (record != null)
            {
                records.Remove(record);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                view.ShowMessage("\n✅ Deleted Successfully");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                view.ShowMessage("\n❌ Record Not Found\n");
                Console.ResetColor();
            }
        }
    }
}