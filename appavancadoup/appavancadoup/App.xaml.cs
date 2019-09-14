using appavancadoup.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appavancadoup
{
    public partial class App : PrismApplication
    {
        //PAra poder usar componentes do xamarin forms junto e não somente o Prism
        public App() : this(null) { }
        public App(IPlatformInitializer platformInitializer)
            : base(platformInitializer, true)
        {
        }

        public App(IPlatformInitializer platformInitializer, bool setFormsDependencyResolver)
            : base(platformInitializer, setFormsDependencyResolver)
        {
        }


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<HomePage>();
            containerRegistry.RegisterForNavigation<NewCollectionPage>();
            containerRegistry.RegisterForNavigation<ProfilePage>();
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}?selectedTab={nameof(HomePage)}");

        }
    }
}
