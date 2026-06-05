using System;
using System.Collections.Generic;
using System.Text;

namespace Dairy_Management_System.Model
{
    internal class MilkRecord
    {
        public int Id { get; set; }     ///  use of get / set property
        public string FarmerName { get; set; }
        public string MilkType { get; set; }
        public double Liters { get; set; }
        public double Rate { get; set; }
    }
    
}
