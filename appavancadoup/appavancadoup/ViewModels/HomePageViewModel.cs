using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace appavancadoup.ViewModels
{
    public sealed class HomePageViewModel : BindableBase
    {
        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
    }
}
