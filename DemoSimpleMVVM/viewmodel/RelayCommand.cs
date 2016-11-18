using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoSimpleMVVM.viewmodel
{
    public class RelayCommand:ICommand
    {
        private Action command;

        public RelayCommand(Action command)
        {
            this.command = command;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            command();
        }

        public event EventHandler CanExecuteChanged;
    }
}
