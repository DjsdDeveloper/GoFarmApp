using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuFarmaApp.Models;
using TuFarmaApp.Views;
using Xamarin.Forms;

namespace TuFarmaApp.ViewModels
{
    public class MainHomeViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService _navigationService;

        public ObservableCollection<ProductModel> Products { get; set; }
        public List<string> Carouselsourse { get; set; }
        public bool IsConectivityDisable { get; set; }


        public DelegateCommand<object> MenuCommand { get; private set; }

        public MainHomeViewModel(INavigationService navigationServices)
        {
            #region INJECTION
            _navigationService = navigationServices;
            #endregion

            Products = new ObservableCollection<ProductModel>();

            MenuCommand = new DelegateCommand<object>(async opt =>
            {
                var option = (int)opt;
                //var IsLogged = await ValidateSesion();
                Debug.WriteLine("menu Option " + option);

                if (option == 4)
                {
                    // MENU
                    //if (IsLogged)
                    //{
                    //    await _navigationService.NavigateAsync(nameof(MenuPage));
                    //    return;
                    //}
                    //await _navigationService.NavigateAsync(nameof(MenuLoginLater));

                    await _navigationService.NavigateAsync(nameof(MenuMain));
                    return;
                }

                //if (option == 0)
                //    return;

                //if (!IsLogged)
                //{
                //    await _navigationService.NavigateAsync($"{nameof(Views.Grial.Popup.PopupFacturacion)}", useModalNavigation: false);
                //    return;
                //}

                //if (option == 1)
                //{
                //    // C-CARD
                //    await _navigationService.NavigateAsync(nameof(Views.Grial.CcardBalancePage), new NavigationParameters
                //    {
                //        { "HasMenuButtom", true }
                //    });
                //}

                //if (option == 2)
                //{
                //    // VENDER
                //    GoVender();
                //}

                //if (option == 3)
                //{
                //    // GUARDADOS
                //    await _navigationService.NavigateAsync(nameof(ProductSavedPage));
                //}
            });
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            IsConectivityDisable = false;

            List<string> banner = new List<string>();
            //banner.Add("resource://TuFarmaApp.Img.BannerHome.1.jpg");
            banner.Add("resource://TuFarmaApp.Img.BannerHome.2.jpg");
            banner.Add("resource://TuFarmaApp.Img.BannerHome.3.jpg");
            banner.Add("resource://TuFarmaApp.Img.BannerHome.4.jpg");
            banner.Add("resource://TuFarmaApp.Img.BannerHome.5.jpg");
            banner.Add("resource://TuFarmaApp.Img.BannerHome.6.jpg");

            App.IndexSetting = banner.Count();

            Carouselsourse = banner;

            List<string> pictures = new List<string>();
            pictures.Add("resource://TuFarmaApp.Img.GoFarmaAppLogo.png");
            pictures.Add("resource://TuFarmaApp.Img.GoFarmaAppLogo.png");
            pictures.Add("resource://TuFarmaApp.Img.GoFarmaAppLogo.png");

            for (int i = 0; i < 20; i++)
            {
                ProductModel ModelPrueba = new ProductModel()
                {
                    Title = "Titulo " + (i + 1),
                    Pictures = pictures
                };
                Products.Add(ModelPrueba);
            }
        }
    }
}

