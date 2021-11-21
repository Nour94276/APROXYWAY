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
    public partial class placetovisit : ContentPage
    {


        List<M_Posts> m_Posts = new List<M_Posts>();
        string nom1, img1; 
        public placetovisit( string nom , string img)
        {
            nom1 = nom;
            img1 = img; 
            InitializeComponent();
            listViewPlaceTovisit.SelectedItem = null; 
            img_town.Source = img;
            Town_name.Text = nom;
            List<PLACE_TO_VISIT> pLACE_TO_VISITs = new List<PLACE_TO_VISIT>();

            pLACE_TO_VISITs.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 1, City = "Thory", 
                Description = "La Grande Cascade de Tendon est située sur la limite des communes de Tendon et du Tholy. La cascade se trouve sur le ruisseau le Scouet, un affluent de la Moselle par le Barba et la Vologne",
                 GPS = "48.10038455284305, 6.697219900976298", nom_Place_To_Visit = "Grande Cascade de Tendon" , img= "cascadethory.jpg" });
            pLACE_TO_VISITs.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 2, City = "Thory",
                Description = "Le Lac de Gérardmer situé à 660m d'altitude est un lac d'origine glaciaire. Il est également le plus grand lac naturel des Vosges avec ses 155ha de surface",
                GPS = "48.069105152936245, 6.85484113105451", nom_Place_To_Visit = "Lac de Gérardmer, Gérardmer", img = "lacthory.jpg" });
            pLACE_TO_VISITs.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 3, City = "Thory",
                Description = "Métabief est la station de ski principale du Haut-Doubs, " +
                "située sur le massif du Mont d'Or entre 900 et 1430m d'altitude, elle offre un " +
                "large choix de pistes et d'activités hivernales pour plaire à tout le monde ! " +
                "Ainsi, les 37 km de pistes de ski et les 4 zones ludiques permettront à toute la famille " +
                "de s'initier ou de se perfectionner à toutes les pratiques : ski alpin, snowboard, freestyle... et même au freeride avec des hors-pistes sécurisés. 2 écoles de ski sont également présentes sur la station pour vous faire découvrir toutes les sortes de glisse.",
                GPS = "46.768109349323524, 6.356723539873862", nom_Place_To_Visit = "Station de ski Métabif", img = "metabif.jpg" });

            List<PLACE_TO_VISIT> pLACE_TOs_Annecy = new List<PLACE_TO_VISIT>();
            pLACE_TOs_Annecy.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 4, City = "Annecy",
                Description = "Quartier pittoresque comprenant un château médiéval et des bâtiments aux tons pastel en bord de canal, avec des cafés en plein air.",
                GPS = "45.907735425318855, 6.126440433076401", nom_Place_To_Visit = "Vieille Ville d'Annecy", img = "vielleville.jpg" });
            pLACE_TOs_Annecy.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 5, City = "Annecy",
                Description = "Avec son agréable balade face au lac à deux pas de la ville, les jardins de l’Europe sont avec le Pâquier une des promenades préférées des annéciens et des touristes. Les jardins de l’Europe sont un grand parc arboré jouissant de plantations centenaires, les jeux d’ombre et de lumières procurée par ces derniers ravissent les passants, les peintres et les amoureux de la nature.", GPS = "45.90534647986669, 6.130216983348338", nom_Place_To_Visit = "Jardins de l'Europe", img = "jdran.jpg"
            });
            pLACE_TOs_Annecy.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 6, City = "Annecy",
                Description = "Le château de Menthon puis de Menthon-Saint-Bernard est une ancienne maison forte, du Xᵉ siècle, remanié à plusieurs reprises et restauré au XIXᵉ siècle dans un style néogothique, qui se dresse sur la commune de Menthon-Saint-Bernard dans le département de la Haute-Savoie en région Auvergne-Rhône-Alpes. ", GPS = "45.871086374890425, 6.202078777960153", nom_Place_To_Visit = "Château de Menthon-Saint-Bernard", img = "chateau.jpg" });

            List<PLACE_TO_VISIT> pLACE_TOs_SaintCirq = new List<PLACE_TO_VISIT>();
            pLACE_TOs_SaintCirq.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 7, City = "Saint-Cirq-Lapopie", Description = "Un village médiéval déserté est un village abandonné au Moyen Âge. En France, plusieurs villages ont été sondés partiellement ou entièrement et par des chercheurs de multiples disciplines.", GPS = "44.46687898071304, 1.669460466636794", nom_Place_To_Visit = "Village médiéval", img = "ville.jpg" });
            pLACE_TOs_SaintCirq.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 8, City = "Saint-Cirq-Lapopie", Description = "La balade commence à Bouziès, petit village au cœur de la Vallée du Lot entre Cahors et Saint-Cirq-Lapopie. L’arrivée dans le village est assez atypique, car vous traversez un pont suspendu qui surplombe la rivière du Lot, une voiture à la fois donc soyez prudent.", GPS = "44.47944110486424, 1.645133461661379", nom_Place_To_Visit = "Chemin de Halage (Partie Creusée)", img = "creuse.jpg" });
            pLACE_TOs_SaintCirq.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 9, City = "Saint-Cirq-Lapopie", Description = "En bateau sur le Lot, vous profitez des vues les plus impressionnantes de cette région. Les falaises vertigineuses qui plongent dans la rivière sinueuse donnent la sensation d’être sur une terre quasi inhabitée ! Ajoutez à cela, la superbe ville de Cahors et le charme pittoresque du village de Saint-Cirq-Lapopie et vous obtenez le cadre idéal pour des vacances fluviales.", GPS = "45.871086374890425, 6.202078777960153", nom_Place_To_Visit = "Croisssière le lot" , img="lot.jpg" });


            List<PLACE_TO_VISIT> pLACE_TOs_Milan = new List<PLACE_TO_VISIT>();
            pLACE_TOs_Milan.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 10, City = "Milan", Description = "Santa Maria delle Grazie est une église et un monastère dominicain de Milan. L'édifice gothique, de l'architecte Guiniforte Solari, s'est vu amputé de son abside en 1492 pour faire place à une « tribune » correspondant mieux au goût du temps, chef-d'œuvre de l'architecture Renaissance, dû à l'architecte Bramante. Le réfectoire du monastère abrite la célèbre Cène de Léonard de Vinci.", GPS = "45.46727166084475, 9.171229004760491", nom_Place_To_Visit = "Église Santa Maria delle Grazie", img = "eglise.jpg" });
            pLACE_TOs_Milan.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 11, City = "Milan", Description = "Le château des Sforza, situé dans le centre-ville de Milan en Italie, est une forteresse construite au XVᵉ siècle par Francesco Sforza, duc de Milan, sur les ruines d'une citadelle édifiée au même endroit par Galéas II Visconti. Il est aujourd'hui transformé en musée.", GPS = "45.47172587658506, 9.179726242872341", nom_Place_To_Visit = "Château des Sforza", img = "milanchateau.jpg" });
            pLACE_TOs_Milan.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 12, City = "Mialn", Description = "La Galleria Vittorio Emanuele II est une galerie commerçante historique de prestige de style néo-classique à tendance baroque du xixe siècle du centre de Milan. Surnommée le « salon de Milan », elle constitue un passage entre la place du Dôme de Milan et la Scala. Elle a été baptisée du nom du roi Victor-Emmanuel II d'Italie.", GPS = "45.467630151873735, 9.190025915870779", nom_Place_To_Visit = "Galleria Vittorio Emanuele II", img = "galleri.jpg" });


            List<PLACE_TO_VISIT> pLACE_TOs_COMO = new List<PLACE_TO_VISIT>();
            pLACE_TOs_COMO.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 13, City = "Como", Description = "Le centre-ville est situé au bord du lac, autour de la Piazza del Duomo , l'un des monuments les plus populaires du nord de l'Italie . Le noyau historique a encore l'apparence du castrum romain d' origine , avec des murs médiévaux bien conservés et de grandes tours de guet.", nom_Place_To_Visit = "Lungolago Viale Geno", img = "lun.jpg" });
            pLACE_TOs_COMO.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 14, City = "Como", Description = "Offrant une vue sur le lac de Côme et les montagnes environnantes, ce funiculaire mène à des sentiers de randonnée en altitude.", GPS = "45.47172587658506, 9.179726242872341", nom_Place_To_Visit = "Téléphérique  Funiculaire Côme-Brunate", img = "telepherique.jpg" });
            pLACE_TOs_COMO.Add(new PLACE_TO_VISIT { ID_PLace_To_Visit = 15, City = "Como", Description = "Découvrez le restaurant sur le lac de Côme et le meilleur moyen en bateau pour déjeuner ou dîner pour une expérience inoubliable.", GPS = "45.85950113163592, 9.09710808641278", nom_Place_To_Visit = "Boat Restaurant", img = "restocomo.jpg" });

            m_Posts.Add(new M_Posts { ID_Posts = 1, img = "thory.jpg", Town = "France", City = "Tholy", GPS = "", Description = "", Place_To_Visit = pLACE_TO_VISITs  });
            m_Posts.Add(new M_Posts { ID_Posts = 2, img = "vieilleville.jpg", Town = "France", City = "Annecy", GPS = "", Description = "", Place_To_Visit = pLACE_TOs_Annecy });
            m_Posts.Add(new M_Posts { ID_Posts = 3, img = "saintcirqlapipie.jpg", Town = "France", City = "Saint-Cirq-Lapopie", GPS = "", Description = "", Place_To_Visit = pLACE_TOs_SaintCirq });


            m_Posts.Add(new M_Posts { ID_Posts = 1, img = "milan.jpg", Town = "Italie", City = "Milan", GPS = "", Description = "", Place_To_Visit = pLACE_TOs_Milan });
            m_Posts.Add(new M_Posts { ID_Posts = 2, img = "como.png", Town = "Italie", City = "Como", GPS = "", Description = "", Place_To_Visit = pLACE_TOs_COMO });
            List<M_Posts> m_s = new List<M_Posts>();
            foreach (var item in m_Posts)
            {
                if(item.Town == nom)
                {
                    
                    m_s.Add(item); 
                }
               
            }
            if(m_s.Count >0)
            {
                listViewPlaceTovisit.ItemsSource = m_s;
                Exist.IsVisible = true; 
            }
           else { Comming.IsVisible = true;  }; 

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new discoverpage());
        }

        private void listViewPlaceTovisit_ItemTapped(object sender, Telerik.XamarinForms.DataControls.ListView.ItemTapEventArgs e)
        {
            M_Posts One_Posts = e.Item as M_Posts;
            var list = One_Posts.Place_To_Visit;
            Navigation.PushModalAsync(new detailplacetovisit(list , nom1 , img1));
            listViewPlaceTovisit.SelectedItem = null;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                listViewPlaceTovisit.ItemsSource = m_Posts;
            }

            else
            {
                listViewPlaceTovisit.ItemsSource = m_Posts.Where(x => x.City.StartsWith(e.NewTextValue));
            }


        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new discoverpage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new login();
        }
        private void RadButton_Clicked(object sender, EventArgs e)
        {
            drawer.IsOpen = !drawer.IsOpen;

        }

    }
}