using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DemoSimpleMVVM.Annotations;

namespace DemoSimpleMVVM.model
{
    class Car:INotifyPropertyChanged
    {
        // attributter
        private String regNo;
        private String model;
        private int antalDøre;

        // properties
        //public String RegNo { get ; set ;  }  // implicit et privat felt bagved
        public String RegNo { get { return regNo; } set { regNo = value; } }
        public String Model { get { return model; } set { model = value; } }
        public int AntalDøre { get { return antalDøre; } set { antalDøre = value; } }

        //konstruktører
        public Car(): this("Dummy123","Dummy", 0)
        {
            
        }

        public Car(string regNo, String model, int antaldøre)
        {
            this.regNo = regNo;
            this.model = model;
            this.antalDøre = antaldøre;
        }

        public override String ToString()
        {
            return $"regno={regNo} model={model} antaldøre={antalDøre}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
