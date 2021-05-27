using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarincsharp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
           
        }

        //Methode de cycle de vie 

        protected override void OnStart()
        {
            
            Debug.WriteLine("Onstart");
            if (Current.Properties.ContainsKey("MainPageID"))
            {
                var id = Current.Properties["MainPageID"];
                Debug.WriteLine("Onstart-" + id);

            }
          

        }

        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("OnResume");
            if (Current.Properties.ContainsKey("MainPageID"))
            {
                var id = Current.Properties["MainPageID"];
                Debug.WriteLine("OnResume-" + id);

            }
        }
    }
}
