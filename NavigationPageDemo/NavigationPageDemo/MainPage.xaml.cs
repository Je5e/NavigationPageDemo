using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationPageDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnNavigateToPageAButtonClicked
            (object sender, EventArgs args)
        {
                Navigation.PushAsync(new PageA());
        }
    }
}
