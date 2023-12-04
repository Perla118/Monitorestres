using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Monitorestres.ViewModel;
using Monitorestres.View;

namespace Monitorestres
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //BindingContext = new VMmenuPrincipal(Navigation);
            //BindingContext = new VMestres(Navigation);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
