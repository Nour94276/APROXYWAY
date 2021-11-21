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
    public partial class detailplacetovisit : ContentPage
    {
        private List<PLACE_TO_VISIT> place_To_Visit;
        string a, b;
        public detailplacetovisit(List<PLACE_TO_VISIT> pLACE , string nom , string img )
        {
           
            a = nom;
            b = img;
            InitializeComponent();
            place_To_Visit = pLACE;
            slideView.ItemsSource = place_To_Visit;
        }

        private void slideView_SlidingToIndex(object sender, Telerik.XamarinForms.Primitives.SlideView.SlideViewSlidingToIndexEventArgs e)
        {
            var slideView = sender as RadSlideViewPresenter;
            PLACE_TO_VISIT pLACE = new PLACE_TO_VISIT(); 
            var a = slideView.Id;


        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
           
            this.Navigation.PushAsync(new NavigationPage(new placetovisit(a , b)));

        }
       
    }
}