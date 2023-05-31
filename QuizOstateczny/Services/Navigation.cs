using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOstateczny.Services
{
    public interface INavigationService
    {
        AnotherViewModel CurrentView { get; }
        /*void Navigate<T>() where T : AnotherViewModel;*/

    }

    public class Navigation : ObservableObject, INavigationService
    {
        //Properties
        private AnotherViewModel _currentView;
        private readonly Func<Type, AnotherViewModel> _anotherViewModelFactory;
        public AnotherViewModel CurrentView
        {
            get => _currentView;
            private set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        //Ctor
        public Navigation(Func<Type, AnotherViewModel> anotherViewModelFactory)
        {
            _anotherViewModelFactory = anotherViewModelFactory;
        }

        public void Navigate<T>() where T : AnotherViewModel
        {
            throw new NotImplementedException();
        }

        //Methods
        public void NavigateTo<TAnotherViewModel>() where TAnotherViewModel : AnotherViewModel
        {
            AnotherViewModel anotherViewModel = _anotherViewModelFactory.Invoke(typeof(TAnotherViewModel));
            CurrentView = anotherViewModel;
        }
    }
}
