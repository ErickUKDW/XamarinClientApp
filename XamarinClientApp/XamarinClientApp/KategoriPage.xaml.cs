using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinClientApp.ViewModels;
using XamarinClientApp.Models;

namespace XamarinClientApp
{
    public partial class KategoriPage : ContentPage
    {
        public KategoriPage()
        {
            InitializeComponent();
            this.BindingContext = new KategoriViewModel();

            listKategori.ItemTapped += ListKategori_ItemTapped;
        }

        private void ListKategori_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Kategori item = (Kategori)e.Item;
            EditKategoriPage editPage = new EditKategoriPage();
            editPage.BindingContext = item;
            Navigation.PushAsync(editPage);
        }
    }
}
