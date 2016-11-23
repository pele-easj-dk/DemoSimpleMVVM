using System;
using System.ComponentModel;
using System.Reflection;

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
            Observable ob = new Observable();

            Console.WriteLine();
            Console.WriteLine("---> One method assigned as observer");
            Console.WriteLine();
            ob.PropertyChanged += ObserverMetode1;  // observer med metoden ObserverMetode1
            ob.Name = "peter";

            Console.WriteLine();
            Console.WriteLine("---> two method assigned as observer");
            Console.WriteLine();
            ob.PropertyChanged += ObserverMetode2;
            ob.Number = 12345;

            Console.WriteLine();
            Console.WriteLine("---> first method removed as observer");
            Console.WriteLine();
            ob.PropertyChanged -= ObserverMetode1;
            ob.Number = 54321;

            Console.WriteLine();
            Console.WriteLine("---> Item property do not send a notification");
            Console.WriteLine();
            ob.Item = "MyItem";

            Console.WriteLine();
            Console.WriteLine("---> Name property do send a notification");
            Console.WriteLine();
            ob.Name = "Martin";



            Console.ReadLine();
        }

        private void ObserverMetode1(object sender, PropertyChangedEventArgs e)
        {
            String propName = e.PropertyName;

            PropertyInfo[] pInfos = sender.GetType().GetProperties();
            foreach (PropertyInfo pi in pInfos)
            {
                if (pi.Name == propName)
                {
                    String value = sender.GetType().GetProperty(propName).GetValue(sender).ToString();
                    Console.WriteLine($"Property der er ændret er {propName} = {value}");
                }
                
            }
        }

        private void ObserverMetode2(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            Console.WriteLine($"Metode 2 ob = " + sender.ToString());
            
        }

        public Program()
        {
        }


    }
}
