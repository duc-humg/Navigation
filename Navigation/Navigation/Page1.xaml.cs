using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new Class2();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myday = e.Item as Class1;
            await Navigation.PushAsync(new Page2(myday.name, myday.image, myday.thongtin, myday.noidung));
        }
    }
}