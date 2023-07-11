using Hockey.Models;
using Hockey.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hockey.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	
    public partial class Player : ContentPage
    {

        public Player()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Product = e.Item as Item;

            var xx = BindingContext as Data;

            xx?.show(Product);

        }

    }
}