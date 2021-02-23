using Acr.UserDialogs;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using TuFarmaApp.Models;
using TuFarmaApp.Views;
using Xamarin.Forms;

namespace TuFarmaApp.ViewModels
{
    public class MenuLoginViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService _navigationService;
        IUserDialogs _userDialogs;

        //public bool IsVisibleFrameFilter { get; set; }
        public bool IsVisibleFrameInformation { get; set; }
        

        //public DelegateCommand ActivarFilterCommand { get; private set; }
        public DelegateCommand ActivarInformationCommand { get; private set; }
        public DelegateCommand<object> CommandMenuTap { get; private set; }

        public MenuLoginViewModel(INavigationService navigationServices,
                                 IUserDialogs userDialogs)
        {
            #region INJECTION
            _navigationService = navigationServices;
            _userDialogs = userDialogs;
            #endregion

            //ActivarFilterCommand = new DelegateCommand(async () =>
            //{
            //    IsVisibleFrameInformation = false;
            //    if (IsVisibleFrameFilter)
            //    {
            //        IsVisibleFrameFilter = false;
            //    }
            //    else
            //    {
            //        IsVisibleFrameFilter = true;
            //    }
            //});

            ActivarInformationCommand = new DelegateCommand(async () =>
            {
                //IsVisibleFrameFilter = false;
                if (IsVisibleFrameInformation)
                {
                    IsVisibleFrameInformation = false;
                }
                else
                {
                    IsVisibleFrameInformation = true;
                }
            });

            CommandMenuTap = new DelegateCommand<object>(async (obj) => await Go(obj));
        }

        async Task Go(object obj)
        {
            var path = (obj as MenuModel).PageName;
            var navParameters = new NavigationParameters();

            //if (path.Equals(nameof(MethodPay)))
            //{
            //    navParameters.Add("delete", "1");
            //}

            //if (path.Equals(nameof(Addres)))
            //{
            //    navParameters.Add("delete", "1");
            //}

            //if (path.Equals(nameof(MisCompras)))
            //{
            //    await GoCompras();
            //    return;
            //}

            //if (path.Equals(nameof(RouteBuy1)))
            //{
            //    await GoRutas();
            //    return;
            //}

            //if (path.Equals(nameof(Carrito)))
            //{
            //    await GoCarrito();
            //    return;
            //}

            //if (path.Equals(nameof(ListViewPrueba)))
            //{
            //    navParameters.Add("delete", "1");
            //}

            //if (path.Equals(nameof(ProductPageD2)))
            //{
            //    navParameters.Add("delete", "1");
            //}

            if (path.Equals(nameof(LoginInit)))
            {
                await LogOut();
                return;
            }

            await _navigationService.NavigateAsync($"{path}", navParameters);
        }

        async Task LogOut()
        {
            //using (var dialog = UserDialogs.Instance.Progress("Procesando"))
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        await Task.Delay(1000);
            //        dialog.PercentComplete = i * 10;
            //    }

            //    await _navigationService
            //        .NavigateAsync($"/{nameof(NavigationPage)}/{nameof(LoginInit)}");
            //}

            using (_userDialogs.Loading("Por favor espere..."))
            {
                //await BlobCache.Secure.Invalidate("Auth");
                //await BlobCache.UserAccount.Invalidate("UserDataSession");

                //await BlobCache.Secure.InsertObject<InitialModel>("Initial", new InitialModel
                //{
                //    IsLoginLate = true
                //});

                //await Task.Delay(5000);

                await _navigationService
                    .NavigateAsync($"/{nameof(NavigationPage)}/{nameof(LoginInit)}");
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //IsVisibleFrameFilter = false;
            IsVisibleFrameInformation = false;
        }
    }
}
