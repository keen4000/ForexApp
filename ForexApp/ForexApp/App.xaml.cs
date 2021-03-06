﻿
using ForexApp.Services;
using ForexApp.ViewModels;
using ForexApp.Views;

using Prism;
using Prism.Autofac;
using Prism.Ioc;

namespace ForexApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton(typeof(IForexServiceConfiguration), typeof(ForexServiceConfiguration));
            containerRegistry.RegisterSingleton(typeof(IForexService), typeof(ForexService));

            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>(Pages.Main);
            containerRegistry.RegisterForNavigation<QuoteDetailPage, QuoteDetailViewModel>(Pages.QuoteDetail);
        }

        protected override void OnInitialized()
        {
            this.InitializeComponent();

            this.NavigationService.NavigateAsync(Pages.Main);
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}