using FreshMvvm;
using FreshMvvmApp.Utility;
using FreshMvvmApp.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FreshMvvmApp
{
    public partial class App : Application
    {
        public App()
        {
            LoadNavContainer();
        }


        void LoadNavContainer()
        {
            FreshPageModelResolver.PageModelMapper = new MvvmConventionPageModelMapper(); //Use custom name mapper for View/ViewModel folder separation
            var _mainPage = FreshPageModelResolver.ResolvePageModel<MainPageViewModel>();
            var _navContainer = new FreshNavigationContainer(_mainPage);
            MainPage = _navContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
