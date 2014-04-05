﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Primula.W8.ViewModels
{
    public abstract class ViewModelBase : Screen 
    {
        private readonly INavigationService _navigationService;

        protected ViewModelBase(INavigationService navigationService)
        {
            this._navigationService = navigationService;
        }

        public void GoBack()
        {
            _navigationService.GoBack();
        }

        public bool CanGoBack
        {
            get
            {
                return _navigationService.CanGoBack;
            }
        }
    }
}
