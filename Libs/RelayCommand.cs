using System;
using System.Windows.Input;

namespace ClientXMessanger.Libs
{
    public class RelayCommand : ICommand
    {
        private Action _action { get; set; }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayCommand(Action action)
        {
            _action = action;
        }
    }
}
