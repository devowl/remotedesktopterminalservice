using System;
using System.Windows.Input;

namespace Rdp.Demostration.Prism
{
    /// <summary>
    /// DelegateCommand implementation.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;

        private readonly Action<object> _execute;

        /// <summary>
        /// Constructor for <see cref="DelegateCommand"/>.
        /// </summary>
        public DelegateCommand(Action<object> execute) : this(execute, null)
        {
        }

        /// <summary>
        /// Constructor for <see cref="DelegateCommand"/>.
        /// </summary>
        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Raise can execute command.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        /// <inheritdoc/>
        bool ICommand.CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }

            return _canExecute(parameter);
        }

        /// <inheritdoc/>
        void ICommand.Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}