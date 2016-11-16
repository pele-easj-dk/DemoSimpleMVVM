using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        private void Start()
        {
            observable ob = new observable();
            ob.PropertyChanged += ObserverMetode1;
            ob.Name = "peter";

            ob.PropertyChanged += ObserverMetode2;
            ob.Number = 12345;

            Console.ReadLine();
        }

        private void ObserverMetode2(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("Property derer ændret er " + e.PropertyName);
        }

        private void ObserverMetode1(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            Console.WriteLine($"Metode 1 ob = " + sender.ToString());
            
        }

        public Program()
        {
        }


    }
}
