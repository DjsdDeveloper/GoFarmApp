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
    public class RegisterStepTwoViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService _navigationService;

        public DelegateCommand SiguienteCommand { get; private set; }
        public DelegateCommand VolverCommand { get; private set; }

        public ObservableCollection<string> pickEstado { get; set; }
        public ObservableCollection<string> pickMunicipio { get; set; }

        public RegisterStepTwoViewModel(INavigationService navigationServices)
        {
            #region INJECTION
            _navigationService = navigationServices;
            #endregion

            SiguienteCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"{nameof(Views.RegisterStepThree)}");
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
            pickEstado = new ObservableCollection<string>();
            pickEstado.Add("Nueva Esparta");
            pickEstado.Add("Sucre");
            pickEstado.Add("Monagas");

            pickMunicipio = new ObservableCollection<string>();
            pickMunicipio.Add("Mariño");
            pickMunicipio.Add("Díaz");
            pickMunicipio.Add("Villalba");
        }
    }
}
