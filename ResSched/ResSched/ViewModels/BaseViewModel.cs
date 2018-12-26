﻿using GalaSoft.MvvmLight;
using Ninject;
using ResSched.Interfaces;

namespace ResSched.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        protected IDataRetrievalService _dataService;

        public bool Init()
        {
            //TODO: move this to the constructors...but hey, so convienient just like this...maybe leave it as is...
            var ker = ((ResSched.App)Xamarin.Forms.Application.Current).Kernel;
            _dataService = ker.Get<IDataRetrievalService>();
            return true;
        }

        private bool _isBusy = false;
        private string title = string.Empty;
        //public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>() ?? new MockDataStore();

        public bool IsBusy
        {
            get { return _isBusy; }
            set { Set(ref _isBusy, value); }
        }

        public bool IsDevEnv
        {
            get
            {
#if DEV
                return true;
#else
                return false;
#endif
            }
        }

        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }
    }
}