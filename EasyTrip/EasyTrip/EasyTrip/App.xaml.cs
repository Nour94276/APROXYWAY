using EasyTrip.Models;
using EasyTrip.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyTrip
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new login());
            InitDb();
        }

        private void InitDb()
        {
            DataBase db = DataBase.GetInstance();
            try
            {
                db.AddTable(typeof(M_User));
                db.CheckExistence();
            }
            //Les tables de la db n'existent pas
            catch
            {
                db.CreateTables();
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
