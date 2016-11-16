using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserverPattern
{
    class observable:INotifyPropertyChanged
    {
        private int number;
        private String name;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged();   
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public observable()
        {
        }

        public override string ToString()
        {
            return $"Number: {number}, Name: {name}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
