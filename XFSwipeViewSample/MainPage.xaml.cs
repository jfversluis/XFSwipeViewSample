using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFSwipeViewSample
{
    public partial class MainPage : ContentPage
    {
        public List<string> MyItems { get; set; } = new List<string>()
        {
            "Hi there",
            "Please subscribe",
            "to my channel"
        };

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Swipe!", "Invoked", "OK");
        }
    }
}
