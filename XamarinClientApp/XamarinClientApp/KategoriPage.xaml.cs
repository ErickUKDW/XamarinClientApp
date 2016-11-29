using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinClientApp.ViewModels;

namespace XamarinClientApp
{
    public partial class KategoriPage : ContentPage
    {
        public KategoriPage()
        {
            InitializeComponent();
            this.BindingContext = new KategoriViewModel();
        }
    }
}
