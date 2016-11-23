using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern
{
    class Observable:INotifyPropertyChanged
    {
        private int number;
        private String name;
        private String item;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged("Number");   
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Item
        {
            get { return item; }
            set { item = value; } // No notify !! 
        }

        public Observable()
        {
        }


        public override string ToString()
        {
            return $"Number: {number}, Name: {name}, Item: {item}";
        }


        public event PropertyChangedEventHandler PropertyChanged; // liste af observere

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
