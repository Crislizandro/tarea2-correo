using System;
using System.Runtime.InteropServices.ComTypes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using tarea2_correo.view;

namespace tarea2_correo
{
    public partial class App : Application
    {
        static controler.emplecontroler database;
        public static controler.emplecontroler Database
        {

            get 
            {
                if (database == null)
                {
                    var pathdatabase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "Programacion 4.db3";
                    var fullpath = Path.Combine(pathdatabase, dbname); 
                    database= new controler.emplecontroler(fullpath);
                }
            return database;
            }
        }



        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new PageListEmple());
            //MainPage = new NavigationPage( new Page1principal());
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
