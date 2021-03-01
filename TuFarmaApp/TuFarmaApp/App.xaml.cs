using Acr.UserDialogs;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Plugin.Popups;
using System;
using TuFarmaApp.Styles;
using TuFarmaApp.ViewModels;
using TuFarmaApp.ViewModels.Popup;
using TuFarmaApp.Views;
using TuFarmaApp.Views.Popup;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace TuFarmaApp
{
    public partial class App : PrismApplication
    {
        public string navigationPage = nameof(NavigationPage);

        public static int screenHeight, screenWidth;
        public static int IndexSetting = 1;

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            try
            {

                Resources = new GlobalStyles();

                InitializeComponent();

                Akavache.Registrations.Start("TuFarmaApp");

                //var InitialConfig = BlobCache.Secure.GetObject<InitialModel>("Initial")
                //.Catch(Observable.Return(new InitialModel()))
                //.Wait();

                // esto establece el culture info de la aplicacion
                // esta solucion no es definitiva
                //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-GT");

                //if (InitialConfig.IsFirstTime)
                //{
                //    var navParameters = new NavigationParameters();
                //    navParameters.Add("appvar", "1");
                //    await NavigationService.NavigateAsync($"{nameof(Wizard)}", navParameters);
                //}
                //else if (InitialConfig.IsLoginLate)
                //{
                //    await NavigationService
                //        .NavigateAsync($"/{nameof(NavigationPage)}/{nameof(MarketMainPageD2)}");
                //}
                //else if (InitialConfig.IsLogged)
                //{
                //    await NavigationService.NavigateAsync($"{nameof(Views.RegisterAddres)}");
                //}

                //await NavigationService.NavigateAsync($"{nameof(Views.LoginPage)}");
                //await NavigationService.NavigateAsync($"{nameof(Views.Login)}");
                await NavigationService.NavigateAsync($"{nameof(Views.LoginInit)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            #region Declaracion de vistas
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginInit, LoginInitViewModel>(); 
            containerRegistry.RegisterForNavigation<RegisterStepOne, RegisterStepOneViewModel>(); 
            containerRegistry.RegisterForNavigation<RegisterStepTwo, RegisterStepTwoViewModel>(); 
            containerRegistry.RegisterForNavigation<RegisterStepThree, RegisterStepThreeViewModel>(); 
            containerRegistry.RegisterForNavigation<PoliticasPage, PoliticasPageViewModel>(); 
            containerRegistry.RegisterForNavigation<TerminosPage, TerminosPageViewModel>();
            containerRegistry.RegisterForNavigation<OlvidarPage, OlvidarPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<MenuLogin, MenuLoginViewModel>(); 
            containerRegistry.RegisterForNavigation<MenuMain, MenuMainViewModel>(); 
            containerRegistry.RegisterForNavigation<MainHome, MainHomeViewModel>();            
            #endregion

            #region Declaracion de interfaz
            containerRegistry.RegisterInstance<IUserDialogs>(UserDialogs.Instance);
            #endregion


            #region REGISTRO DE POPUD
            //containerRegistry.RegisterPopupNavigationService();

            containerRegistry.RegisterForNavigation<PopupPhoto, PopupPhotoViewModel>();
            #endregion
        }
    }
}
