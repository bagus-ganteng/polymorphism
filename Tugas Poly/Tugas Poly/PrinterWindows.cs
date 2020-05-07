using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Poly
{
    public class PrinterWindows
    {
        //properties
        public string Name { get; set; }

        //method
        public virtual void Show()
        {
            Console.WriteLine("Display dimension");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printing ...");
        }

        public void Jeneng()
        {
            Console.WriteLine("\n\nMohamad Bagus Rizky \nIF02 \n19.11.2711");
        }
    }


    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }
    public class Lasetjet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LasetJet display dimension : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("LasetJet printer printing ...");
        }
    }

}
