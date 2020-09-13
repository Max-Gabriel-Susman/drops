using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Drops.Data;
using Drops.Models; // prabably don't need
using Drops.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)] 
namespace Drops
{
    public partial class App : Application
    {
        // we're gonna want to create an analog of the for DropDatabase
        static TodoItemDatabase database;

        public App()
        {
            InitializeComponent();

            // we can get rid of all of this shit
            var nav = new NavigationPage(new TodoListPage());
            // nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"]; // primalry green is mia wtf
            nav.BarBackgroundColor = Color.Default;
            nav.BarTextColor = Color.Black;

            // MainPage is the rootpage of an application
            MainPage = nav;
        }

        public static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    // we're gonna wanna change this to DropDataBase
                    database = new TodoItemDatabase();
                }
                return database;
            }
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