using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuFarmaApp.Models;
using Xamarin.Forms;

namespace TuFarmaApp.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService _navigationService;
     
        public ObservableCollection<ProductModel> Products { get; set; }
        public List<string> Carouselsourse { get; set; }

        public HomePageViewModel(INavigationService navigationServices)
        {
            #region INJECTION
            _navigationService = navigationServices;
            #endregion

            Products = new ObservableCollection<ProductModel>();

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
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
