using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TuFarmaApp.ViewModels
{
    public class RegisterStepOneViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService _navigationService;

        public DelegateCommand SiguienteCommand { get; private set; }
        public DelegateCommand VolverCommand { get; private set; }
        public DelegateCommand PhotoCommand { get; private set; }
        

        public ImageSource ImagenMedia { get; set; }
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

        public RegisterStepOneViewModel(INavigationService navigationServices)
        {
            #region INJECTION
            _navigationService = navigationServices;
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
        }

        //async Task SelectTap()
        //{
        //    var hasPermission = await CheckPermissionsAsync();
        //    if (hasPermission)
        //    {
        //        //var rest = maxImage - (Media.Count - 1);
        //        //if (rest > 0)
        //        //{
        //        await _multiMediaPickerService.PickPhotosAsync(1);
        //        return;
        //        //}

        //        //canAddMore = false;
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
            ImagenMedia = ImageSource.FromResource("TuFarmaApp.Img.Cam.png");

            PickDoc = new ObservableCollection<string>();
            PickDoc.Add("V");
            PickDoc.Add("E");
            PickDoc.Add("J");
            SeleccionVariacion1 = 0;
        }
    }
}