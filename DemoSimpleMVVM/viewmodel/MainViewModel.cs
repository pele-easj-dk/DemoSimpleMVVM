using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DemoSimpleMVVM.Annotations;
using DemoSimpleMVVM.model;


namespace DemoSimpleMVVM.viewmodel
{
    class MainViewModel : INotifyPropertyChanged
    {
        // attribut
        private String sometext;
        private Car aCar;
        private RelayCommand createCar;
        private SharedInformationSingleton common;


        // property
        public String Sometext
        {
            get { return sometext; }
            set
            {
                sometext = value;
                Car c = new Car(value, "vw", 3);
                ACar = c;
                NotifyView("Sometext");
            }
        }

        public SharedInformationSingleton Common
        {
            get { return common; }
        }

        public RelayCommand CreateCarCommand
        {
            get { return createCar;}
        }
        

        public Car ACar
        {
            get { return aCar; }
            set
            {
                aCar = value;
                NotifyView("ACar");
            }
        }


        /// <summary>
        /// Dette er en konstruktør til at initialiserer alle attributter/instans variable
        /// </summary>
        public MainViewModel()
        {
            Sometext = "load værdi";
            ACar = new Car("Dummy123", "Dummy", 0);
            
            common = SharedInformationSingleton.Instance;
            createCar = new RelayCommand(CreateCar);


        }

        // for at opdatere view
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyView(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            //}
            //public event PropertyChangedEventHandler PropertyChanged;

            //[NotifyPropertyChangedInvocator]
            //protected virtual void NotifyView([CallerMemberName] string propertyName = null)
            //{
            //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //}
        }

        public void CreateCar()
        {
            Car car = new Car(sometext, "audi", 5);
            common.Liste.Add(car);
        }
    }
}
