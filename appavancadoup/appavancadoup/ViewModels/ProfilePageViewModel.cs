using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using Prism.Services;

namespace appavancadoup.ViewModels
{
    public sealed class ProfilePageViewModel : ViewModelBase
    {
        public ProfilePageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
        }
    }
}
