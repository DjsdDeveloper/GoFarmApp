using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace TuFarmaApp.ViewModels
{
    public class RegisterStepThreeViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService _navigationService;

        public DelegateCommand SiguienteCommand { get; private set; }
        public DelegateCommand VolverCommand { get; private set; }

        public RegisterStepThreeViewModel(INavigationService navigationServices)
        {
            #region INJECTION
            _navigationService = navigationServices;
            #endregion

            SiguienteCommand = new DelegateCommand(async () =>
            {
                //await _navigationService.NavigateAsync($"{nameof(Views.RegisterStepThree)}");
            });

            VolverCommand = new DelegateCommand(async () =>
            {
                await _navigationService.GoBackAsync();
            });
        }
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
    }
}