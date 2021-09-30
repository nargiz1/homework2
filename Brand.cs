using System;
using System.Collections.Generic;
using System.Text;

namespace ClassComputer
{
    class Brand:Laptop
    {
        public string model;
        public string Innovation;

        public Brand(string CPU, int HDD, string SystemSoftware, int RAM, int battery, int MaxOpeningAngle, string model, string Innovation, string brand):base(CPU, HDD, SystemSoftware, RAM, battery, MaxOpeningAngle, brand)
        {
            this.model = model;
            this.Innovation = Innovation;
            Console.WriteLine($"Brand: {brand} Model: {model} CPU: {CPU} HDD: {HDD} System Software: {SystemSoftware} RAM: {RAM} Battery: {battery} Max Opening Angle: {MaxOpeningAngle} Innovation: {Innovation}");
            
        }
    }

    
}
