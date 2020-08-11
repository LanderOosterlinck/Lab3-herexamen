using Ex01_DailyShow.Models;
using Ex01_DailyShow.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ex01_DailyShow
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ShowGuests();
        }

        public void ShowGuests()
        {
            imgHeader.Source = ImageSource.FromResource("Ex01_DailyShowGuests.Assets.header_image.png");
            imgName.Source = ImageSource.FromResource("Ex01_DailyShowGuests.Assets.trevornoah.jpg");
            List<Guest> guests = GuestRepository.ReadGuests();
            lvwGuests.ItemsSource = guests;
        }
    }
}
