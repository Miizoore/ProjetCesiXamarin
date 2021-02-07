using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using ProjetCesiXamarin.Pages;
using ProjetCesiXamarin.Services;
using ProjetCesiXamarin.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetCesiXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationService navigationService = new NavigationService();

            navigationService.Configure("Home", typeof(Connection));
            navigationService.Configure("Inscription", typeof(Inscription));

            SimpleIoc.Default.Register<INavigationService>(() => navigationService);

            var firstPage = new NavigationPage(new Connection());
            navigationService.Initialize(firstPage);
            MainPage = firstPage;
        }

        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
