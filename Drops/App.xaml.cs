using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Drops.Data;
using Drops.Models; // prabably don't need
using Drops.Views;
using System.IO;
using System;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)] // used to be located in AssemblyInfo.CS, looks like I don't need it in a separate file though? maybe it's best practice to store the attribute in a separate classfile and the example wher I saw it in App.Xaml.cs was for the sake of brevity?
namespace Drops
{
    public partial class App : Application
    {
        static DropDatabase database;

        public static DropDatabase Database
        {
            get
            {
                if (database == null)
                {
                    // where is environment defined in notes app?
                    database = new DropDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DropMap.db3"));
                }
                return database;
            }
        }

        // Constructor(s)
        public App()
        {

            InitializeComponent();

            // MainPage = new NavigationPage(new MapPage());
            MainPage = new NavigationPage(new LoginPage());
            
        }

        // LifeCycle Methods
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