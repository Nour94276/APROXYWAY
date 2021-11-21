using EasyTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyTrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public string prenom;
        public int id;
        public bool EPSI;
        public login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //try
            //{
            //    this.IsBusy = true;
            //     DisplayAlert("Alert", "You have been alerted", "OK");
            //}

            //finally
            //{
            //    this.IsBusy = false;
            //}

        }

 

        private void Button_Clicked(object sender, EventArgs e)
        {
           // this.Navigation.PushAsync(new Inscription());
        }

        private void Connexion_Clicked_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ERORMAIL.Text)) { ERORMAIL.IsVisible = true; };
            if (String.IsNullOrWhiteSpace(EMAIL.Text)) { ERORMAIL.IsVisible = true; };
            if (!String.IsNullOrWhiteSpace(EMAIL.Text) || !String.IsNullOrWhiteSpace(EMAIL.Text))
            {
                M_User m_User = new M_User();
                m_User.User_mail = EMAIL.Text;
                m_User.User_mdp = MDP.Text;
                if (m_User.CheckExistanceUser(m_User.User_mail, m_User.User_mdp).Count != 0)
                {

                    List<M_User> m_User1 = M_User.GetList(EMAIL.Text);
                    foreach (var item in m_User1)
                    {
                        prenom = item.User_prenom;
                        id = item.ID_User;
                    }

                    Application.Current.MainPage = new discoverpage();

                }
                else { ERORMdpOrMail.IsVisible = true; }
            }

        }

        private void Inscription_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync( new Inscription());

        }

    }
}