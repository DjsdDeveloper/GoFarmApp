using Acr.UserDialogs;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TuFarmaApp.ViewModels.Popup
{
    public class PopupPhotoViewModel : INotifyPropertyChanged, INavigationAware
    {
        public DelegateCommand CancelCommand { get; private set; }
        public DelegateCommand GoCommand { get; private set; }
        public DelegateCommand TomarCommand { get; private set; }
        public DelegateCommand GaleriaCommand { get; private set; }

        INavigationService _navigationService;
        IUserDialogs _userDialogs;
        IPageDialogService _dialogService;

        public event PropertyChangedEventHandler PropertyChanged;

        public ImageSource ImagenMedia { get; set; }


        public PopupPhotoViewModel(INavigationService navigationService,
                                   IUserDialogs userDialogs,
                                   IPageDialogService dialogService)
        {
            _userDialogs = userDialogs;
            _navigationService = navigationService;
            _dialogService = dialogService;

            CancelCommand = new DelegateCommand(CancelClick);
            GoCommand = new DelegateCommand(GoClick);

            TomarCommand = new DelegateCommand(async () => await TomarTap());
            GaleriaCommand = new DelegateCommand(async () => await SelectPhoto());
        }

        async Task TomarTap()
        {
            var photo =
                await Plugin.Media.CrossMedia.Current
                    .TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions());
            if (photo != null)
            {
                ImagenMedia = ImageSource.FromStream(() =>
                {
                    return photo.GetStream();
                });

                await _navigationService.GoBackAsync(new NavigationParameters{
                    { "ImagenMedia", ImagenMedia }
                });
            }
        }

        async Task SelectPhoto()
        {
            //var hasPermission = await CheckPermissionsAsync();
            //if (hasPermission)
            //{
            //var rest = maxImage - (Media.Count - 1);
            //if (rest > 0)
            //{
            //await _multiMediaPickerService.PickPhotosAsync(1);
            //return;
            //}

            //canAddMore = false;
            //}

            //if (!CrossMedia.Current.IsPickPhotoSupported)
            //{
            //    await _dialogService.DisplayAlertAsync("Photos Not Supported", ":( Permission not granted to photos.", "OK");
            //    return;
            //}

            var hasPermission = await CheckPermissionsAsync();
            if (hasPermission)
            {
                var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

                });


                if (file == null)
                    return;

                ImagenMedia = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });

                await _navigationService.GoBackAsync(new NavigationParameters{
                    { "ImagenMedia", ImagenMedia }
                });
            }
        }

        async Task<bool> CheckPermissionsAsync()
        {
            var retVal = false;
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Storage);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Plugin.Permissions.Abstractions.Permission.Storage))
                    {
                        await _dialogService.DisplayAlertAsync("Confirmación", "Necesitas proporcionar permiso para acceder a tus fotos", "Aceptar");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Plugin.Permissions.Abstractions.Permission.Storage });
                    status = results[Plugin.Permissions.Abstractions.Permission.Storage];
                }

                if (status == PermissionStatus.Granted)
                {
                    retVal = true;

                }
                else if (status != PermissionStatus.Unknown)
                {
                    await _dialogService.DisplayAlertAsync("Confirmación", "Permiso negado. No puede continuar, intenta nuevamente.", "Aceptar");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                await _dialogService.DisplayAlertAsync("Confirmación", "Error. No puede continuar, intenta nuevamente.", "Aceptar");
            }

            return retVal;
        }

        async void CancelClick()
        {
            await _navigationService.GoBackAsync(new NavigationParameters{
                    { "BackImagenMedia", ImagenMedia }
                });
        }
        async void GoClick()
        {
            //var acepto = await BlobCache.Secure.InsertObject<bool>("acepto", true);
            await _navigationService.GoBackAsync();

            ////await PopupNavigation.PopAsync();
            //var url = _navigationService.GetNavigationUriPath();
            //Console.WriteLine(url);
            //await _navigationService.GoBackAsync(new NavigationParameters{
            //    { "view2", "Views.Grial.Addres" },
            //    { "flag", "1" }
            //});
            ////await _navigationService.NavigateAsync($"{nameof(Views.Market.ProductPage)}/{nameof(Views.LoginPage)}", useModalNavigation: false);
            ////await _navigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(Views.Grial.MethodPay)}");
            ////await _navigationService.ClearPopupStackAsync(); //Close the current popup
            ////Console.WriteLine(_navigationService.GetNavigationUriPath());

            ////await _navigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(Views.Grial.MethodPay)}");
            ////await _navigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(Views.Grial.MethodPay)}");
            ////await _navigationService.NavigateAsync($"{nameof(ProductPage)}/{nameof(NavigationPage)}/{nameof(Views.Grial.MethodPay)}");
            ////await _navigationService.NavigateAsync($"../{nameof(Views.Grial.MethodPay)}");
            ////await _navigationService.NavigateAsync($"../");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("ImagenMedia"))
            {
                ImagenMedia = parameters["ImagenMedia"] as ImageSource;
            }
        }
    }
}
