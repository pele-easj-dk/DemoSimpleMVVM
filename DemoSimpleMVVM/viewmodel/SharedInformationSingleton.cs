using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSimpleMVVM.model;

namespace DemoSimpleMVVM.viewmodel
{
    class SharedInformationSingleton
    {
        // singleton
        private SharedInformationSingleton()
        {
            liste = new ObservableCollection<Car>();
            liste.Add(new Car("zz23456", "audi", 5));
            liste.Add(new Car("aa12345", "vw", 5));

        }

        //private static SharedInformationSingleton instance = new SharedInformationSingleton();
        private static SharedInformationSingleton instance;
        public static SharedInformationSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new SharedInformationSingleton();

                return instance;
            }
        }

        // Slut singleton

        private ObservableCollection<Car> liste;
        public ObservableCollection<Car> Liste
        {
            get { return liste; }
        }


    }
}
