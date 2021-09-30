using System;
using System.Collections.Generic;
using System.Text;

namespace ClassComputer
{
    class Laptop:Computer
    {
        public int battery;
        public int MaxOpeningAngle;
        public string brand;

        public Laptop(string CPU, int HDD, string SystemSoftware, int RAM, int battery, int MaxOpeningAngle, string brand):base(CPU, HDD, SystemSoftware, RAM)
        {
            this.battery = battery;
            this.MaxOpeningAngle = MaxOpeningAngle;
            this.brand = brand;
        }
    }
}
