using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProjetCesiXamarin.ViewModels
{
    public class ConnectionViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;


        public ICommand NavigateToInscriptionCommand { get; set; }

        public ConnectionViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToInscriptionCommand = new RelayCommand(() => NavigateToInscription());
        }

        public void NavigateToInscription()
        {
            _navigationService.NavigateTo("Inscription");
        }
    }
    
        
}

