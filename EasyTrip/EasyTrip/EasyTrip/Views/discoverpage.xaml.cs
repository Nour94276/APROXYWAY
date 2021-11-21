using EasyTrip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyTrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class discoverpage : ContentPage
    {
        List<town> _town = new List<town>();
        public discoverpage()
        {
            InitializeComponent();
            drawer.IsOpen = false;

            NavigationPage.SetHasNavigationBar(this, false);
            listViewtown.SelectedItem = null ; 
            _town.Add(new town { ID_Town = 1, town_gps = "", town_nom = "France"  , town_img="fr.jpg"});
            _town.Add(new town { ID_Town = 2, town_gps = "", town_nom = "Italie", town_img="It.jpg" });
            _town.Add(new town { ID_Town = 3, town_gps = "", town_nom = "Prague", town_img="prg.jpg" });
            _town.Add(new town { ID_Town = 4, town_gps = "", town_nom = "Suisse", town_img="suisse.jpg" });
            _town.Add(new town { ID_Town = 5, town_gps = "", town_nom = "Allemangne", town_img="all.jpg" });
            listViewtown.ItemsSource = _town;

        }

        private void listViewtown_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string nom_town , imagetown; 
            town townn = e.Item as town;
            nom_town = townn.town_nom;
            imagetown = townn.town_img;
            this.Navigation.PushModalAsync(new placetovisit(nom_town, imagetown));
           
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                listViewtown.ItemsSource = _town;
            }

            else
            {
                listViewtown.ItemsSource = _town.Where(x => x.town_nom.StartsWith(e.NewTextValue));
            }

        }

        private void RadButton_Clicked(object sender, EventArgs e)
        {
            drawer.IsOpen = !drawer.IsOpen;

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new discoverpage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Application.Current.MainPage = new login();
        }
    }
}