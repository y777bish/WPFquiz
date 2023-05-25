using System;
using System.Windows.Input;

namespace QuizOstateczny.ViewModel
{
    class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> execute;
        private Predicate<object> canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute) 
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}