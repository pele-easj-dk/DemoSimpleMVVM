using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSimpleMVVM.model
{
    class CarList
    {
        private List<Car> liste;

        public List<Car> Liste { get; }

        public void Add(String regNo, String model, int antalDøre)
        {
            liste.Add(new Car(regNo,model,antalDøre));
        }


    }
}
