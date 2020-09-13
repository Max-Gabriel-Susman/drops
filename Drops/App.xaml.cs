using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Drops.Data;
using Drops.Models; // prabably don't need
using Drops.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)] // used to be located in AssemblyInfo.CS, looks like I don't need it in a separate file though? maybe it's best practice to store the attribute in a separate classfile and the example wher I saw it in App.Xaml.cs was for the sake of brevity?
namespace Drops
{
    public partial class App : Application
    {
        // we're gonna want to create an analog of the for DropDatabase
        static DropDatabase database;

        // Constructor(s)
        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new MapPage());
            
        }

        public static DropDatabase Database
        {
            get
            {
                if (database == null)
                {
                    // we're gonna wanna change this to DropDataBase
                    database = new DropDatabase();
                }
                return database;
            }
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