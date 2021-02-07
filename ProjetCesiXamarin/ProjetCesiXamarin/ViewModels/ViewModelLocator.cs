﻿using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetCesiXamarin.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<InscriptionViewModel>();
            SimpleIoc.Default.Register<ConnectionViewModel>();
        }

        public InscriptionViewModel InscriptionViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<InscriptionViewModel>();
            }
        }

        public ConnectionViewModel ConnectionViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ConnectionViewModel>();
            }
        }
    }
}
