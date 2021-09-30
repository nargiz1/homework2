using System;
using System.Collections.Generic;
using System.Text;

namespace ClassComputer
{
    class Computer
    {
        public string CPU;
        public int HDD;
        public string SystemSoftware;
        public int RAM;
        public Computer(string CPU, int HDD, string SystemSoftware, int RAM)
        {
            this.CPU = CPU;
            this.HDD = HDD;
            this.SystemSoftware = SystemSoftware;
            this.RAM = RAM;
        }
    }
}
