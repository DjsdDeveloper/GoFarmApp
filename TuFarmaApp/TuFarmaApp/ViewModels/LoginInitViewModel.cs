using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TuFarmaApp.ViewModels
{
    public class LoginInitViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService _navigationService;

        public DelegateCommand RegisterCommand { get; private set; }
        public DelegateCommand CommandPoliticas { get; private set; }
        public DelegateCommand CommandTerminos { get; private set; }        

        public LoginInitViewModel(INavigationService navigationServices)
        {
            #region INJECTION
            _navigationService = navigationServices;
            #endregion

            RegisterCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"{nameof(Views.RegisterStepOne)}");
            });

            CommandPoliticas = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"{nameof(Views.PoliticasPage)}");
            });

            CommandTerminos = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"{nameof(Views.TerminosPage)}");
            });
        }


        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }
    }
}
