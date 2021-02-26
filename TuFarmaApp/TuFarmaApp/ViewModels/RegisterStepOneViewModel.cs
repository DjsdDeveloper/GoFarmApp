using Acr.UserDialogs;
using Plugin.Media;
//using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using TuFarmaApp.Interfaces;
using TuFarmaApp.Models;
using Xamarin.Forms;

namespace TuFarmaApp.ViewModels
{
    public class RegisterStepOneViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService _navigationService;
        IUserDialogs _userDialogs;
        IPageDialogService _dialogService;
        //IMultiMediaPickerService _multiMediaPickerService;

        public DelegateCommand SiguienteCommand { get; private set; }
        public DelegateCommand VolverCommand { get; private set; }
        public DelegateCommand PhotoCommand { get; private set; }
        

        public ImageSource ImagenMedia { get; set; }
        public ObservableCollection<MediaFile> Media { get; set; } = new ObservableCollection<MediaFile>();
        public ObservableCollection<string> PickDoc { get; set; }
        public int SeleccionVariacion1 { get; set; } = -1;
        public string EntryDataFecha { get; set; }
        public string DataFecha { get; set; }
        public void OnDataFechaChanged()
        {
            EntryDataFecha = DataFecha[3].ToString() + DataFecha[4].ToString() + "/" +
                            DataFecha[0].ToString() + DataFecha[1].ToString() + "/" +
                            DataFecha[6].ToString() + DataFecha[7].ToString() + DataFecha[8].ToString() + DataFecha[9].ToString();
            //EntryDataFecha = DataFecha;
        }

        public RegisterStepOneViewModel(INavigationService navigationServices,
                                        IUserDialogs userDialogs,
                                        IPageDialogService dialogService
                                        /*IMultiMediaPickerService multiMediaPickerService*/)
        {
            #region INJECTION
            _navigationService = navigationServices;
            _userDialogs = userDialogs;
            //_multiMediaPickerService = multiMediaPickerService;
            _dialogService = dialogService;
            #endregion

            SiguienteCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync($"{nameof(Views.RegisterStepTwo)}");
            });

            VolverCommand = new DelegateCommand(async () =>
            {
                await _navigationService.GoBackAsync();
            });

            //PhotoCommand = new DelegateCommand(async () => await SelectTap());
            //PhotoCommand = new DelegateCommand(async () => await TomarTap());
            PhotoCommand = new DelegateCommand(async () => await OptionPhoto());
        }

        async Task OptionPhoto()
        {

            await _navigationService.NavigateAsync($"{nameof(Views.Popup.PopupPhoto)}", new NavigationParameters{
                    { "ImagenMedia", ImagenMedia }
                });
        }

        //async Task TomarTap()
        //{
        //    var photo =
        //        await Plugin.Media.CrossMedia.Current
        //            .TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions());
        //    if (photo != null)
        //    {
        //        ImagenMedia = ImageSource.FromStream(() =>
        //        {
        //            return photo.GetStream();
        //        });
        //    }
        //}

        //async Task SelectTap()
        //{
        //    //var hasPermission = await CheckPermissionsAsync();
        //    //if (hasPermission)
        //    //{
        //    //var rest = maxImage - (Media.Count - 1);
        //    //if (rest > 0)
        //    //{
        //    //await _multiMediaPickerService.PickPhotosAsync(1);
        //    //return;
        //    //}

        //    //canAddMore = false;
        //    //}

        //    //if (!CrossMedia.Current.IsPickPhotoSupported)
        //    //{
        //    //    await _dialogService.DisplayAlertAsync("Photos Not Supported", ":( Permission not granted to photos.", "OK");
        //    //    return;
        //    //}

        //    var hasPermission = await CheckPermissionsAsync();
        //    if (hasPermission)
        //    {
        //        var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
        //        {
        //            PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

        //        });


        //        if (file == null)
        //            return;

        //        ImagenMedia = ImageSource.FromStream(() =>
        //        {
        //            var stream = file.GetStream();
        //            file.Dispose();
        //            return stream;
        //        });

        //    }                
        //}

        //async Task<bool> CheckPermissionsAsync()
        //{
        //    var retVal = false;
        //    try
        //    {
        //        var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Storage);
        //        if (status != PermissionStatus.Granted)
        //        {
        //            if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Plugin.Permissions.Abstractions.Permission.Storage))
        //            {
        //                await _dialogService.DisplayAlertAsync("Confirmación", "Necesitas proporcionar permiso para acceder a tus fotos", "Aceptar");
        //            }

        //            var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Plugin.Permissions.Abstractions.Permission.Storage });
        //            status = results[Plugin.Permissions.Abstractions.Permission.Storage];
        //        }

        //        if (status == PermissionStatus.Granted)
        //        {
        //            retVal = true;

        //        }
        //        else if (status != PermissionStatus.Unknown)
        //        {
        //            await _dialogService.DisplayAlertAsync("Confirmación", "Permiso negado. No puede continuar, intenta nuevamente.", "Aceptar");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        await _dialogService.DisplayAlertAsync("Confirmación", "Error. No puede continuar, intenta nuevamente.", "Aceptar");
        //    }

        //    return retVal;
        //}

        //private void _multiMediaPickerService_OnMediaPicked(object sender, MediaFile e)
        //{
        //    var url = e.PreviewPath;
        //    ImagenMedia = e.PreviewPath;

        //    Media.Clear();
        //    Media.Add(e);

        //    return;
        //}

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //_multiMediaPickerService.OnMediaPicked += _multiMediaPickerService_OnMediaPicked;

            if (parameters.ContainsKey("ImagenMedia"))
            {
                ImagenMedia = parameters["ImagenMedia"] as ImageSource;
            }
            else
            {
                if (parameters.ContainsKey("BackImagenMedia"))
                {
                    ImagenMedia = parameters["BackImagenMedia"] as ImageSource;
                }
                else
                {
                    ImagenMedia = ImageSource.FromResource("TuFarmaApp.Img.Cam.png");
                }
            }

            PickDoc = new ObservableCollection<string>();
            PickDoc.Add("V");
            PickDoc.Add("E");
            PickDoc.Add("J");
            SeleccionVariacion1 = 0;
        }
    }
}