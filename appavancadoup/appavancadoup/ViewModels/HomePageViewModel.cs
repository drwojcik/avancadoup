﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appavancadoup.ViewModels
{
    public sealed class HomePageViewModel : ViewModelBase
    {
        private string title;

        public HomePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            ViewCollectionCommand = new DelegateCommand(async ()
                => await ExecuteViewCollectionCommand(collectionName));
        }

        private Task ExecuteViewCollectionCommand(string collectionName)
        {
            throw new NotImplementedException();
        }

        public ICommand ViewCollectionCommand { get; }
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
    }
}
