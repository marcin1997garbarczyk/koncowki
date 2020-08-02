using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KoncowkiZBudowy
{
    public partial class App : Application
    {
        public App()
        {
        }

        protected override void OnStart()
        {
            Device.OpenUri(new Uri("https://koncowkizbudowy.pl/"));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            Device.OpenUri(new Uri("https://koncowkizbudowy.pl/"));
        }
    }

}
